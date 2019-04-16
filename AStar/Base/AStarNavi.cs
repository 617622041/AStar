using AStar.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  AStar.Base
{
    public class Track
    {
        public Map NaviMap { get; set; }
        public Vector2 PointIndex { get; set; }
        public Dictionary<Vector2, Single> NextPoints { get; set; }
        public int Index { get; set; }

        private List<KeyValuePair<Vector2, Single>> mOrders;
        public Track(Map naviMap, Vector2 pointIndex)
        {
            NaviMap = naviMap;
            PointIndex = pointIndex;
            NextPoints = new Dictionary<Vector2, Single>();
            Index = 0;
        }

        public void AddNextPoint(Vector2 pointIndex, float kValue)
        {
            NextPoints.Add(pointIndex, kValue);
        }

        public void Sort()
        {
            Dictionary<Vector2, Single> points = NextPoints;
            mOrders = points.OrderBy(p => p.Value).ToList();
        }

        public Vector2 GetRoadIndex()
        {
            Vector2 ret = null;
            while (ret == null && Index < mOrders.Count)
            {
                ret = (mOrders.Count > 0 && Index < mOrders.Count) ? mOrders[Index].Key : null;
                ret = NaviMap.GetPoint(ret).Invalid ? null : ret;
                Index++;
            }
            return ret;
        }
    }

    public class AStarNavi
    {
        public Map NaviMap { get; set; }
        public RoadPoint StartPoint { get; set; }
        public RoadPoint EndPoint { get; set; }
        public Vector2 StartIndex { get; set; }
        public Vector2 EndIndex { get; set; }

        public Vector2 CurentIndex { get; set; }

        private Stack<Track> mTracks = new Stack<Track>();

        public AStarNavi(Map naviMap, Vector2 startIndex, Vector2 endIndex)
        {
            NaviMap = naviMap;
            StartIndex = startIndex;
            CurentIndex = startIndex;
            EndIndex = endIndex;
        }


        public void Start(Vector2 start, Vector2 end)
        {
            StartIndex = start;
            EndIndex = end;
            CurentIndex = start;
            mTracks.Clear();
        }

        //private void Running()
        //{
        //    Vector2 orginIndex = mStartIndex;
        //    Vector2 targeIndex = mEndIndex;
        //    Vector2 curreIndex = orginIndex;
        //    RoadPoint[,] roadPoints = this.starMap1.getRoadPoint();

        //    RoadPoint targePoint = roadPoints[targeIndex.y, targeIndex.x];
        //    RoadPoint currePoint = roadPoints[curreIndex.y, curreIndex.x];
        //    List<Vector2> nextIndexs = new List<Vector2>();

        //    RoadPoint roadPoint;
        //    float minKValue = 100000;
        //    float currentKValue = 0;
        //    Vector2 nextIndex = Vector2.ZERO;
        //    RoadPoint nextPoint = null;

        //    while (curreIndex != targeIndex)
        //    {
        //        minKValue = 100000;
        //        currePoint = roadPoints[curreIndex.y, curreIndex.x];
        //        currePoint.Passed = true;
        //        nextIndexs.Clear();
        //        nextIndexs.Add(curreIndex + Vector2.LEFT + Vector2.UP);
        //        nextIndexs.Add(curreIndex + Vector2.ZERO + Vector2.UP);
        //        nextIndexs.Add(curreIndex + Vector2.RIGHT + Vector2.UP);
        //        nextIndexs.Add(curreIndex + Vector2.ZERO + Vector2.RIGHT);
        //        nextIndexs.Add(curreIndex + Vector2.DOWN + Vector2.RIGHT);
        //        nextIndexs.Add(curreIndex + Vector2.DOWN + Vector2.ZERO);
        //        nextIndexs.Add(curreIndex + Vector2.DOWN + Vector2.LEFT);
        //        nextIndexs.Add(curreIndex + Vector2.ZERO + Vector2.LEFT);

        //        foreach (var index in nextIndexs)
        //        {
        //            roadPoint = GetRoadPoint(index.x, index.y, roadPoints);
        //            if (roadPoint != null && roadPoint.EnableCross && !roadPoint.Passed)
        //            {
        //                currentKValue = roadPoint.GetKValue(currePoint, targePoint);
        //                if (currentKValue < minKValue)
        //                {
        //                    minKValue = currentKValue;
        //                    nextIndex = index;
        //                    nextPoint = roadPoint;
        //                }
        //            }
        //        }
        //        curreIndex = nextIndex;
        //        currePoint = nextPoint;
        //    }
        //}

       

        public bool IsEnded() { return CurentIndex == EndIndex; }
        private bool IsInTracks(Vector2 index)
        {
            bool ret = false;
            for (int i = mTracks.Count - 1; i >= 0; --i)
            {
                ret = mTracks.ElementAt<Track>(i).PointIndex == index;
                if (ret)
                    break;
            }

            return ret;
        }


        public RoadPoint NextRoadPoint()
        {
            RoadPoint ret = null;
            if (CurentIndex != EndIndex)
            {
                RoadPoint roadPoint = null;
                float currentKValue = 0;
                Track track = new Track(NaviMap, CurentIndex);
                List<Vector2> nextIndexs = new List<Vector2>();
                nextIndexs.Add(CurentIndex + Vector2.LEFT + Vector2.UP);
                nextIndexs.Add(CurentIndex + Vector2.ZERO + Vector2.UP);
                nextIndexs.Add(CurentIndex + Vector2.RIGHT + Vector2.UP);
                nextIndexs.Add(CurentIndex + Vector2.ZERO + Vector2.RIGHT);
                nextIndexs.Add(CurentIndex + Vector2.DOWN + Vector2.RIGHT);
                nextIndexs.Add(CurentIndex + Vector2.DOWN + Vector2.ZERO);
                nextIndexs.Add(CurentIndex + Vector2.DOWN + Vector2.LEFT);
                nextIndexs.Add(CurentIndex + Vector2.ZERO + Vector2.LEFT);

                foreach (var index in nextIndexs)
                {
                    roadPoint = NaviMap.GetPoint(index.x, index.y);
                    if (roadPoint != null && roadPoint.EnableCross && !roadPoint.Invalid && !IsInTracks(index))
                    {
                        currentKValue = roadPoint.GetKValue(NaviMap.GetPoint(CurentIndex), NaviMap.GetPoint(EndIndex));
                        track.AddNextPoint(index, currentKValue);
                    }
                }
                track.Sort();
                mTracks.Push(track);
                Vector2 roadIndex = null;
                while (roadIndex == null)
                {
                    track = mTracks.Peek();
                    roadIndex = track.GetRoadIndex();
                    if (roadIndex == null)
                    {
                        mTracks.Pop();
                        NaviMap.GetPoint(track.PointIndex).Invalid = true;
                    }
                }

                CurentIndex = roadIndex;
                ret = NaviMap.GetPoint(CurentIndex);
            }

            return ret;
        }

        private bool mIsRollBack = false;

        public RoadPoint NextRoadPointNew()
        {
            RoadPoint ret = null; 
            Track track = null;
            if (CurentIndex != EndIndex)
            {
                if (!mIsRollBack)
                {
                    RoadPoint roadPoint = null;
                    float currentKValue = 0;
                    track = new Track(NaviMap, CurentIndex);
                    List<Vector2> nextIndexs = new List<Vector2>();
                    nextIndexs.Add(CurentIndex + Vector2.LEFT + Vector2.UP);
                    nextIndexs.Add(CurentIndex + Vector2.ZERO + Vector2.UP);
                    nextIndexs.Add(CurentIndex + Vector2.RIGHT + Vector2.UP);
                    nextIndexs.Add(CurentIndex + Vector2.ZERO + Vector2.RIGHT);
                    nextIndexs.Add(CurentIndex + Vector2.DOWN + Vector2.RIGHT);
                    nextIndexs.Add(CurentIndex + Vector2.DOWN + Vector2.ZERO);
                    nextIndexs.Add(CurentIndex + Vector2.DOWN + Vector2.LEFT);
                    nextIndexs.Add(CurentIndex + Vector2.ZERO + Vector2.LEFT);

                    foreach (var index in nextIndexs)
                    {
                        roadPoint = NaviMap.GetPoint(index.x, index.y);
                        if (roadPoint != null && roadPoint.EnableCross && !roadPoint.Invalid && !IsInTracks(index))
                        {
                            currentKValue = roadPoint.GetKValue(NaviMap.GetPoint(CurentIndex), NaviMap.GetPoint(EndIndex));
                            track.AddNextPoint(index, currentKValue);
                        }
                    }
                    track.Sort();
                    mTracks.Push(track);
                }

                track = mTracks.Peek();
                Vector2 roadIndex = track.GetRoadIndex();
                if (roadIndex == null)
                {
                    CurentIndex = track.PointIndex;
                    roadIndex = track.PointIndex;
                    mTracks.Pop();
                    NaviMap.GetPoint(track.PointIndex).Invalid = true;
                    mIsRollBack = true;
                }
                else
                {
                    mIsRollBack = false;
                }
                CurentIndex = roadIndex;
                ret = NaviMap.GetPoint(CurentIndex);
            }
            
            return ret;
        }
    }
}

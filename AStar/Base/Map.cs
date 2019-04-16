using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar.Base
{
    public class Map
    {
        public RoadPoint[,] RoadPoints { get; set; }


        public Map(RoadPoint[,] points)
        {
            RoadPoints = points;
        }

        public RoadPoint GetPoint(int x, int y)
        {
            RoadPoint ret = null;
            if (RoadPoints == null) return null;
            if (y >= 0 && y < RoadPoints.GetLength(0) && x >= 0 && x < RoadPoints.GetLength(1))
            {
                ret = RoadPoints[y, x];
            }
            return ret;
        }

        public RoadPoint GetPoint(Vector2 index)
        {
            return GetPoint(index.x, index.y);
        }
    }
}

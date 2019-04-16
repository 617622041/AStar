using AStar.Base;
using AStar.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AStar
{
    public partial class Form1 : Form
    {
        private Thread backWocker;
        private Vector2 mStartIndex;
        private Vector2 mEndIndex;
        private AStarNavi mNavigation;
        public Form1()
        {
            InitializeComponent();
            InItMap();
            this.runner1.Location = this.startPoint1.Location;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            backWocker.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.runner1.Visible = true;
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
            backWocker = thread;
        }

        private void Run()
        {
            while (!mNavigation.IsEnded())
            {
                Thread.Sleep(300);
                Point p = this.runner1.Location;
                RoadPoint point = mNavigation.NextRoadPointNew();
                AsyncUI(() => { this.runner1.Location = new Point(point.Position.x, point.Position.y); });
            }
            MessageBox.Show("Arrived to End Point!");
        }

        public void AsyncUI(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void InItMap()
        {
            List<Wall> walls = new List<Wall>();
            foreach (var control in this.starMap1.Controls)
            {
                if (control is Wall)
                {
                    walls.Add(control as Wall);
                }
            }
            this.starMap1.InitMap(walls);
            mStartIndex = this.starMap1.PointIndex(this.startPoint1.Location);
            mEndIndex = this.starMap1.PointIndex(this.endPoint1.Location);

            RoadPoint[,] points = this.starMap1.getRoadPoint();
            Map naviMap = new Map(points);
            mNavigation = new AStarNavi(naviMap, mStartIndex, mEndIndex);
        }

        private void Running()
        {
            Vector2 orginIndex = mStartIndex;
            Vector2 targeIndex = mEndIndex;
            Vector2 curreIndex = orginIndex;
            RoadPoint[,] roadPoints = this.starMap1.getRoadPoint();

            RoadPoint targePoint = roadPoints[targeIndex.y, targeIndex.x];
            RoadPoint currePoint = roadPoints[curreIndex.y, curreIndex.x];
            List<Vector2> nextIndexs = new List<Vector2>();

            RoadPoint roadPoint;
            float minKValue=100000;
            float currentKValue = 0;
            Vector2 nextIndex = Vector2.ZERO;
            RoadPoint nextPoint = null;

            while (curreIndex != targeIndex)
            {
                Thread.Sleep(300);
                minKValue=100000;
                currePoint = roadPoints[curreIndex.y, curreIndex.x];
                currePoint.Passed = true;
                nextIndexs.Clear();
                nextIndexs.Add(curreIndex + Vector2.LEFT + Vector2.UP);
                nextIndexs.Add(curreIndex + Vector2.ZERO + Vector2.UP);
                nextIndexs.Add(curreIndex + Vector2.RIGHT + Vector2.UP);
                nextIndexs.Add(curreIndex + Vector2.ZERO + Vector2.RIGHT);
                nextIndexs.Add(curreIndex + Vector2.DOWN + Vector2.RIGHT);
                nextIndexs.Add(curreIndex + Vector2.DOWN + Vector2.ZERO);
                nextIndexs.Add(curreIndex + Vector2.DOWN + Vector2.LEFT);
                nextIndexs.Add(curreIndex + Vector2.ZERO + Vector2.LEFT);

                foreach (var index in nextIndexs)
                {
                    roadPoint = GetRoadPoint(index.x, index.y, roadPoints);
                    if (roadPoint != null && roadPoint.EnableCross && !roadPoint.Passed)
                    {
                        currentKValue = roadPoint.GetKValue(currePoint, targePoint);
                        if (currentKValue < minKValue)
                        {
                            minKValue = currentKValue;
                            nextIndex = index;
                            nextPoint = roadPoint;
                        }
                    }
                }
                curreIndex = nextIndex;
                currePoint = nextPoint;

                AsyncUI(() => { this.runner1.Location = new Point(currePoint.Position.x, currePoint.Position.y); });
            }
        }

        private RoadPoint GetRoadPoint(int x, int y, RoadPoint[,] roadPoints)
        {
            RoadPoint ret = null;
            if (y >= 0 && y < roadPoints.GetLength(0) && x >= 0 && x < roadPoints.GetLength(1))
            {
                ret = roadPoints[y, x];
            }
            return ret;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Point pos = this.runner1.Location;
            switch (keyData)
            {
                case Keys.Up: this.runner1.Location = new Point(pos.X, pos.Y - 30); break;
                case Keys.Down: this.runner1.Location = new Point(pos.X, pos.Y + 30); break;
                case Keys.Left: this.runner1.Location = new Point(pos.X - 30, pos.Y); break;
                case Keys.Right: this.runner1.Location = new Point(pos.X + 30, pos.Y); break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}

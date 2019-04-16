using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using AStar.Base;

namespace AStar.Component
{
    public partial class StarMap : Panel
    {

        private int mCellWidth = 10;
        private RoadPoint[,] mRoadPoints = null;
        private int mRowCount = 0;
        private int mColumnCount = 0;

        [Category("Appearance"), Description("格子宽度")]
        public int CellWidth
        {
            get { return mCellWidth; }
            set
            {
                if (mCellWidth != value)
                {
                    mCellWidth = value;
                }
            }
        }


        public StarMap()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = CreateGraphics();
            DrawCell(graphics);
            //DrawUnCross(graphics);
        }

        private void DrawCell(Graphics graphics)
        {
            if (this.Height > 0 && this.Width > 0 && CellWidth > 0)
            {
                this.Height = (this.Height / CellWidth) * CellWidth;
                this.Width = (this.Width / CellWidth) * CellWidth;
                Pen pen = new Pen(Color.Red);

                for (int i = 0; i <= this.Height / CellWidth; ++i)
                {
                    graphics.DrawLine(pen, 0, CellWidth * i, this.Width, CellWidth * i);
                }

                for (int i = 0; i <= this.Width / CellWidth; ++i)
                {
                    graphics.DrawLine(pen, CellWidth * i, 0, CellWidth * i, this.Height);
                }

                graphics.DrawLine(pen, 1, this.Height - 1, this.Width - 1, this.Height - 1);
                graphics.DrawLine(pen, this.Width - 1, 1, this.Width - 1, this.Height - 1);
            }
        }

        private void DrawUnCross(Graphics graphics)
        {
            if (mRoadPoints != null)
            {
                RoadPoint roadPoint;
                Point p1;
                Point p2;
                for (int m = 0; m < mRowCount; ++m)
                {
                    for (int n = 0; n < mColumnCount; ++n)
                    {
                        roadPoint = mRoadPoints[m, n];
                        if (!roadPoint.EnableCross)
                        {
                            p1 = new Point(roadPoint.Position.x, roadPoint.Position.y);
                            p2 = new Point(roadPoint.Size.x + p1.X, roadPoint.Size.y + p1.Y);
                            graphics.FillRectangle(new SolidBrush(Color.DarkGray), p1.X, p1.Y, roadPoint.Size.x, roadPoint.Size.y);
                        }
                    }
                }
            }
        }

        public void InitMap(List<Wall> walls)
        {
            int columnCount = this.Width / CellWidth;
            int rowCount = this.Height / CellWidth;
            mColumnCount = columnCount;
            mRowCount = rowCount;

            RoadPoint[,] roadPoints = new RoadPoint[rowCount, columnCount];
            RoadPoint roadPoint = null;
            for (int m = 0; m < rowCount; ++m)
            {
                for (int n = 0; n < columnCount; ++n)
                {
                    roadPoint = new RoadPoint(n * CellWidth, m * CellWidth, CellWidth, CellWidth);
                    roadPoint.EnableCross = !(PointInWall(walls, roadPoint.Ancher));
                    roadPoints[m, n] = roadPoint;
                }
            }
            mRoadPoints = roadPoints;
            //Refresh();
        }

        public RoadPoint[,] getRoadPoint()
        {
            return mRoadPoints;
        }

        public Vector2 PointIndex(Point pos)
        {
            return new Vector2(pos.X / CellWidth, pos.Y / CellWidth);
        }

        private bool PointInWall(List<Wall> walls ,Vector2 pos)
        {
            bool ret = false;
            foreach (var w in walls)
            {
               ret= w.Contains(pos);
               if (ret)
                   break;
            }
            return ret;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar.Base
{
    public class RoadPoint
    {
        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; }
        public Vector2 Ancher { get; set; }

        public Boolean EnableCross { get; set; }
        public bool Passed { get; set; }
        public bool Invalid { get; set; }

        public RoadPoint(Vector2 posi, Vector2 size)
        {
            Position = posi;
            Size = size;
            Ancher = Position + size / 2;
            EnableCross = true;
            Passed = false;
            Invalid = false;
        }

        public RoadPoint(int x, int y, int width, int height)
        {
            Position = new Vector2(x, y);
            Size = new Vector2(width, height);
            Ancher = Position + Size / 2;
            EnableCross = true;
        }

        public float GetKValue(RoadPoint current, RoadPoint Target){
            float ret = 0.0f;
            ret = (float)Target.Ancher.Distance(Ancher) + (float)current.Ancher.Distance(Ancher);
            return ret;
        }
    }
}

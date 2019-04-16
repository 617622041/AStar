using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar.Base
{
    public class Vector2
    {
        public int x { get; set; }
        public int y { get; set; }


        public Vector2(int nx, int ny)
        {
            x = nx;
            y = ny;
        }

        public Vector2(Vector2 v)
        {
            x = v.x;
            y = v.y;
        }

        public double Distance(Vector2 target)
        {
            return Math.Sqrt((target.x - x) * (target.x - x) + (target.y - y) * (target.y - y));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



        public override bool Equals(object obj)
        {
            bool ret = false;
            Vector2 vObj = obj as Vector2;
            if (vObj != null)
            {
                ret = this.x == vObj.x && this.y == vObj.y;
            }
            return ret;
        }


        public static readonly Vector2 ZERO = new Vector2(0, 0);
        public static readonly Vector2 LEFT = new Vector2(-1, 0);
        public static readonly Vector2 RIGHT = new Vector2(1, 0);
        public static readonly Vector2 UP = new Vector2(0, -1);
        public static readonly Vector2 DOWN = new Vector2(0, 1);

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            Vector2 ret = new Vector2(lhs);
            ret.x += rhs.x;
            ret.y += rhs.y;
            return ret;
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            Vector2 ret = new Vector2(lhs);
            ret.x -= rhs.x;
            ret.y -= rhs.y;
            return ret;
        }

        public static Vector2 operator *(Vector2 lhs, int rhs)
        {
            return new Vector2(lhs.x*rhs,lhs.y*rhs);
        }

        public static Vector2 operator /(Vector2 lhs, int rhs)
        {
            return rhs == 0 ? Vector2.ZERO : new Vector2(lhs.x / rhs, lhs.y / rhs);
        }

        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            if (object.Equals(lhs, null) && object.Equals(rhs, null)) return true;
            if (object.Equals(lhs, null) || object.Equals(rhs, null)) return false;
            return lhs.x == rhs.x && lhs.y == rhs.y;
        }

        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            if (object.Equals(lhs, null) && object.Equals(rhs, null)) return false;
            if (object.Equals(lhs, null) || object.Equals(rhs, null)) return true;
            return lhs.x != rhs.x || lhs.y != rhs.y;
        }
    }
}

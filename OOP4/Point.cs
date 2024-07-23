using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Point:ICloneable,IComparable
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int Z { set; get; }

        public Point() { }

        public Point(int x)
        {
            X = x; 
        }

        public Point(int x, int y) : this(x)
        {
            Y = y;
        } 

        public Point(int x, int y, int z) : this(x, y)
        {
            Z = z;
        }

        public Point(Point p)
        {
            X=p.X;
            Y=p.Y;
            Z=p.Z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public object Clone()
        {
            return new Point(this);
        }

        public int CompareTo(object? obj)
        {
            Point p = (Point)obj;
            if (this.X == p.X)
            {
                if (this.Y!=p.Y)
                {
                    if (this.Y > p.Y)
                    {
                        return 1;
                    }
                    else { return -1; }

                }
                return 0;


            }
            else
            {
                if (this.X > p.X)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}

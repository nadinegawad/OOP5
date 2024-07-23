using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Duration
    {
        public int Hours {  get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            return $"{Hours} Hours, {Minutes} Minutes, {Seconds} Seconds";
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Duration() { }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
         public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds = seconds % 3600;
            Minutes= seconds / 60;  
            Seconds= seconds % 60;
        }

        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) + (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) + (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0)+(right?.Seconds ?? 0)
            };
        }

        public static Duration operator +(Duration left, int right)
        {
            int hours = right / 3600;
            int minutes=(right%3600)/60;
            int sec= ((right % 3600) / 60)%60;
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) + hours,
                Minutes = (left?.Minutes ?? 0) + minutes,
                Seconds = (left?.Seconds ?? 0) +sec
            };
        }

        public static Duration operator +(int left, Duration right)
        {
            return right +left ;
        }

        public static Duration operator ++(Duration value)
        {
            return new Duration()
            {
                Hours = value?.Hours ?? 0 ,
                Minutes = value?.Minutes ?? 0 +1,
                Seconds = value?.Seconds ?? 0
            };
        }

        public static Duration operator --(Duration value)
        {
            return new Duration()
            {
                Hours = value?.Hours ?? 0,
                Minutes = value?.Minutes ?? 0 - 1,
                Seconds = value?.Seconds ?? 0
            };
        }

        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = (left?.Hours ?? 0) - (right?.Hours ?? 0),
                Minutes = (left?.Minutes ?? 0) - (right?.Minutes ?? 0),
                Seconds = (left?.Seconds ?? 0) - (right?.Seconds ?? 0)
            };
        }

        public static bool operator> (Duration left, Duration right)
        {
            if(left.Hours > right.Hours)
            {
                return true;
            }
            else
            {
                if(left.Minutes > right.Minutes)
                {
                    return true;
                }
                else
                {
                    if (left.Seconds > right.Seconds)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }



        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hours < right.Hours)
            {
                return true;
            }
            else
            {
                if (left.Minutes < right.Minutes)
                {
                    return true;
                }
                else
                {
                    if (left.Seconds < right.Seconds)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }



        public static bool operator >=(Duration left, Duration right)
        {
            if (left.Hours >= right.Hours)
            {
                return true;
            }
            else
            {
                if (left.Minutes >= right.Minutes)
                {
                    return true;
                }
                else
                {
                    if (left.Seconds >= right.Seconds)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }



        public static bool operator <=(Duration left, Duration right)
        {
            if (left.Hours <= right.Hours)
            {
                return true;
            }
            else
            {
                if (left.Minutes <= right.Minutes)
                {
                    return true;
                }
                else
                {
                    if (left.Seconds <= right.Seconds)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }



        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime()
            {
                
            };
        }
    }
}

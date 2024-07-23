using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Complex
    {
        public int real {  get; set; }
        public int imag { get; set; }

        public override string ToString()
        {
            return $"{real}+{imag}i";
        }

        #region binary operators
        public static Complex operator+(Complex left, Complex right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) + (right?.real ?? 0),
                imag = (left?.imag ?? 0) + (right?.imag ?? 0)
            };
        }
        public static Complex operator+(Complex left,int right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) + right,
                imag = (left?.imag ?? 0)
            };
        }

        public static Complex operator+(int left,Complex right)
        {
            return right+left;
        }

        public static Complex operator %(Complex left, Complex right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) % (right?.real ?? 0),
                imag = (left?.imag ?? 0) % (right?.imag ?? 0)
            };
        }

        public static Complex operator %(Complex left, int right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) % right,
                imag = (left?.imag ?? 0)
            };
        }


        public static Complex operator%(int left, Complex right)
        {
            return right % left;
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) - (right?.real ?? 0),
                imag = (left?.imag ?? 0) - (right?.imag ?? 0)
            };
        }

        public static Complex operator -(Complex left, int right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) - right,
                imag = (left?.imag ?? 0)
            };
        }

        public static Complex operator -(int left, Complex right)
        {
            return right - left;
        }


        public static Complex operator *(Complex left, Complex right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) * (right?.real ?? 0),
                imag = (left?.imag ?? 0) * (right?.imag ?? 0)
            };
        }

        public static Complex operator *(Complex left, int right)
        {
            return new Complex()
            {
                real = (left?.real ?? 0) * right,
                imag = (left?.imag ?? 0)
            };
        }

        public static Complex operator *(int left, Complex right)
        {
            return right * left;
        }

        public static Complex operator /(Complex left, Complex right)
        {
            if (right.real == 0 || right.imag == 0||right==default)
            {
                return new Complex()
                {
                    real = 0,
                    imag = 0
                };
            }
            else
            {
                return new Complex()
                {
                    real = (left?.real ?? 0) / (right.real ),
                    imag = (left?.imag ?? 0) / (right.imag )
                };
            }
           
        }

        public static Complex operator /(Complex left, int right)
        {
            if (right== 0 )
            {
                return new Complex()
                {
                    real = 0,
                    imag = 0
                };
            }
            else
            {
                return new Complex()
                {
                    real = (left?.real ?? 0) / right,
                    imag = (left?.imag ?? 0) 
                };
            }

        }

        public static Complex operator /(int left, Complex right)
        {
            if (right.real == 0)
            {
                return new Complex()
                {
                    real = 0,
                    imag = 0
                };
            }
            else
            {
                return right / left;
            }

        }

        #endregion

        #region unary operator
        public static Complex operator++(Complex value)
        {
            return new Complex()
            {
                real = value?.real ?? 0 + 1,
                imag = value.imag
            };
        }

        public static Complex operator --(Complex value)
        {
            return new Complex()
            {
                real = value?.real ?? 0 - 1,
                imag = value.imag
            };
        }
        #endregion

        #region comparison operators
        public static bool operator<(Complex left,Complex right)
        {
            return left.real < right.real;
        }


        public static bool operator >(Complex left, Complex right)
        {
            return left.real > right.real;
        }

        public static bool operator <=(Complex left, Complex right)
        {
            return left.real <= right.real;
        }

        public static bool operator >=(Complex left, Complex right)
        {
            return left.real >= right.real;
        }


        public static bool operator ==(Complex left, Complex right)
        {
            if (left?.real==right?.real)
                return left?.imag == right?.imag;
            return false;
        }

        public static bool operator !=(Complex left, Complex right)
        {
            return !(right==left);
        }









        #endregion
    }
}

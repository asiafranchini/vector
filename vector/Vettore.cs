using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vettori
{
    internal class Vettore
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vettore(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static Vettore Parse(string n)
        {
            string[] parts = n.Split(';');
            return new Vettore(double.Parse(parts[0]), double.Parse(parts[1]);
        }
        public override string ToString()
        {
            return string.Format("{0};{1}", X, Y);
        }
        public static bool TryParse(string n, out Vettore a)
        {
            try
            {
                a = Vettore.Parse(n);
                return true;
            }
            catch
            {
                a = null;
                return false;
            }
        }
        public static Vettore operator +(Vettore a, Vettore b)
        {
            return new Vettore(a.X + b.X, a.Y + b.Y);
        }
        public static Vettore operator -(Vettore a, Vettore b)
        {
            return new Vettore(a.X - b.X, a.Y - b.Y);
        }
        public static double operator *(Vettore a, Vettore b)
        {
            double prodotto = a.X * b.X + a.Y * b.Y;
            return prodotto;
        }
        public static Vettore operator *(Vettore a, double n)
        {
            return new Vettore(a.X * n, a.Y * n);
        }
        public static Vettore operator *(double n, Vettore a)
        {
            return new Vettore(a.X * n, a.Y * n);
        }
        public static Vettore operator /(Vettore a, double n)
        {
            return new Vettore(a.x / n, a.Y / n);
        }
        public static double Modulo(Vettore a)
        {
            return (Math.Sqrt(a.X * a.X + a.Y * a.Y));
        }
        public static bool operator ==(Vettore a, Vettore b)
        {
            if (a.X == b.X && a.Y == b.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Vettore a, Vettore b)
        {
            if (a.X == b.X && a.Y == b.Y)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static Vettore operator +(Vettore a)
        {
            return new Vettore(a.X, a.Y);
        }
        public static Vettore operator -(Vettore a)
        {
            return new Vettore(-a.X, -a.Y);
        }
    }
}


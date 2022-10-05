using System;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Triangle<T> : IGeometryObject<T> where T : struct, IComparable<T>
    {
        public T sideA { get; set; }
        public T sideB { get; set; }
        public T sideC { get; set; }

        public bool IsRectangular { get => Math.Pow(Math.Max(Math.Max((dynamic)sideA, (dynamic)sideB), (dynamic)sideC),2) ==
                                           Math.Pow(((dynamic)sideA),2) + Math.Pow(((dynamic)sideB),2) + Math.Pow(((dynamic)sideC),2) - Math.Pow(Math.Max(Math.Max((dynamic)sideA, (dynamic)sideB), (dynamic)sideC),2); }

        public Triangle(T sideA, T sideB, T sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public T Square()
        {
            var a = (dynamic)sideA;
            var b = (dynamic)sideB;
            var c = (dynamic)sideC;

            if(a + b <= c || a + c <= b || b + c <= a)
            {
                return (T)(dynamic)0;
            }

            var p = (a + b + c) / 2.0;

            return (T)Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}

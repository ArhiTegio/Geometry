using System;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Circle<T> : IGeometryObject<T> where T: struct, IComparable<T>
    {
        public T radius { get; set; }
        public T diameter { get => (dynamic)radius * 2; set { radius = (dynamic)radius / 2; } }

        public Circle(T radius)
        {
            this.radius = radius;
        }

        public T Square()
        {
            return (T)(Math.PI * (dynamic)radius * (dynamic)radius);
        }
    }
}

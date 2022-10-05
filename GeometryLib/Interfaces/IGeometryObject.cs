using System;
using System.Threading.Tasks;

namespace GeometryLib
{
    public interface IGeometryObject<T> where T : struct, IComparable<T>
    {
        T Square();
    }
}

using System.Linq;
using C4Net.Data.Adapters;
using C4Net.Data.Interfaces;

namespace C4Net.Data.Expressions
{
    public interface IQueryableObject : IOrderedQueryable
    {
        IDataContext Adapter { get; }
    }

    public interface IQueryableObject<T> : IQueryableObject, IOrderedQueryable<T>
    {
    }
}

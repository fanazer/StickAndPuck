#region Using

using System;
using System.Collections.Generic;

#endregion

namespace SAP.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);

        IEnumerable<T> FindBy(Predicate<T> predicate);

        void Save(T item);

        void Remove(int id);
    }
}
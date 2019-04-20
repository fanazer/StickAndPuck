using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SAP.API.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);

        IEnumerable<T> FindBy(Predicate<T> predicate);

        void Save(T item);

        void Remove(int id);
    }
}
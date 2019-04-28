#region Using

using System;
using System.Collections.Generic;

#endregion

namespace SAP.Business.Providers.People
{
    public interface IProvider<T>
    {
        T Get(int id);

        IEnumerable<T> FindBy(Predicate<T> predicate);
    }
}

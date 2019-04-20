#region Using

using System;
using System.Collections.Generic;

#endregion

namespace SAP.API.Business.Providers
{
    public interface IProvider<T>
    {
        T Get(int id);

        IEnumerable<T> FindBy(Predicate<T> predicate);
    }
}

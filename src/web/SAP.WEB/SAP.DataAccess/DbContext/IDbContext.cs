#region Using

using System;
using System.Collections.Generic;

#endregion

namespace SAP.DataAccess.DbContext
{
    public interface IDbContext : IDisposable
    {
        IEnumerable<T> Query<T>(string procedureName, object parameters);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FethiTekyaygilWebsite.Business.RepositoryFolder
{
    public interface IRepository
    {
        IEnumerable<TEntity> Query<TEntity>(string query);
        int Execute(string query);
    }
}

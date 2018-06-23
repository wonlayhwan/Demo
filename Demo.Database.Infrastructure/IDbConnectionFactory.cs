using System;
using System.Data;

namespace Demo.Database.Infrastructure
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}

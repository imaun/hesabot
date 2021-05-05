using System;
using System.Data;
using NPoco;

namespace Hesabot.Storage {

    public interface IDbFactory {


    }

    public class DbFactory {

        private readonly IDbConnection _connection;

        public DbFactory(IDbConnection connection)
            => _connection = connection;

        public IDatabase GetConnection()
            => new Database(_connection.);
    }
}

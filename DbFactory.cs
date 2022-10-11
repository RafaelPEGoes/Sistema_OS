using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace Sistema_OS
{
    internal class DbFactory
    {
        public FbConnection Connection()
        {
            FbConnection connection = new FbConnection();
            connection.ConnectionString = GetConnectionString();
            return connection;
        }

        public string GetConnectionString()
        {
            string line = string.Empty;
            string connectionString = string.Empty;

            using (StreamReader reader = new StreamReader("CONF.ini"))
            {
                while((line = reader.ReadLine()) != null)
                {
                    if(line.Contains("DATABASE"))
                    {
                        line.Replace("\\", "/");
                        reader.Close();
                        break;
                    }
                }
            }

            connectionString = $"User=SYSDBA;Password=masterkey;{line};DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType = 0;";
            return connectionString;
        }
    }
}

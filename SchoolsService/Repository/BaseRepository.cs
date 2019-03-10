using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SchoolsService.Repository
{
    public abstract class BaseSqlRepository
    {
        public IDbConnection DbConnection
        {
            get
            {
                var connectionStrings = ConfigurationManager.ConnectionStrings["admissions"];
                return new SqlConnection(connectionStrings.ConnectionString);
            }
        }

    }
}
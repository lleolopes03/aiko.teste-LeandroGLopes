using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;

namespace Mp.ApiDoteNet6.infra.Ioc
{
    internal class configuration
    {
        internal static Action<NpgsqlDbContextOptionsBuilder>? GetConnectionString(string v)
        {
            throw new NotImplementedException();
        }
    }
}
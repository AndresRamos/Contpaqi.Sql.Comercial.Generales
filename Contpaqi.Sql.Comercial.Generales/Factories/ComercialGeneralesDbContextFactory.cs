using System;
using System.Data.SqlClient;

namespace Contpaqi.Sql.Comercial.Generales.Factories
{
    public static class ComercialGeneralesDbContextFactory
    {
        public const string NombreBaseDatos = "CompacWAdmin";

        public static ComercialGeneralesDbContext CreateInstance(string contpaqiConnectionString)
        {
            if (contpaqiConnectionString == null)
            {
                throw new ArgumentNullException(nameof(contpaqiConnectionString));
            }

            var connectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString) {InitialCatalog = NombreBaseDatos};

            return new ComercialGeneralesDbContext(new SqlConnection(connectionStringBuilder.ToString()), true);
        }
    }
}
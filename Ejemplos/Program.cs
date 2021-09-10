using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Contpaqi.Sql.Comercial.Generales.Factories;

namespace Ejemplos
{
    public class Program
    {
        public static async Task Main()
        {
            const string connectionString = @"Data Source=AR-SERVER\COMPAC;User ID=sa;Password=Sdmramos1;";

            try
            {
                using (var context = ComercialGeneralesDbContextFactory.CreateInstance(connectionString))
                {
                    Console.WriteLine($"Connection String: {context.Database.Connection.ConnectionString}");

                    Console.WriteLine("Buscando empresas");
                    var empresas = await context.Empresas.AsNoTracking().OrderBy(e => e.CNOMBREEMPRESA).ToListAsync();

                    Console.WriteLine($"# de empresas: {empresas.Count}");

                    foreach (var empresa in empresas)
                    {
                        Console.WriteLine($"{empresa.CNOMBREEMPRESA.Trim()} | {empresa.CRUTADATOS.Trim()}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Fin");
            Console.ReadLine();
        }
    }
}
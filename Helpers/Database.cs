using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using Npgsql;

namespace TrabalhoBan.Helpers
{
    internal class Database
    {
        private static readonly string connectionString =
                                    "Host=aws-0-sa-east-1.pooler.supabase.com;" +
                                    "Port=5432;" +
                                    "Database=postgres;" +
                                    "Username=postgres.kbtzrqjbhxwwsxfslelk;" +
                                    "Password=BE8ezCwKS5hsDonD;" +
                                    "SSL Mode=Require;";

        public static async Task<DataTable> LerAsync(string sql)
        {
            using var connection = new NpgsqlConnection(connectionString);
            await connection.OpenAsync();

            using var command = new NpgsqlCommand(sql, connection);
            using var reader = await command.ExecuteReaderAsync();

            var tabela = new DataTable();
            tabela.Load(reader);

            return tabela;
        }

        public static async Task<int> EscreverAsync(string sql)
        {
            using var connection = new NpgsqlConnection(connectionString);
            await connection.OpenAsync();

            using var command = new NpgsqlCommand(sql, connection);

            return await command.ExecuteNonQueryAsync();
        }
    }
}

using Infraestrutura.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Infraestrutura.Data
{
    public class DapperContext : IDisposable
    {
        public IDbConnection Connection { get; set; }

        public DapperContext()
        {
            Connection = new SqlConnection(BuilderConfiguration.AddConfigurationDirectory().GetConnectionString("DefaultConnection"));
            Connection.Open();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

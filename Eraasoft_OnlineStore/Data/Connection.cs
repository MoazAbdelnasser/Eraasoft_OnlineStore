using System;
using System.Collections.Generic;
using System.Text;

namespace Eraasoft_OnlineStore.Data
{
    public static class Connection
    {
        //public string? Server { get; set; }
        //public string? Db { get; set; }
        //public string? User { get; set; }
        //public string? Password { get; set; }
        public const string connStr = """
            Server=MOAZABDELNASSER\SQLEXPRESS;
            Database=OnlineStore;
            User Id=sa;
            Password=Cisco_ip01;
            TrustServerCertificate=True;
            """;
    }
}

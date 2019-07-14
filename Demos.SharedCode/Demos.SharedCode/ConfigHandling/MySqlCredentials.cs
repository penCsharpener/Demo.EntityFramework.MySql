using System;
using System.Collections.Generic;
using System.Text;

namespace Demos.SharedCode.ConfigHandling {
    public class MySqlCredentials {
        public string ServerUrl { get; set; } = "localhost";
        public ushort Port { get; set; } = 3306;
        public string DatabaseName { get; set; } = "";
        public string Username { get; set; } = "root";
        public string Password { get; set; } = "superSecureSecret";

        public string GetConnectionString() {
            return $"server={ServerUrl};database={DatabaseName};user={Username};pwd={Password};port={Port}";
        }
    }
}

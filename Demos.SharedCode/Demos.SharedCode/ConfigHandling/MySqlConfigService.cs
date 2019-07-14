using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Demos.SharedCode.ConfigHandling {
    public class MySqlConfigService : IConfigService<MySqlCredentials> {
        public bool SettingsExist => File.Exists(_path);

        public MySqlCredentials Settings { get; private set; }

        protected readonly string _path;

        public MySqlConfigService(string path) {
            _path = path;
        }

        public MySqlCredentials ReadSettingsFile() {
            if (!SettingsExist) {
                Settings = new MySqlCredentials();
                WriteSettings(Settings);
                return Settings;
            }
            var json = File.ReadAllText(_path);
            return Settings = JsonConvert.DeserializeObject<MySqlCredentials>(json);
        }

        public void WriteSettings(MySqlCredentials obj) {
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(_path, json);
        }
    }
}

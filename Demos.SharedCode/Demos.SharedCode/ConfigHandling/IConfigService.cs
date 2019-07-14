using System;
using System.Threading.Tasks;

namespace Demos.SharedCode.ConfigHandling {
    public interface IConfigService<T> where T : class, new() {
        T Settings { get; }
        T ReadSettingsFile();
        void WriteSettings(T obj);
        bool SettingsExist { get; }
    }
}

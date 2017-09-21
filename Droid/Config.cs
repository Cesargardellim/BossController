using System;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(BossController.Droid.Config))]

namespace BossController.Droid
{
    public class Config : Entity.IConfig
    {
        public Config()
        {
        }

        private string _diretoryDB;
        public string DiretoryDB {
            get{
                if(string.IsNullOrEmpty(_diretoryDB)){
                    _diretoryDB = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }

                return _diretoryDB;
            }
        }

        /*
        private SQLite.Net.Interop.ISQLitePlatform _platform;
        public ISQLitePlatform Plataform {
            get{
                if(_platform == null){
                    _platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                }
                return _platform;
            }
        }

        */

    }
}

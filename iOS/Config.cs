using System;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(BossController.iOS.Config))]


namespace BossController.iOS
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
                    var diretory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    _diretoryDB = System.IO.Path.Combine(diretory, "..", "Library");
                }

                return _diretoryDB;

            }
        }


        private SQLite.Net.Interop.ISQLitePlatform _platform;
        public ISQLitePlatform Plataform {
            get{

                if(_platform == null){
                    _platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }
                return _platform;

            }
        }




    }
}

using System;
using Xamarin.Forms;
using SQLite;
using System.IO;

[assembly: Dependency(typeof(BossController.Droid.SQLite_Android))]

namespace BossController.Droid
{
    public class SQLite_Android : Entity.ISQLite
    {
        public SQLite_Android()
        {
        }

        public SQLite.SQLiteConnection GetConnection(){
            var FileName = "DBBossController.db3";
            string DocumentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(DocumentPath, FileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;


        }



    }
}

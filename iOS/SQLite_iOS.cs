using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(BossController.iOS.SQLite_iOS))]

namespace BossController.iOS
{
    public class SQLite_iOS : Entity.ISQLite
    {
        public SQLite_iOS()
        {
        }

        public SQLite.SQLiteConnection GetConnection(){
            var FileName = "DBBossController.db3";
            var DocumentPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var LibraryPath = Path.Combine(DocumentPath, "..", "Library");
            var path = Path.Combine(LibraryPath, FileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }



    }
}

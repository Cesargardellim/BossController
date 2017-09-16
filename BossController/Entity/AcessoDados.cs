using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace BossController.Entity
{
    public class AcessoDados : IDisposable
    {

        private SQLite.Net.SQLiteConnection _connection;


        public AcessoDados()
        {
            var config = DependencyService.Get<IConfig>();
            _connection = new SQLite.Net.SQLiteConnection(config.Plataform, System.IO.Path.Combine(config.DiretoryDB, "dbBossController.db3"));

			_connection.CreateTable<Boss>();
			_connection.CreateTable<World>();
            _connection.CreateTable<BossWorld>();
        }

        public void InsertStart(Boss boss){
            _connection.Query<Boss>("insert into Boss () values ()");
        }

        public void Insert(Boss boss){
            _connection.Insert(boss);
        }

        public void Update(Boss boss){
            _connection.Update(boss);
        }

        public List<Boss> Select (){
            return _connection.Table<Boss>().OrderBy(c => c.Id).ToList();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }




    }
}

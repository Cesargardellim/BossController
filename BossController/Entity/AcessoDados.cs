using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using SQLite;

namespace BossController.Entity
{
    public class AcessoDados : IDisposable
    {

        //private SQLite.Net.SQLiteConnection _connection;
        private SQLiteConnection _connection;

        public AcessoDados()
        {
			//var config = DependencyService.Get<IConfig>();
            //_connection = new SQLite.Net.SQLiteConnection(config.Plataform, System.IO.Path.Combine(config.DiretoryDB, "dbBossController.db3"));
            _connection = DependencyService.Get<ISQLite>().GetConnection();


			_connection.CreateTable<Boss>();
			_connection.CreateTable<World>();
            _connection.CreateTable<BossWorld>();

        }

        
        public void Insert(Boss boss){
            //if(boss.IdB != 0){
            //    _connection.Update(boss);
            //}else{
				_connection.Insert(boss);
			//}
		}

		public void InsertWorld(World w)
		{
			_connection.Insert(w);
		}

		public void InsertBossWorld(BossWorld bw)
		{
			_connection.Insert(bw);
		}

        public void Update(Boss boss){
            _connection.Update(boss);
		}

		public void UpdateBWW(BossWorld bw)
		{
			_connection.Update(bw);
		}

		public void UpdateBW(int IdB, int IdW, String KT, String Mis, String Mas)
		{
            _connection.Query<BossWorld>("UPDATE BossWorld SET KilledTime = '"+KT+"', " +
                                            "MinimumSpawnTime = '"+Mis+"'," +
                                            "MaximumSpawnTime = '"+Mas+"'" +
                                            "WHERE IdBoss = '"+IdB+"' AND " +
                                             "IdWorld = '"+IdW+"' ");
		}

        public List<BossWorld> SelectBWBoss(int IdB){
            return _connection.Query<BossWorld>("SELECT * FROM BossWorld where IdBoss = '"+IdB+"'").ToList();
		}
        public List<BossWorld> SelectBW()
		{
            return _connection.Table<BossWorld>().OrderBy(c => c.Id).ToList();
		}

        public List<Boss> Select (){
            return _connection.Table<Boss>().OrderBy(c => c.IdB).ToList();
        }

		public List<World> SelectWorld()
		{
			return _connection.Table<World>().OrderBy(c => c.IdW).ToList();
		}

        public List<Boss> SelectHP(String BossName){
            return _connection.Query<Boss>("select HP from Boss where Name = '"+BossName+"'").ToList();
        }


        public void Dispose()
        {
            _connection.Dispose();
        }




    }
}

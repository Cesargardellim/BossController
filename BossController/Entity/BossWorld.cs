using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;
using Xamarin.Forms;

namespace BossController.Entity
{
    public class BossWorld
    {

        [PrimaryKey]
        public int Id { get; set; }

		public int IdBoss { get; set; }

		public int IdWorld { get; set; }

        public string KilledTime { get; set; }

        public string MinimumSpawnTime { get; set; }

        public string MaximumSpawnTime { get; set; }


    }
}

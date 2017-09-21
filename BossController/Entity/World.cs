using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;

namespace BossController.Entity
{
    public class World
    {
		[PrimaryKey]
		public int IdW { get; set; }

		public string Name { get; set; }

	}
}


using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;
using Xamarin.Forms;

namespace BossController.Entity
{
    public class Boss : ContentPage
    {
        [PrimaryKey]
        public int Id{ get;set;}

        public string Name { get; set; }

		public int HP { get; set; }

    }
}


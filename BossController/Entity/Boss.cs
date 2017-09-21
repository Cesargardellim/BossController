using System;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;

namespace BossController.Entity
{
    public class Boss
    {
        [PrimaryKey]
        public int IdB{ get;set;}

        public string Name { get; set; }

		public int HP { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }

    }
}


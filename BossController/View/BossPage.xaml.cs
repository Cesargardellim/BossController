using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BossController.View
{
    public partial class BossPage : ContentPage
    {

		public string BossName { get; set; }
		public int BoosID { get; set; }
		public double BossHP { get; set; }
		public double BossHPSecs { get; set; }
        public double Percentage { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }

        //Constructor
        public BossPage()
        {

        }



        //Constructor 
        public BossPage(String BossName)
        {
            InitializeComponent();

            this.BindingContext = this;
            this.BossName = BossName;
            this.BossHP = 1200;
            this.BossHPSecs = BossHP + 30;
            this.Percentage = BossHPSecs * 0.1;
            this.Min = BossHPSecs - Percentage;
            this.Max = BossHPSecs + Percentage;  

            using(var data = new Entity.AcessoDados()){
                this.list.ItemsSource = data.Select();
            } 
        }

        public void Salva(object sender, EventArgs e){
            var Boss = new Entity.Boss
            {
                Id = 1,
                Name = "Cave Crawler",
                HP = 1000
            };

			using (var data = new Entity.AcessoDados())
			{
                data.Insert(Boss);
				this.list.ItemsSource = data.Select();
			}

		}


        /*
            
            Select HP from Boss where BossName = this.BossName;
            var MediumSpawnTime = HP+30;
            var percentage = MediumSpawnTime * 0.1;

        public double getMinSpawn(double hp, double MediumSpawnTime){
            //var MinSpawn = (TimeSpan.FromSeconds(hp - MediumSpawnTime).ToString());
            var MinSpawn = hp - MediumSpawnTime;
            return MinSpawn;
        }

        public double getMaxSpawn(double hp, double MediumSpawnTime)
        {
            //var MinSpawn = (TimeSpan.FromSeconds(hp - MediumSpawnTime).ToString());
            var MinSpawn = hp + MediumSpawnTime;
            return MinSpawn;
        }

		*/


        public void GetTime(object sender, EventArgs e){
            var X = GetPressedButton(sender,e);
            var NowTime = DateTime.Now.ToString("hh:mm:ss");
            var MinSpawn = DateTime.Now + TimeSpan.FromSeconds(this.Min);
            var MaxSpawn = DateTime.Now + TimeSpan.FromSeconds(this.Max);
            switch (X)
            {
                case "1":
                    //Killed1.Text = "Killed: "+NowTime;
                    Killed1.Text = NowTime;
                    MinSpawn1.Text = MinSpawn.ToString("hh:mm:ss");
                    MaxSpawn1.Text = MaxSpawn.ToString("hh:mm:ss");
                    break;
                case "2":
                    Killed2.Text = NowTime;
                    MinSpawn2.Text = MinSpawn.ToString("hh:mm:ss");
                    MaxSpawn2.Text = MaxSpawn.ToString("hh:mm:ss");
                    break;
                default:
                    break;
            }
          
        }//GetTime End

        public string GetPressedButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var World = btn.Text;
            var X = World[6].ToString();

            //0123456
            //World 1
            return X;
        }


    }
}

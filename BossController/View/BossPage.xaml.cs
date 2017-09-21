using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BossController.View
{
    public partial class BossPage : ContentPage
    {
        public int IdB{ get;set;}
		public string BossName { get; set; }
		public int BoosID { get; set; }
		public double BossHP { get; set; }
		public double BossHPSecs { get; set; }
        public double Percentage { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public List<Entity.Boss> ListTemp;
        public List<Entity.World> ListTempW = new List<Entity.World>();

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
           // this.ListTemp.Add(App.AcessoDados.SelectHP(BossName));
            this.BossHPSecs = BossHP + 30;
            this.Percentage = BossHPSecs * 0.1;
            this.Min = BossHPSecs - Percentage;
			this.Max = BossHPSecs + Percentage;
			//this.list.ItemsSource = App.AcessoDados.Select();



        }

        //Constructor
		public BossPage(Entity.Boss Boss)
		{
			InitializeComponent();

			this.BindingContext = this;
            this.IdB = Boss.IdB;
            this.BossName = Boss.Name;
            this.BossHP = Boss.HP;
			this.BossHPSecs = BossHP + 30;
			this.Percentage = BossHPSecs * 0.1;
			this.Min = BossHPSecs - Percentage;
			this.Max = BossHPSecs + Percentage;
			//this.list.ItemsSource = App.AcessoDados.Select();
            LoadWorld();
            PopulateBossWorld();
            SetLabelTime();

		}

        public void Salva(object sender, EventArgs e){
            var boss = new Entity.Boss
            {
                IdB = 1,
                Name = "Cave Crawler",
                HP = 1000
            };

			//App.AcessoDados.Insert(boss);
			//this.list.ItemsSource = App.AcessoDados.SelectHP(BossName);
			//this.list.ItemsSource = App.AcessoDados.Select();
            //this.list.ItemsSource = ListTemp;
            //this.Label.Text = BossHP.ToString();

		}



        public void GetTime(object sender, EventArgs e){
            var NWorld = GetPressedButton(sender,e);
            var NWorldInt = int.Parse(NWorld);
            var NowTime = DateTime.Now.ToString("HH:mm:ss");
            var MinSpawn = DateTime.Now + TimeSpan.FromSeconds(this.Min);
			var MaxSpawn = DateTime.Now + TimeSpan.FromSeconds(this.Max);
			//this.Label.Text = BossHP.ToString();
            switch (NWorld)
            {
                case "1":
                    //Killed1.Text = "Killed: "+NowTime;
                    Killed1.Text = NowTime;
                    MinSpawn1.Text = MinSpawn.ToString("HH:mm:ss");
                    MaxSpawn1.Text = MaxSpawn.ToString("HH:mm:ss");
					break;
				case "2":
					Killed2.Text = NowTime;
					MinSpawn2.Text = MinSpawn.ToString("HH:mm:ss");
					MaxSpawn2.Text = MaxSpawn.ToString("HH:mm:ss");
					break;
				case "3":
					Killed3.Text = NowTime;
					MinSpawn3.Text = MinSpawn.ToString("HH:mm:ss");
					MaxSpawn3.Text = MaxSpawn.ToString("HH:mm:ss");
					break;
				case "4":
					Killed4.Text = NowTime;
					MinSpawn4.Text = MinSpawn.ToString("HH:mm:ss");
					MaxSpawn4.Text = MaxSpawn.ToString("HH:mm:ss");
					break;
				case "5":
					Killed5.Text = NowTime;
					MinSpawn5.Text = MinSpawn.ToString("HH:mm:ss");
					MaxSpawn5.Text = MaxSpawn.ToString("HH:mm:ss");
					break;
				case "6":
					Killed6.Text = NowTime;
					MinSpawn6.Text = MinSpawn.ToString("HH:mm:ss");
					MaxSpawn6.Text = MaxSpawn.ToString("HH:mm:ss");
					break;
				case "7":
					Killed7.Text = NowTime;
					MinSpawn7.Text = MinSpawn.ToString("HH:mm:ss");
					MaxSpawn7.Text = MaxSpawn.ToString("HH:mm:ss");
					break;
				case "8":
					Killed8.Text = NowTime;
					MinSpawn8.Text = MinSpawn.ToString("HH:mm:ss");
					MaxSpawn8.Text = MaxSpawn.ToString("HH:mm:ss");
					break;
                default:
                    break;
            }

            App.AcessoDados.UpdateBW(this.IdB,NWorldInt,NowTime,MinSpawn.ToString("HH:mm:ss"),MaxSpawn.ToString("HH:mm:ss"));
          
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



        /*
         Trying to create the Worlds UI dinamically 
         */
        public void CreateWorldUI(){
            foreach(var item in App.AcessoDados.SelectWorld()){
                var StackBtn = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    Spacing = 15
                };
                var btn = new Button
                {
                    Text = item.Name
                };
                btn.Clicked += (sender, e) => GetTime(sender,e);
                StackBtn.Children.Add(btn);

                var StackLabel = new StackLayout
                {
					Orientation = StackOrientation.Horizontal,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					Spacing = 40
                };

                var LabelKT = new Label
                {
                    Text = ""
                };

            }
        }

        private void LoadWorld(){
			var W1 = new Entity.World
			{
				IdW = 1,
				Name = "World 1"
			};

			var W2 = new Entity.World
			{
				IdW = 2,
				Name = "World 2"
			};

			var W3 = new Entity.World
			{
				IdW = 3,
				Name = "World 3"
			};

			var W4 = new Entity.World
			{
				IdW = 4,
				Name = "World 4"
			};

			var W5 = new Entity.World
			{
				IdW = 5,
				Name = "World 5"
			};

			var W6 = new Entity.World
			{
				IdW = 6,
				Name = "World 6"
			};

			var W7 = new Entity.World
			{
				IdW = 7,
				Name = "World 7"
			};

			var W8 = new Entity.World
			{
				IdW = 8,
				Name = "World 8"
			};

			ListTempW.Add(W1);
			ListTempW.Add(W2);
			ListTempW.Add(W3);
			ListTempW.Add(W4);
			ListTempW.Add(W5);
			ListTempW.Add(W6);
			ListTempW.Add(W7);
			ListTempW.Add(W8);
            if(App.AcessoDados.SelectWorld().Count <= 0){
                foreach(var item in ListTempW){
                    App.AcessoDados.InsertWorld(item);
                }
            }

		} // LoadWorld END

        public void PopulateBossWorld(){
            int count = 1;
            if(App.AcessoDados.SelectBW().Count <= 0){
                    
                foreach(var boss in App.AcessoDados.Select()){
                    foreach(var world in App.AcessoDados.SelectWorld()){
                        var BW = new Entity.BossWorld
                        {
                            Id = count,
                            IdBoss = boss.IdB,
                            IdWorld = world.IdW,
                            KilledTime = "00:00:00",
                            MinimumSpawnTime = "00:00:00",
                            MaximumSpawnTime = "00:00:00"
                        };
                        App.AcessoDados.InsertBossWorld(BW);
                        count++;
                        //this.pls.Children.Add(new Label { Text = BW.Id.ToString()});
                    } // foreach world
                } // foreach boss
			}// if
        } // PopulateBossWorld

        public void SetLabelTime(){
            foreach(var item in App.AcessoDados.SelectBWBoss(this.IdB)){
                switch (item.IdWorld)
                {
                    case 1:
                        Killed1.Text = item.KilledTime;
                        MinSpawn1.Text = item.MinimumSpawnTime;
                        MaxSpawn1.Text = item.MaximumSpawnTime;
						break;
					case 2:
						Killed2.Text = item.KilledTime;
						MinSpawn2.Text = item.MinimumSpawnTime;
						MaxSpawn2.Text = item.MaximumSpawnTime;
						break;
					case 3:
						Killed3.Text = item.KilledTime;
						MinSpawn3.Text = item.MinimumSpawnTime;
						MaxSpawn3.Text = item.MaximumSpawnTime;
						break;
					case 4:
						Killed4.Text = item.KilledTime;
						MinSpawn4.Text = item.MinimumSpawnTime;
						MaxSpawn4.Text = item.MaximumSpawnTime;
						break;
					case 5:
						Killed5.Text = item.KilledTime;
						MinSpawn5.Text = item.MinimumSpawnTime;
						MaxSpawn5.Text = item.MaximumSpawnTime;
						break;
					case 6:
						Killed6.Text = item.KilledTime;
						MinSpawn6.Text = item.MinimumSpawnTime;
						MaxSpawn6.Text = item.MaximumSpawnTime;
						break;
					case 7:
						Killed7.Text = item.KilledTime;
						MinSpawn7.Text = item.MinimumSpawnTime;
						MaxSpawn7.Text = item.MaximumSpawnTime;
						break;
					case 8:
						Killed8.Text = item.KilledTime;
						MinSpawn8.Text = item.MinimumSpawnTime;
						MaxSpawn8.Text = item.MaximumSpawnTime;
						break;
                    default:
                        break;
                }
            }
        }// SetLabelTime END


    }
}

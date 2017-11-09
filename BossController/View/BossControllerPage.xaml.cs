using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace BossController.View
{
    public partial class BossControllerPage : ContentPage
    {

        private List<Entity.Boss> ListBoss = new List<Entity.Boss>();
        private List<Entity.Boss> ListBossDB = new List<Entity.Boss>();

        public BossControllerPage()
        {
            InitializeComponent();

            LoadBoss();

            //CreateButtons();

            CreateButtonsDB();
            //PopulateLW();
        }

        public void PopulateLW(){
             
           // this.ListWBoss.ItemsSource = App.AcessoDados.Select();

        }


        public void CreateButtonsDB(){
            foreach(var x in App.AcessoDados.Select()){
                ListBossDB.Add(x);
				var btn = new Button
				{
                    Text = x.Name
				};
				btn.Clicked += (sender, e) => GoToBossObj(sender, e);
                this.StackButtons.Children.Add(btn);

            }
        }
        //CreateButtonsDB


        public void CreateButtons(){

            foreach(var item in ListBoss){
                var btn = new Button
                {
                    Text = item.Name
                };
                btn.Clicked += (sender, e) => GoToBossObj(sender,e);


                this.StackButtons.Children.Add(btn);
                
            }//foreach

			

        }//CreateButtons




        private void GoToBoss(object sender,EventArgs e)
		{
            //Button btn = (Button)sender;
            //var BossName = btn.Text;
            
            ListView lw = (ListView)sender;
            var BossNameLW = lw.ToString();
            this.Title = BossNameLW;

            //Navigation.PushAsync(new BossPage(BossName));

		}

		private void GoToBossObj(object sender, EventArgs e)
		{
            var btn = (Button)sender;
			var btnText = btn.Text;
			//ListView lw = (ListView)sender;
            //var BossNameLW = lw.ToString();
            switch (btnText)
            {
				case "Cave Crawler":
					Navigation.PushAsync(new BossPage(ListBossDB[0]));
					break;
				case "Giant Cyclops":
					Navigation.PushAsync(new BossPage(ListBossDB[1]));
					break;
				case "Orc Overlord":
					Navigation.PushAsync(new BossPage(ListBossDB[2]));
					break;
				case "Orc Overlord Dungeon":
					Navigation.PushAsync(new BossPage(ListBossDB[3]));
					break;
				case "Demon Overlord":
					Navigation.PushAsync(new BossPage(ListBossDB[4]));
					break;
				case "Venus Flytrap":
					Navigation.PushAsync(new BossPage(ListBossDB[5]));
					break;
				case "The Reaper":
					Navigation.PushAsync(new BossPage(ListBossDB[6]));
					break;
				case "Diablo":
					Navigation.PushAsync(new BossPage(ListBossDB[7]));
					break;
				case "Ancient Hydra":
					Navigation.PushAsync(new BossPage(ListBossDB[8]));
					break;
				case "Ancient Hydra New":
					Navigation.PushAsync(new BossPage(ListBossDB[9]));
					break;
				case "Pharaoh":
					Navigation.PushAsync(new BossPage(ListBossDB[10]));
					break;
				case "Demon Portal":
					Navigation.PushAsync(new BossPage(ListBossDB[11]));
					break;
				case "Chaotic Dragon":
					Navigation.PushAsync(new BossPage(ListBossDB[12]));
					break;
				case "Cannibal Plant":
					Navigation.PushAsync(new BossPage(ListBossDB[13]));
					break;
				case "Raguel The Archangel":
					Navigation.PushAsync(new BossPage(ListBossDB[14]));
					break;
				case "Nephilim Warrior":
					Navigation.PushAsync(new BossPage(ListBossDB[15]));
					break;
				case "World Tree":
					Navigation.PushAsync(new BossPage(ListBossDB[16]));
					break;
				case "Acid Dragon Lord":
					Navigation.PushAsync(new BossPage(ListBossDB[17]));
					break;
				case "Blood Eagle":
					Navigation.PushAsync(new BossPage(ListBossDB[18]));
					break;
				case "Titan Minotaur":
					Navigation.PushAsync(new BossPage(ListBossDB[19]));
					break;
				default:
                    break;
            }



			//Navigation.PushAsync(new BossPage(Boss));

		}


        private void LoadBoss(){

			var bossCC = new Entity.Boss
			{
				IdB = 1,
				Name = "Cave Crawler",
				HP = 1000
			};

			var bossGC = new Entity.Boss
			{
				IdB = 2,
				Name = "Giant Cyclops",
				HP = 1100
			};

			var bossOOL = new Entity.Boss
			{
				IdB = 3,
				Name = "Orc Overlord",
				HP = 1200
			};

			var bossOOLD = new Entity.Boss
			{
				IdB = 4,
				Name = "Orc Overlord Dungeon",
				HP = 1200
			};

			var bossDOL = new Entity.Boss
			{
				IdB = 5,
				Name = "Demon Overlord",
				HP = 1200
			};

			var bossVF = new Entity.Boss
			{
				IdB = 6,
				Name = "Venus Flytrap",
				HP = 1400
			};

			var bossTR = new Entity.Boss
			{
				IdB = 7,
				Name = "The Reaper",
				HP = 1600
			};

			var bossD = new Entity.Boss
			{
				IdB = 8,
				Name = "Diablo",
				HP = 2400
			};

			var bossAH = new Entity.Boss
			{
				IdB = 9,
				Name = "Ancient Hydra",
				HP = 3250
			};

			var bossAHNew = new Entity.Boss
			{
				IdB = 10,
				Name = "Ancient Hydra New",
				HP = 3250
			};

			var bossP = new Entity.Boss
			{
				IdB = 11,
				Name = "Pharaoh",
				HP = 4240
			};

			var bossDP = new Entity.Boss
			{
				IdB = 12,
				Name = "Demon Portal",
				HP = 5000
			};

			var bossCD = new Entity.Boss
			{
				IdB = 13,
				Name = "Chaotic Dragon",
				HP = 7350
			};

			var bossCP = new Entity.Boss
			{
				IdB = 14,
				Name = "Cannibal Plant",
				HP = 7350
			};

			var bossRTA = new Entity.Boss
			{
				IdB = 15,
				Name = "Raguel The Archangel",
				HP = 7350
			};

			var bossNW = new Entity.Boss
			{
				IdB = 16,
				Name = "Nephilim Warrior",
				HP = 10920
			};

			var bossWT = new Entity.Boss
			{
				IdB = 17,
				Name = "World Tree",
				HP = 14000
			};

			var bossADL = new Entity.Boss
			{
				IdB = 18,
				Name = "Acid Dragon Lord",
				HP = 14900
			};

			var bossBE = new Entity.Boss
			{
				IdB = 19,
				Name = "Blood Eagle",
				HP = 38540
			};

			var bossTM = new Entity.Boss
			{
				IdB = 20,
				Name = "Titan Minotaur",
				HP = 38430
			};

			ListBoss.Add(bossCC);
			ListBoss.Add(bossGC);
			ListBoss.Add(bossOOL);
			ListBoss.Add(bossOOLD);
            ListBoss.Add(bossDOL);
            ListBoss.Add(bossVF);
            ListBoss.Add(bossTR);
			ListBoss.Add(bossD);
			ListBoss.Add(bossAH);
			ListBoss.Add(bossAHNew);
            ListBoss.Add(bossP);
            ListBoss.Add(bossDP);
            ListBoss.Add(bossCD);
            ListBoss.Add(bossCP);
            ListBoss.Add(bossRTA);
            ListBoss.Add(bossNW);
            ListBoss.Add(bossWT);
            ListBoss.Add(bossADL);
            ListBoss.Add(bossBE);
            ListBoss.Add(bossTM);

			if(App.AcessoDados.Select().Count <= 0){
                foreach(var item in ListBoss){
                    App.AcessoDados.Insert(item);
                }
            }



        }

    }
}

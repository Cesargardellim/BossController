using Xamarin.Forms;

namespace BossController
{
    public partial class App : Application
    {

        static Entity.AcessoDados acessoDados;

        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new View.BossControllerPage());
            //MainPage = new NavigationPage(new View.BossPage("Cave Crawler"));
        }

        protected override void OnStart()
        {
			// Handle when your app starts
			
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        public static Entity.AcessoDados AcessoDados{
            get{
                if(acessoDados == null){
                    acessoDados = new Entity.AcessoDados();
                }
                return acessoDados;
            }
        }



    }
}

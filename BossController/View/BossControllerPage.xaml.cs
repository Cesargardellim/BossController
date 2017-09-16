using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace BossController.View
{
    public partial class BossControllerPage : ContentPage
    {
        public BossControllerPage()
        {
            InitializeComponent();
        }


        private void GoToBoss(object sender,EventArgs e)
		{
            Button btn = (Button)sender;
            var BossName = btn.Text;


            Navigation.PushAsync(new BossPage(BossName));

		}

    }
}

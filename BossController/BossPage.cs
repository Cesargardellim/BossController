using System;

using Xamarin.Forms;

namespace BossController
{
    public class BossPage : ContentPage
    {
        public BossPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


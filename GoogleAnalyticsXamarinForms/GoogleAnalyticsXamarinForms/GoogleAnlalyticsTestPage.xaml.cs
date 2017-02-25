using Xamarin.Forms;
using System;
namespace GoogleAnalyticsXamarinForms
{
    public partial class GoogleAnlalyticsTestPage : ContentView
    {
        private int counter = 0;
        public GoogleAnlalyticsTestPage()
        {
                //will show up page name depending on what platform 
                //Android 
                if (Device.OS == TargetPlatform.Android)
                {
                    //Track Page
                    GASCall.Track_App_Page("Android HomePage");
                }
                //or iOS
                else
                {
                    //Track Page
                    GASCall.Track_App_Page("iOS HomePage");
                }

                InitializeComponent();
        }
    }
}


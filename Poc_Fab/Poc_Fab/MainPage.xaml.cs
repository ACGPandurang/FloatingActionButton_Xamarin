using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Poc_Fab
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

            FAB_Main.Source = ImageSource.FromResource("Poc_Fab.Images.fab_main.png", typeof(MainPage).GetTypeInfo().Assembly);
            FAB_Menu_Preferences.Source = ImageSource.FromResource("Poc_Fab.Images.preferences.jpg", typeof(MainPage).GetTypeInfo().Assembly);
            FAB_Menu_History.Source = ImageSource.FromResource("Poc_Fab.Images.history.png", typeof(MainPage).GetTypeInfo().Assembly);
            FAB_Menu_Dashboard.Source = ImageSource.FromResource("Poc_Fab.Images.dashboard.png", typeof(MainPage).GetTypeInfo().Assembly);
            FAB_Menu_Live.Source = ImageSource.FromResource("Poc_Fab.Images.live_location.png", typeof(MainPage).GetTypeInfo().Assembly);
        }
    }
}

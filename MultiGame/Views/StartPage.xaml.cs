using MultiGame.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml.Controls;

namespace MultiGame
{
    public partial class StartPage : Page
    {
        private StartPageViewModel ViewModel => new StartPageViewModel();

        public StartPage()
        {
            this.InitializeComponent();
            DataContext = ViewModel;
        }
    }
}

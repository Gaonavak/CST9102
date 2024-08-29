using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CST9102
{
    public partial class App : Application
    {
        public App()
        {
            this.Startup += ApplicationStart;
        }

        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            var mainView = new MainWindow();
            mainView.Show();
        }
    }
}

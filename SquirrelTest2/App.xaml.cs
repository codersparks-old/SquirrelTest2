using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Squirrel;

namespace SquirrelTest2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs args)
        {
            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/codersparks/SquirrelTest2"))
            {
                await mgr.Result.UpdateApp();
            }
        }
    }
}

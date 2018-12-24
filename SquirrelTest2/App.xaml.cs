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
            using (var mgr = new UpdateManager(@"C:\Users\Coder Sparks\source\repos\SquirrelTest2\Releases"))
            {
                await mgr.UpdateApp();
            }
        }
    }
}

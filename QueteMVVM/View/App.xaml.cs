using QueteMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace QueteMVVM
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            QueteMVVM.MainWindow window = new MainWindow();
            ShopViewModel VM = new ShopViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}

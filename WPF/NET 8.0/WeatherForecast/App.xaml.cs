using System.Configuration;
using System.Data;
using System.Windows;
using AppMeteo.Languages;

namespace AppMeteo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Language.ChangeLenguage(new Properties.Settings().lang);
        }
    }

}

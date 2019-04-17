using System.Windows;
using TaskManager.Tools;

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App 
    {
        protected override void OnStartup (StartupEventArgs e)
        {
            base.OnStartup (e);

            MainWindow contentWindow = new MainWindow();

            NavigationModel navigationModel = new NavigationModel (contentWindow);
            NavigationManager.Instance.Initialize (navigationModel);
            contentWindow.Show ();
            navigationModel.Navigate (ModesEnum.Main);
        }
    }
    }

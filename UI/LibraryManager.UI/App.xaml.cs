using System.Windows;

namespace LibraryManager.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Bootstrap bootstrap = new Bootstrap();
            bootstrap.SetupContainerAndLaunch();
        }
    }

}

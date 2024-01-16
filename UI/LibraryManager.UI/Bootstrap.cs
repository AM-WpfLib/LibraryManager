using LibraryManager.UI.ViewModels;
using SimpleInjector;

namespace LibraryManager.UI
{
    public class Bootstrap
    {
        private Container _container;

        /// <summary>
        /// SetupContainer is used to create the container with the correct implementation and launch the application.
        /// </summary>
        public void SetupContainerAndLaunch()
        {
            _container = new Container();

            // Register CrossCutting

            // Register DataAccess

            // Register Business

            // Register UI
            _container.RegisterSingleton<IStudentViewModel, StudentViewModel>();
            _container.RegisterSingleton<IMainWindowViewModel, MainWindowViewModel>();
            _container.RegisterSingleton<MainWindow>();

            // Start mainwindow
            MainWindow mainWindow = _container.GetInstance<MainWindow>();
            mainWindow.Show();
        }
    }
}

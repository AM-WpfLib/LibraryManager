using LibraryManager.Core.Common;

namespace LibraryManager.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        private IStudentViewModel _studentViewModel;
        public IStudentViewModel StudentViewModel
        {
            get { return _studentViewModel; }
            set { SetField(ref _studentViewModel, value); }
        }

        public MainWindowViewModel(IStudentViewModel studentViewModel)
        {
            StudentViewModel = studentViewModel ?? throw new ArgumentNullException(nameof(studentViewModel));
        }
    }
}

using LibraryManager.Core.Common;

namespace LibraryManager.UI.ViewModels
{
    public class StudentViewModel : ViewModelBase, IStudentViewModel
    {
        #region Properties

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (SetField(ref _firstName, value))
                {
                    AddStudentCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (SetField(ref _lastName, value))
                {
                    AddStudentCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private string _street;
        public string Street
        {
            get { return _street; }
            set
            {
                if (SetField(ref _street, value))
                {
                    AddStudentCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private string _houseNumber;
        public string HouseNumber
        {
            get { return _houseNumber; }
            set
            {
                if (SetField(ref _houseNumber, value))
                {
                    AddStudentCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private string _postbox;
        public string Postbox
        {
            get { return _postbox; }
            set
            {
                if (SetField(ref _postbox, value))
                {
                    AddStudentCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set
            {
                if (SetField(ref _city, value))
                {
                    AddStudentCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (SetField(ref _email, value))
                {
                    AddStudentCommand.RaiseCanExecuteChanged();
                }
            }
        }

        //Commands
        public DelegateCommand AddStudentCommand { get; }

        #endregion

        public StudentViewModel()
        {
            //Commands
            AddStudentCommand = new DelegateCommand(AddStudent, CanAddStudent);
        }

        #region Private methods

        private void AddStudent(object obj)
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Street = string.Empty;
            HouseNumber = string.Empty;
            Postbox = string.Empty;
            City = string.Empty;
            Email = string.Empty;
        }

        private bool CanAddStudent(object obj)
        {
            return !(string.IsNullOrWhiteSpace(FirstName)
                  || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Street)
                  || string.IsNullOrWhiteSpace(HouseNumber) || string.IsNullOrWhiteSpace(Postbox)
                  || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(Email));
        }

        #endregion
    }
}

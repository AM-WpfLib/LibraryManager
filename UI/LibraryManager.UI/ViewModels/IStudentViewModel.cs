namespace LibraryManager.UI.ViewModels
{
    public interface IStudentViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string Postbox { get; set; }

        public string City { get; set; }

        public string Email { get; set; }
    }
}

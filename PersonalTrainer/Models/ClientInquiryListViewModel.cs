namespace PersonalTrainer.Models
{
    /// <summary>
    /// View model to be used to the display list of Inquired trainers in the client view
    /// </summary>
    public class ClientInquiryListViewModel
    {
        public ClientInquiryListViewModel(List<Trainer> trainers, List<MyCustomUser> allUsers, List<Inquiry> inquiries,
            int lastPage, int currentPage)
        {
            Trainers = trainers;
            AllUsers = allUsers;
            Inquiries = inquiries;
            LastPage=lastPage;
            CurrentPage=currentPage;
        }
        /// <summary>
        /// List of Trainers
        /// </summary>
        public List<Trainer> Trainers { get; set; }
        /// <summary>
        /// List of all users
        /// </summary>
        public List<MyCustomUser> AllUsers { get; set; }
        /// <summary>
        /// list of inquiries created by logged in client
        /// </summary>
        public List<Inquiry> Inquiries { get; set; }
        /// <summary>
        /// Last Page of the list
        /// </summary>
        public int LastPage { get; set; }
        /// <summary>
        /// current page of the list
        /// </summary>
        public int CurrentPage { get; set; }
    }
}

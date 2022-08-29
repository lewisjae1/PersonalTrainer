namespace PersonalTrainer.Models
{
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

        public List<Trainer> Trainers { get; set; }

        public List<MyCustomUser> AllUsers { get; set; }

        public List<Inquiry> Inquiries { get; set; }

        public int LastPage { get; set; }

        public int CurrentPage { get; set; }
    }
}

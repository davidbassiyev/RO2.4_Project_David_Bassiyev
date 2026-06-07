namespace SchoolAppL17
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("StudentsPage", typeof(StudentsPage));
            Routing.RegisterRoute(nameof(StudentDetailPage), typeof(StudentDetailPage));
        }
    }
}

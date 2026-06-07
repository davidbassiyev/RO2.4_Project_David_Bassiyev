namespace SchoolAppL17;

[QueryProperty(nameof(Name), "name")]
public partial class StudentDetailPage : ContentPage
{
    public string Name { get; set; } = "";

    public StudentDetailPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
}

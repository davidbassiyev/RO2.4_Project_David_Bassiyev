using SchoolAppL17.ViewModels;

namespace SchoolAppL17;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new Person();
    }

    private async void OnOpenStudentsClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("StudentsPage");
    }
}

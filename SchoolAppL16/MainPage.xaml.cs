using SchoolAppL15.ViewModels;

namespace SchoolAppL15;

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

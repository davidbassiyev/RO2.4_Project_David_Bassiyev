namespace SchoolApp_David;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();

        StudentsList.ItemsSource = new[]
        {
            "David Basiev",
            "Kopytov Ilia",
            "Mishelov Baitemir",
            "Kuanush Anuar",
            "Dias Zholgali"
        };
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not string name) return;

        await Shell.Current.GoToAsync(
            $"{nameof(StudentDetailPage)}?name={Uri.EscapeDataString(name)}");

        StudentsList.SelectedItem = null;
    }
}

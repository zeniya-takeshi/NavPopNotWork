namespace NavPopNotWork;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void OnPushAsyncClicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new SubPage());
    }
}



namespace NavPopNotWork;

public partial class SubPage : ContentPage
{
    public SubPage()
    {
        this.InitializeComponent();
    }

    private void OnPopAsyncClicked(object sender, EventArgs e)
    {
        this.Navigation.PopAsync();
    }
}

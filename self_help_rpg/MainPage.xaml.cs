namespace self_help_rpg
{
    public partial class MainPage : ContentPage
    {

        public string name = "";


        public MainPage()
        {
            InitializeComponent();
        }

        private async void ContinueButton_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerName = NameEntry.Text;

            // Navigate to the HomePage
            await Navigation.PushAsync(new HomePage());

        }
    }
}

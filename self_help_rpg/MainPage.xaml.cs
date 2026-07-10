namespace self_help_rpg
{
    public partial class MainPage : ContentPage
    {

        public string name = "";


        public MainPage()
        {
            InitializeComponent();
        }

        private void ContinueButton_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerName = NameEntry.Text;

            // Navigate to the HomePage
            Application.Current.Windows[0].Page = new HomePage();

        }
    }
}

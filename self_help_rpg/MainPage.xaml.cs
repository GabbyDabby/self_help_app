namespace self_help_rpg
{
    public partial class MainPage : ContentPage
    {

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

        private void Pale_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "White";
            GirlButton.Source = "girlbase1";

        }

        private void Beige_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Beige";
            GirlButton.Source = "girlbase2";

        }

        private void Pink_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Pink";
            GirlButton.Source = "girlbase3";
        }

        private void Tan_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Tan";
            GirlButton.Source = "girlbase4";
        }

        private void Coffee_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Coffee";
            GirlButton.Source = "girlbase5";
        }

        private void Espresso_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Espresso";
            GirlButton.Source = "girlbase6";
        }

        private void Dark_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Dark";
            GirlButton.Source = "girlbase7";
        }

        private void Black_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Black";
            GirlButton.Source = "girlbase8";
        }
    }
}

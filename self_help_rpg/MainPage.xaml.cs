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
            BoyButton.Source = "boybase1";

        }

        private void Beige_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Beige";
            GirlButton.Source = "girlbase2";
            BoyButton.Source = "boybase2";

        }

        private void Pink_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Pink";
            GirlButton.Source = "girlbase3";
            BoyButton.Source = "boybase3";
        }

        private void Tan_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Tan";
            GirlButton.Source = "girlbase4";
            BoyButton.Source = "boybase4";
        }

        private void Coffee_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Coffee";
            GirlButton.Source = "girlbase5";
            BoyButton.Source = "boybase5";
        }

        private void Espresso_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Espresso";
            GirlButton.Source = "girlbase6";
            BoyButton.Source = "boybase6";
        }

        private void Dark_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Dark";
            GirlButton.Source = "girlbase7";
            BoyButton.Source = "boybase7";
        }

        private void Black_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerSkin = "Black";
            GirlButton.Source = "girlbase8";
            BoyButton.Source = "boybase8";
        }

        private void UpdateFace()
        {
            if (GameData.PlayerFace == "girlface3")
            {
                girlface.Source = "girlface3.png";
                return;
            }

            girlface.Source = $"{GameData.PlayerFace}{GameData.PlayerEyecolor}.png";
        }


        private void Blue_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerEyecolor = "b";
            UpdateFace();
        }

        private void Grey_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerEyecolor = "gr";
            UpdateFace();
        }

        private void Brown_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerEyecolor = "br";
            UpdateFace();
        }

        private void Green_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerEyecolor = "g";
            UpdateFace();
        }

        private void PinkEye_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerEyecolor = "p";
            UpdateFace();
        }

        private void Purple_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerEyecolor = "pr";
            UpdateFace();
        }

        private void gf1button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerFace = "girlface1";
            UpdateFace();
        }
        private void gf2button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerFace = "girlface2";
            UpdateFace();
        }

        private void gf3button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerFace = "girlface3";
            UpdateFace();
        }

        private void gf4button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerFace = "girlface4";
            UpdateFace();
        }

        private void gf5button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerFace = "girlface5";
            UpdateFace();
        }
    }
}

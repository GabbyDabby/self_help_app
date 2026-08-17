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
            Application.Current.Windows[0].Page = new MainPage2();

        }

        private void ResetSkinBorders()
        {
            PaleBorder.Stroke = Color.FromArgb("#fce7c4");
            BeigeBorder.Stroke = Color.FromArgb("#fce7c4");
            PinkBorder.Stroke = Color.FromArgb("#fce7c4");
            TanBorder.Stroke = Color.FromArgb("#fce7c4");
            CoffeeBorder.Stroke = Color.FromArgb("#fce7c4");
            EspressoBorder.Stroke = Color.FromArgb("#fce7c4");
            DarkBorder.Stroke = Color.FromArgb("#fce7c4");
            BlackBorder.Stroke = Color.FromArgb("#fce7c4");

            PaleBorder.StrokeThickness = 1;
            BeigeBorder.StrokeThickness = 1;
            PinkBorder.StrokeThickness = 1;
            TanBorder.StrokeThickness = 1;
            CoffeeBorder.StrokeThickness = 1;
            EspressoBorder.StrokeThickness = 1;
            DarkBorder.StrokeThickness = 1;
            BlackBorder.StrokeThickness = 1;
        }

        private void ResetBodyBorders()
        {
            BoySelectBorder.Stroke = Color.FromArgb("#fce7c4");
            GirlSelectBorder.Stroke = Color.FromArgb("#fce7c4");

            BoySelectBorder.StrokeThickness = 1;
            GirlSelectBorder.StrokeThickness = 1;
        }

        private void SetBody(string gender)
        {
            ResetBodyBorders();

            if (gender == "Male")
            {
                BoySelectBorder.Stroke = Color.FromArgb("#FFD700");
                BoySelectBorder.StrokeThickness = 2;
            }
            else if (gender == "Female")
            {
                GirlSelectBorder.Stroke = Color.FromArgb("#FFD700");
                GirlSelectBorder.StrokeThickness = 2;
            }
        }

        private void SetSkin(int skin)
        {
            GameData.PlayerSkin = skin;

            girlbody.Source = $"girlbase{skin}";
            boybody.Source = $"boybase{skin}";

            ResetSkinBorders();

            switch (skin)
            {
                case 1:
                    PaleBorder.Stroke = Color.FromArgb("#FFD700");
                    PaleBorder.StrokeThickness = 2;
                    break;

                case 2:
                    BeigeBorder.Stroke = Color.FromArgb("#FFD700");
                    BeigeBorder.StrokeThickness = 2;
                    break;

                case 3:
                    PinkBorder.Stroke = Color.FromArgb("#FFD700");
                    PinkBorder.StrokeThickness = 2;
                    break;

                case 4:
                    TanBorder.Stroke = Color.FromArgb("#FFD700");
                    TanBorder.StrokeThickness = 2;
                    break;

                case 5:
                    CoffeeBorder.Stroke = Color.FromArgb("#FFD700");
                    CoffeeBorder.StrokeThickness = 2;
                    break;

                case 6:
                    EspressoBorder.Stroke = Color.FromArgb("#FFD700");
                    EspressoBorder.StrokeThickness = 2;
                    break;

                case 7:
                    DarkBorder.Stroke = Color.FromArgb("#FFD700");
                    DarkBorder.StrokeThickness = 2;
                    break;

                case 8:
                    BlackBorder.Stroke = Color.FromArgb("#FFD700");
                    BlackBorder.StrokeThickness = 2;
                    break;
            }
        }
        private void Pale_Clicked(object sender, EventArgs e)
        {
            SetSkin(1);
        }

        private void Beige_Clicked(object sender, EventArgs e)
        {
            SetSkin(2);
        }

        private void Pink_Clicked(object sender, EventArgs e)
        {
            SetSkin(3);
        }

        private void Tan_Clicked(object sender, EventArgs e)
        {
            SetSkin(4);
        }

        private void Coffee_Clicked(object sender, EventArgs e)
        {
            SetSkin(5);
        }

        private void Espresso_Clicked(object sender, EventArgs e)
        {
            SetSkin(6);
        }

        private void Dark_Clicked(object sender, EventArgs e)
        {
            SetSkin(7);
        }

        private void Black_Clicked(object sender, EventArgs e)
        {
            SetSkin(8);
        }

        private void UpdateFace()
        {
            if (GameData.PlayerGirlFace == "girlface3")
            {
                girlface.Source = "girlface3";
            }
            else
            {
                girlface.Source = $"{GameData.PlayerGirlFace}{GameData.PlayerEyecolor}";
            }

            if (GameData.PlayerBoyFace == "boyface1")
            {
                boyface.Source = "boyface1";
            }
            else
            {
                boyface.Source = $"{GameData.PlayerBoyFace}{GameData.PlayerEyecolor}";
            }
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
            GameData.PlayerGirlFace = "girlface1";
            UpdateFace();
        }
        private void gf2button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerGirlFace = "girlface2";
            UpdateFace();
        }

        private void gf3button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerGirlFace = "girlface3";
            UpdateFace();
        }

        private void gf4button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerGirlFace = "girlface4";
            UpdateFace();
        }

        private void gf5button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerGirlFace = "girlface5";
            UpdateFace();
        }

        private void bf1button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerBoyFace = "boyface1";
            UpdateFace();
        }

        private void bf2button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerBoyFace = "boyface2";
            UpdateFace();
        }

        private void bf3button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerBoyFace = "boyface3";
            UpdateFace();
        }

        private void bf4button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerBoyFace = "boyface4";
            UpdateFace();
        }

        private void bf5button_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerBoyFace = "boyface5";
            UpdateFace();
        }

        private void BoyButton_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerGender = "Male";
            GameData.PlayerBottom = "boxers.png";
            GameData.PlayerTop = "shirtless.png";

            SetBody("Male");

        }

        private void GirlButton_Clicked(object sender, EventArgs e)
        {
            GameData.PlayerGender = "Female";
            GameData.PlayerBottom = "underwear.png";
            GameData.PlayerTop = "bra.png";

            SetBody("Female");

        }

        
    }
}

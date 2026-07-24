namespace self_help_rpg
{
    public partial class HomePage : ContentPage
    {


        public HomePage()
        {
            InitializeComponent();
            NameInit();
            UpdateCharacter();
            UpdateClothes();

        }
        public void NameInit()
        {
            NameLabel.Text = GameData.PlayerName;
        }
        private void UpdateCharacter()
        {
            SkinUpdate();
            FaceUpdate();
        }
        private void SkinUpdate()
        {
            string prefix;

            if (GameData.PlayerGender == "Female")
            {
                prefix = "girlbase";
            }
            else
            {
                prefix = "boybase";
            }

            CharacterBase.Source = $"{prefix}{GameData.PlayerSkin}";
        }

        private void FaceUpdate()
        {
            if (GameData.PlayerGender == "Female")
            {
                if (GameData.PlayerGirlFace == "girlface3")
                {
                    CharacterFace.Source = "girlface3";
                }
                else
                {
                    CharacterFace.Source = $"{GameData.PlayerGirlFace}{GameData.PlayerEyecolor}";
                }
            }
            else
            {
                if (GameData.PlayerBoyFace == "boyface1")
                {
                    CharacterFace.Source = "boyface1";
                }
                else
                {
                    CharacterFace.Source = $"{GameData.PlayerBoyFace}{GameData.PlayerEyecolor}";
                }
            }
        }
        private void UpdateClothes()
        {
            top.Source = $"{GameData.PlayerTop}";
            bottom.Source = $"{GameData.PlayerBottom}";
        }
    }
}
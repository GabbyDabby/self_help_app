namespace self_help_rpg;

public partial class MainPage2 : ContentPage
{
	public MainPage2()
	{
		InitializeComponent();
        CharacterInit();
	}

	private void CharacterInit()
	{
		SetSkin(GameData.PlayerSkin);
        SetFace();
        SetClothes();
	}
	private void SetSkin(int skin)
	{
        GameData.PlayerSkin = skin;
		if (GameData.PlayerGender == "Female")
		{
            CharacterBody.Source = $"girlbase{skin}";
        }
		else
		{
			CharacterBody.Source = $"boybase{skin}";
		}
        
    }
	private void SetFace()
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
        else if (GameData.PlayerGender == "Male")
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

    private void SetClothes()
    {
        if (GameData.PlayerGender == "Female")
        {
            CharacterTop.Source = "bra.png";
            CharacterBottoms.Source = "underwear.png";
        }
        else if (GameData.PlayerGender == "Male")
        {
            CharacterTop.Source = "shirtless.png";
            CharacterBottoms.Source = "Boxers.png";
        }
    }
}
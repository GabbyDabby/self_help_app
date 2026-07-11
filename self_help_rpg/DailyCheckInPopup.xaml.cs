namespace self_help_rpg;

public partial class DailyCheckInPopup : ContentPage
{
	public DailyCheckInPopup()
	{
		InitializeComponent();
		StreakInit();
		CheerInit();
	}

	public void StreakInit()
	{
		StreakCounter.Text = GameData.SigninStreak.ToString();
		if(GameData.SigninStreak == 1)
		{
			DaysLabel.Text = "DAY!";
		}
		else
		{
			DaysLabel.Text = "DAYS!";
		}
			
	}
	public void CheerInit()
	{
		if (GameData.SigninStreak >= 7)
		{
			CheerLabel.Text = "You're on fire!";
		}
		if (GameData.SigninStreak >= 14)
		{
			CheerLabel.Text = "You're on a roll!";

		}
		if (GameData.SigninStreak >= 21)
		{
			CheerLabel.Text = "You're doing amazing sweetie!";
		}
        if (GameData.SigninStreak >= 28)
        {
            CheerLabel.Text = "Keep up the good work!";
        }
    }
}
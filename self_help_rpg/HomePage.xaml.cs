namespace self_help_rpg
{
    public partial class HomePage : ContentPage
    {


        public HomePage()
        {
            InitializeComponent();
            NameInit();
        }
        public void NameInit()
        {
            NameLabel.Text = GameData.PlayerName;
        }

    }
}
using System.Text;

namespace self_help_rpg;

public partial class ReturningUserPopup : ContentPage
{
    private readonly Random _random = new();

    private string Text1 = "It's great to see you again " + GameData.PlayerName + "! Every day you return is another step forward.";

    public ReturningUserPopup()
    {
        InitializeComponent();
        TopTextInit();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await IntroDialogue();
    }

    private async Task IntroDialogue()
    {
        IntroText.Margin = new Thickness(0, 60, 0, 0);
        IntroText.LineHeight = 2;
        await TypeText(IntroText, Text1);

    }

    private async Task TypeText(Label label, string text)
    {
        var sb = new StringBuilder();
        label.Text = "";

        foreach (char c in text)
        {
            sb.Append(c);
            label.Text = sb.ToString();

            int delay = c switch
            {
                '.' or '!' or '?' => 250,
                ',' => 120,
                ' ' => 20,
                _ => _random.Next(20, 45)
            };

            await Task.Delay(delay);
        }
        
    }

    private void TopTextInit()
    {
        TopText.Text = "Welcome back " + GameData.PlayerName + "!";
    
    }

}
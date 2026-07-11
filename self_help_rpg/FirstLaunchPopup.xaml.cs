using System.Text;

namespace self_help_rpg;

public partial class FirstLaunchPopup : ContentPage
{
    private readonly Random _random = new();

    private string Text1 = "Congratulations on taking the first step. Even the tallest mountains are climbed one step at a time.";
    private string Text2 = "Your journey won't always be easy, but remember—you don't have to become your best self overnight. Just become a little better than yesterday.";

    public FirstLaunchPopup()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await IntroDialogue();
    }

    private async Task IntroDialogue()
    {
        IntroText.Margin = new Thickness(0, 80, 0, 0);
        await TypeText(IntroText, Text1);

        // Give the player a chance to read the first message.
        await Task.Delay(3000);

        IntroText.Margin = new Thickness(0, 55, 0, 0);
        await TypeText(IntroText, Text2);
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
}
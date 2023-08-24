namespace TestCharacterSpacing;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void InputView_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (sender as Entry is { } entry)
        {
            var characterSpacing = entry.CharacterSpacing;
            entry.CharacterSpacing = 0;
            entry.CharacterSpacing = characterSpacing;
        }
    }
}


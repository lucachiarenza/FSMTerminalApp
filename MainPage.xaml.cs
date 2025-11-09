using Microsoft.Maui.Controls;

namespace FSMTerminalApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnContinueClicked(object sender, EventArgs e)
        {
            // Naviga alla seconda pagina
            await Navigation.PushAsync(new MainMenuPage());
        }
    }
}
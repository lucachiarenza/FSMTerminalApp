using Microsoft.Maui.Controls;

namespace FSMTerminalApp
{
    public partial class MainMenuPage : ContentPage
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void OnVendutoClicked(object sender, EventArgs e)
        {
            DisplayAlert("Venduto", "Funzionalità Venduto selezionata", "OK");
            // Qui implementerai la navigazione alla pagina Venduto
        }

        private void OnMovimentiClicked(object sender, EventArgs e)
        {
            DisplayAlert("Movimenti", "Funzionalità Movimenti selezionata", "OK");
            // Qui implementerai la navigazione alla pagina Movimenti
        }

        private void OnResiClicked(object sender, EventArgs e)
        {
            DisplayAlert("Resi", "Funzionalità Resi selezionata", "OK");
            // Qui implementerai la navigazione alla pagina Resi
        }

        private void OnInventarioClicked(object sender, EventArgs e)
        {
            DisplayAlert("Inventario", "Funzionalità Inventario selezionata", "OK");
            // Qui implementerai la navigazione alla pagina Inventario
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
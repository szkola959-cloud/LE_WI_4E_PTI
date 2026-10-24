using System.Collections.ObjectModel;

namespace NotatkiMobilne;

public partial class MainPage : ContentPage
{
    // Kolekcja powiadamiająca interfejs o dodaniu elementu
    public ObservableCollection<string> Notatki { get; set; }

    public MainPage()
    {
        InitializeComponent();

        // Trzy początkowe znaczące notatki
        Notatki = new ObservableCollection<string>
        {
            "Kupić zeszyt do matematyki",
            "Przygotować projekt na PTI",
            "Wyprowadzić psa na spacer"
        };

        BindingContext = this;
        notatkiListView.ItemsSource = Notatki;
    }

    // Obsługa kliknięcia przycisku DODAJ
    private void OnDodajClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(nowaNotatkaEntry.Text))
        {
            // Dodanie nowej notatki na końcu kolekcji
            Notatki.Add(nowaNotatkaEntry.Text.Trim());

            // Wyczyszczenie pola edycyjnego
            nowaNotatkaEntry.Text = string.Empty;
        }
    }
}

using AppDbSqlite.Modelos;

namespace AppDbSqlite;

public partial class MainPage : ContentPage
{
    FrutasModelo db = new FrutasModelo();
	public MainPage()
	{
		InitializeComponent();
	}

    private void GuardarDatos_Clicked(object sender, EventArgs e)
    {
        Fruta fruta = new Fruta()
        {
            Nombre = NombreTxt.Text,
            Color = ColorTxt.Text,
            Cantidad= CantidadTxt.Text,
            PrecioKg = PrecioKgTxt.Text
        };

        db.Fruta.Add(fruta);
        db.SaveChangesAsync();

        NombreTxt.Text= "";
        ColorTxt.Text = "";
        CantidadTxt.Text = "";
        PrecioKgTxt.Text = "";

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var fruta = db.Fruta.ToList();
        FrutaListView.ItemsSource = fruta;
    }
}


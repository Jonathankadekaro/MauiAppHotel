namespace MauiAppHotel.Views;

public partial class ContratacaodaHospedagem : ContentPage
{
	public ContratacaodaHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

			Navigation.PushAsync(new HospedagemContratada());



		}
		catch (Exception ex) 
		{ 
		
		
			DisplayAlert("Ops", ex.Message, "OK");


        }





    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

        try
        {

            Navigation.PushAsync(new Sobre());



        }
        catch (Exception ex)
        {


            DisplayAlert("Ops", ex.Message, "OK");


        }



    }
}
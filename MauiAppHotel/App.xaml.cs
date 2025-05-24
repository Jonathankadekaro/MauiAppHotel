using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 500,
                ValorDiariaCrianca = 250    
            },
            new Quarto()
            {
                Descricao = "Suite Luxo",
                ValorDiariaAdulto = 400,
                ValorDiariaCrianca = 200
            },
            new Quarto()
            {
                Descricao = "Suite Single",
                ValorDiariaAdulto = 300,
                ValorDiariaCrianca = 150
            },

            new Quarto()
            {
                Descricao = "Suite Crise",
                ValorDiariaAdulto = 200,
                ValorDiariaCrianca = 100
            },


        };
        public App()
        {
            InitializeComponent();
        
        
            MainPage = new NavigationPage(new Views.ContratacaodaHospedagem());

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return  window;
        }
    }
}
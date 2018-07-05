using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DescarteCerto.Views
{
    public partial class CadastroPontoColetaPage : ContentPage
    {
        public CadastroPontoColetaPage()
        {
            InitializeComponent();

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(0, 0),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Id = "Xamarin",
            };

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(0, 0), Distance.FromMiles(0)));

            MyMap.Pins.Add(pin);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChipType_Sample
{
    public partial class MainPage : ContentPage
    {

        public List<ImageSource> Images = new List<ImageSource>();

        public MainPage()
        {
            InitializeComponent();
            CloseImage.Source = ImageSource.FromResource("ChipType_Sample.CloseButton.png");
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var viewModel = this.BindingContext as ViewModel;
            viewModel.IsOpen = false;
        }
    }

    public class AnimationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Grid dialogGrid = parameter as Grid;

            if((bool)value)
            {
                dialogGrid.FadeTo(1, 600, Easing.SinOut);
            }
                
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}

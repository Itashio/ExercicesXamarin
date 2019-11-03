using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exericices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercice1 : ContentPage
    {
        public Exercice1()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {
                Padding = new Thickness(20, 30, 20, 20);
            }

            if (Device.RuntimePlatform == Device.UWP)
            {
                Padding = new Thickness(20, 40,20, 20);
            }

        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            displaySize.FontSize = value;
            displayLabel.Text = String.Format("Font Size: {0}", value);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TakeOutApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderContentView : ContentView
    {
        public HeaderContentView()
        {
            InitializeComponent();

            var assembly = typeof(HeaderContentView);

            gradientImage.Source = ImageSource.FromResource("TakeOutApplication.Assets.Images.gradient.jpg", assembly);
            userImage.Source = ImageSource.FromResource("TakeOutApplication.Assets.Images.user.png", assembly);
        }
    }
}
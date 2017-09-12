using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatImagePage : ContentPage
	{
		public PlatImagePage ()
		{
			InitializeComponent ();
		    string imageLocation;
		    switch (Device.RuntimePlatform)
		    {
                
                case Device.WinPhone: imageLocation = "Images/clock.png"; break;
                case Device.Windows: imageLocation = "Images/clock.png"; break;
                case Device.Android: imageLocation = "clock.png"; break;
                default: imageLocation = "clock.png"; break;
            }
		    var image = (FileImageSource) ImageSource.FromFile(imageLocation);
		    Btn.Image = image;
		}
	}
}
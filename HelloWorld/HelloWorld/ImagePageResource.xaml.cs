using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePageResource : ContentPage
	{
		public ImagePageResource ()
		{
			InitializeComponent ();
            //BackgroundImage.Source = ImageSource.FromResource("HelloWorld.Images.background.jpg");
		}
	}
}
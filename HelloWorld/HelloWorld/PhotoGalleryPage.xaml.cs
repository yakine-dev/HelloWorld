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
	public partial class PhotoGalleryPage : ContentPage
	{
	    private List<UriImageSource> _imageUriList;
		public PhotoGalleryPage ()
		{
			InitializeComponent ();
		    _imageUriList = new List<UriImageSource>();
		    for (int i = 1; i < 11; i++)
		    {
		        _imageUriList.Add(new UriImageSource
		        {
		            Uri = new Uri("http://lorempixel.com/1920/1080/city/" + i)                  
                });
		    }
		    ImageView.Source = _imageUriList[0];


		}

	    private void BtnPrev_OnClicked(object sender, EventArgs e)
	    {
	        var index =_imageUriList.IndexOf((UriImageSource) ImageView.Source);
	        ImageView.Source = index == 0 ? _imageUriList[_imageUriList.Count-1]:_imageUriList[index-1];

	    }

	    private void BtnNext_OnClicked(object sender, EventArgs e)
	    {
	        var index = _imageUriList.IndexOf((UriImageSource)ImageView.Source);
	        ImageView.Source = index == (_imageUriList.Count - 1) ? _imageUriList[0] : _imageUriList[index+1];
        }
	}
}
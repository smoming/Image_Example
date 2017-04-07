using Xamarin.Forms;
using System;

namespace ImageDemo
{
	public partial class ImageDemoPage : ContentPage
	{
		public ImageDemoPage()
		{
			InitializeComponent();

			xImage.Source = ImageSource.FromResource("ImageDemo.didi.jpg");
			//xImage.Source = new UriImageSource()
			//{
			//	Uri = new Uri("https://goo.gl/8eUKFy"),
			//	CachingEnabled = true,
			//	CacheValidity = new TimeSpan(5,0,0,0)
			//};
			xImage.Aspect = Aspect.AspectFit;
		}
	}
}

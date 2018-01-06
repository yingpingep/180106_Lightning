using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFLaricApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
		}

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pick = (Picker)sender;
            Task.Run(async () =>
            {
                string line = await NSLyricTest.Lyric.GetLyricAsync(pick.SelectedIndex.ToString());                
                Device.BeginInvokeOnMainThread(() =>
                    lyric.Text = line);
            });          
        }
    }
}

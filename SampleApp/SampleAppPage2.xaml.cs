using Xamarin.Forms;
using System;

namespace SampleApp
{
	
	public partial class SampleAppPage2 : ContentPage
	{
		Int32 intCnt;
		/*
		void Btn1_Clicked(object sender, System.EventArgs e)
		{
			this.text1.Text = "clicked です";
			System.Diagnostics.Debug.WriteLine("{0}おk", 10);
		}
		*/

		public SampleAppPage2()
		{
			InitializeComponent();
			this.btn1.Clicked += (x, y) => {
				intCnt += 1;
				this.text1.Text = "aaaaaaa " + intCnt.ToString();
				//System.Diagnostics.Debug.WriteLine("{0}おk", intCnt);
			};
		}
	}
}


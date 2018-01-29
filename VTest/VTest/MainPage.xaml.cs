using System;
using Xamarin.Forms;

namespace VTest
{
	public partial class MainPage : ContentPage
	{
        

        public MainPage()
		{
			InitializeComponent();
		}

        public string Post { get; private set; }

        private void OnPost(object sender, EventArgs e) => Post = postText.Text;

        private void OnRequest(Object sender, EventArgs e) => viewDisplay.Text = Post;
    }
}

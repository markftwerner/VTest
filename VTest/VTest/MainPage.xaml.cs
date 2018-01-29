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

        void OnPost(object sender, EventArgs e)
        {
            Post = postText.Text;
        }

        void OnRequest(Object sender, EventArgs e)
        {
            viewDisplay.Text = Post;
        }
    }
}

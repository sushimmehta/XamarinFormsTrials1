using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsTrials1
{
    public partial class MagicPage : ContentPage
    {
        public MagicPage()
        {
            InitializeComponent();
        }
        void ShakeClicked(object s, EventArgs e)
        {
            var rnd = new System.Random();
            output.Text = "test";
        }

    }
}

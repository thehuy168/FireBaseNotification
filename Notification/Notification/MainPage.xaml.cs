using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notification
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void SendNotification(object sender, EventArgs e)
        {
            DependencyService.Get<INotification>().CreateNotification("Hello", message.Text);
        }

    }
}

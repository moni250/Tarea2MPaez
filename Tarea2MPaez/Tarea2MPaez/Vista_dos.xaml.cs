using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2MPaez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista_dos : ContentPage
    {
        public Vista_dos(string user ,string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }

       
    }
}
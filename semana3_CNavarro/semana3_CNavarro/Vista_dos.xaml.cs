using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana3_CNavarro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista_dos : ContentPage
    {
        public Vista_dos(String user, String pass)
        {
            InitializeComponent();
            lbluser.Text = user;
            txtPass.Text = pass; 
        }
    }
}
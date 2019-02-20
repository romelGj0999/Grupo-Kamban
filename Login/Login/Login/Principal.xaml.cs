using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login.Model;
namespace Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : ContentPage
	{
		public Principal ()
		{
			InitializeComponent ();
		}
        private void BtnInsert_Clicked(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            UserRepository.Instancia.AddNewUser(txtUsername.Text, txtEmail.Text, txtPassword.Text);
            StatusMessage.Text = UserRepository.Instancia.EstadoMensaje;

        }

        private void BtnAllUser_Clicked(object sender, EventArgs e)
        {
            var allUsers = UserRepository.Instancia.GetAllUsers();
            userList.ItemsSource = allUsers;
            StatusMessage.Text = UserRepository.Instancia.EstadoMensaje;
        }
    
}
}
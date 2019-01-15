using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contacts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddContact : ContentPage
    {
        public event EventHandler<contact> ContactAdded;
        public event EventHandler<contact> ContactUpdate;

        public AddContact (contact contact= null)
		{
			InitializeComponent ();
            
            BindingContext = new contact
            {
                Id =  contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone,
                Email = contact.Email,
                IsBlocked = contact.IsBlocked
            };
        
        bt1.Text = (contact.FirstName != null) ? "Update" : "ADD";
            bt1.TextColor = (contact != null) ? Color.BlueViolet : Color.Green;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var cnt = BindingContext as contact;
            if (cnt.FirstName == null)
            {
                await DisplayAlert("Alert", "Firstname should not be empty", "ok");
                return;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(cnt.Id.ToString()))
                {
                    //await DisplayAlert("Alert", cnt.FirstName, "ok");
                    cnt.Id = 1;
                    ContactAdded?.Invoke(this, cnt);
                    await Navigation.PopModalAsync();
                }
                else
                {
                    //await DisplayAlert("new", cnt.FirstName, "ok");
                  
                     ContactUpdate?.Invoke(this, cnt);
                    await Navigation.PopModalAsync();
                }
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Contacts.Model;

namespace Contacts
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<contact> _contactlist;
        public MainPage()
        {
            InitializeComponent();
            list1.ItemsSource = GetContacts();
        }
        
        private ObservableCollection<contact> GetContacts()
        {
            return _contactlist = new ObservableCollection<contact>
         {
             new contact{Id=1,FirstName="sohail",LastName="shaik",Phone=123456789,IsBlocked=false},
              new contact{Id=1,FirstName="Ashok",LastName="kommi",Phone=555555 ,IsBlocked=false},

               new contact{Id=1,FirstName="prava",LastName="kolukuluri",Phone=121312121 ,IsBlocked=true},
               new contact{Id=1,FirstName="ramya",LastName="bosetty",Phone=121312121 ,IsBlocked=false},
               new contact{Id=1,FirstName="sunil",LastName="mandati",Phone=56784454 ,IsBlocked=true} ,
         };
        }

        async void ToolbarItem_Activated(object sender, EventArgs e)
        {
            var page = (new AddContact(new contact()));


            page.ContactAdded += (source, contact) =>
            {
                _contactlist.Add(contact);
                DisplayAlert("del", contact.FirstName, "ok");
            };
            await   Navigation.PushModalAsync(page);
        }

        private async void List1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var cnt = e.SelectedItem as contact;
            
            var page = new AddContact(cnt);
            // DisplayAlert("alert", cnt.FirstName.ToString(), "exit");
          //  
            page.ContactUpdate += (source, contact) =>
            {
               // var x= _contactlist.Where(y=> y.FirstName== cnt.FirstName)
                
                cnt.FirstName = contact.FirstName;
                cnt.LastName = contact.LastName;
                cnt.Phone = contact.Phone;
                cnt.IsBlocked = contact.IsBlocked;
            };
            await Navigation.PushModalAsync(page);
         //   list1.SelectedItem = null; 

        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var send = (sender as MenuItem).CommandParameter as contact;
            //DisplayAlert("del", send.FirstName, "ok");
            _contactlist.Remove(send);
        }
    }
}

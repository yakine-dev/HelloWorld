using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            this.ListView.ItemsSource = GetContact();

        }

        public IEnumerable<Contact> GetContact(string searchText = null)
        {
            var contact = new List<Contact>
            {
                new Contact {Name = "Bob", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "Let's talk"},
                new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2"},
                new Contact
                {
                    Name = "Jacob",
                    ImageUrl = "http://lorempixel.com/100/100/people/3",
                    Status = "Watching Movie"
                },
                new Contact {Name = "Mike", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "Away"}
            };
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return contact;
            }
            return contact.Where(c => c.Name.StartsWith(searchText));

        }

        private void ListView_OnRefreshing(object sender, EventArgs e)
        {
            this.ListView.ItemsSource = GetContact();
            this.ListView.EndRefresh();
        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            this.ListView.ItemsSource = GetContact(e.NewTextValue);
        }
    }
}
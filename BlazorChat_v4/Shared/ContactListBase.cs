using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorChat_v4.Shared;

namespace BlazorChat_v4.Client.Pages
{
    public class ContactListBase
    {
        public IEnumerable<Contact> ContactList { get; set; }
        protected async Task OnInitializedAsync()
        {
            LoadContactList();
        }

        
        //hard code here


        private void LoadContactList ()
        {
            Contact c1 = new Contact(3, "Jack", "Rassel");
            Contact c2 = new Contact(1, "Den", "Semenets");
            Contact c3 = new Contact(2, "Arya", "Frank");
            ContactList = new List<Contact> { c1,c2,c3};
        }
    }
}

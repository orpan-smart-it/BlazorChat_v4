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
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorChat_v4.Server.Services;
using BlazorChat_v4.Shared;
using Microsoft.AspNetCore.Components;



namespace BlazorChat_v4.Server
{
    public class ContactListBase : ComponentBase 
    {
        [Inject] 
        public IContactService contactService;
        public IEnumerable<Contact> ContactList { get; set; }
        protected async Task OnInitializedAsync()
        {
            ContactList = (await contactService.GetContacts()).ToList();
        }

        

    }
}

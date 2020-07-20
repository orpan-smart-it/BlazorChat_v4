using BlazorChat_v4.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorChat_v4.Server.Services
{
    public class ContactService : IContactService
    {
        private readonly HttpClient httpClient = new HttpClient();
        public ContactService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Contact>> GetContacts()
        {
            return await httpClient.GetJsonAsync<Contact[]>("api/contacts");
        }
    }
    
}

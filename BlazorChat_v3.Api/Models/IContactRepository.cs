using BlazorChat_v4.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat_v3.Api.Models
{
   public interface IContactRepository
    {
        #nullable enable
        Task<IQueryable<Contact>> SearchContact(string name, string? email);
        Task<IEnumerable<Contact>> GetContacts();
        Task<Contact> GetContact(int contactId);
        Task<Contact> GetEmail(string email);
        Task<Contact> AddContact(Contact contact);
        Task<Contact> UpdateContact(Contact contact);
        void DeleteContact(int contactId);

    }
}

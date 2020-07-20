using BlazorChat.Api.Models;
using BlazorChat_v4.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat_v3.Api.Models
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContextClass appDbContext;
        public ContactRepository(AppDbContextClass appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Contact> AddContact(Contact contact)
        {
            //adding new contact
            var result = await appDbContext.Contacts.AddAsync(contact);
            //saving
            await appDbContext.SaveChangesAsync();
            //returning the result
            return result.Entity;
        }

        public async void DeleteContact(int contactId)
        {
            var result = await appDbContext.Contacts
                 .FirstOrDefaultAsync(e => e.ContactId == contactId);
            if (result != null)
            {
                appDbContext.Contacts.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<Contact> GetContact(int contactId)
        {
            return await appDbContext.Contacts
                .FirstOrDefaultAsync(e => e.ContactId == contactId);
        
        }

        public async Task<Contact> GetEmail(string email)
        {
            return await appDbContext.Contacts
                .FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            return await appDbContext.Contacts.ToListAsync();
        }

        public async Task<Contact> UpdateContact(Contact contact)
        {
            var result = await appDbContext.Contacts
                .FirstOrDefaultAsync(e => e.ContactId == contact.ContactId);

            if (result != null)
            {
                result.FirstName = contact.FirstName;
                result.LastName = contact.LastName;

                await appDbContext.SaveChangesAsync();
                return result;


            }
            return null; 
                

        }
    }
}

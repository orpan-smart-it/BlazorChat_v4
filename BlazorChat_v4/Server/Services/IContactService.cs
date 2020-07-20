using BlazorChat_v4.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat_v4.Server.Services
{
    interface IContactService
    {
        Task<IEnumerable<Contact>> GetContacts();
    }
}

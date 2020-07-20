using System;
using System.Collections.Generic;
using System.Text;


namespace BlazorChat_v4.Shared
{
    public class Contact
    {
       
            public int ContactId { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }
        public string Email { get; set; }
            public Contact()
            {

            }
            public Contact(int contactId, string firstName, string lastName, string email)
            {
                this.ContactId = contactId;
                this.FirstName = firstName;
                this.LastName = lastName;
            this.Email = email;
            }
        }
    }

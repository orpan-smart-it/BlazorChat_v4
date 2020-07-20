using BlazorChat_v3.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorChat_v4.Shared;

namespace BlazorChat_v3.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ContactsController : ControllerBase
    {
            private readonly IContactRepository contactRepository;

            public ContactsController(IContactRepository contactRepository)
            {
            this.contactRepository = contactRepository;
            }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
            {
                try
                {
                    return (await contactRepository.GetContacts()).ToList();
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error retrieving data from the database");
                }
            }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Contact>> GetContact(int id)
            {
                try
                {
                    var result = await contactRepository.GetContact(id);

                    if (result == null) return NotFound();

                    return result;
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error retrieving data from the database");
                }
            }
        [HttpPost]
        public async Task<ActionResult> AddContact([FromBody]Contact contact)
        
        {
            try
            {
                if (contact == null)
                {
                    return BadRequest();
                }
                else
                {
                    if (contactRepository.GetEmail(contact.Email)!=null)
                    {
                        var createdContact = await contactRepository.AddContact(contact);
                        return CreatedAtAction(nameof(GetContact), new{id = createdContact.ContactId}, createdContact);

                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError, "Such a contact is already exist");
                    }
                }
                
                
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error adding a new contact.");
            }
        }
        }
    
    }

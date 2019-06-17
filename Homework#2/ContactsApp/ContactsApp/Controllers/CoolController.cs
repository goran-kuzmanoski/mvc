using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactsApp.Models;

namespace ContactsApp.Controllers
{
    [Route("contacts")]
    public class CoolController : Controller
    {
        private List<Contact> contacts = new List<Contact> {
            (new Contact { FirstName = "Goran", LastName = "Kuzmnanoski", IsCloseFriend = true, PhoneNumber = 076268808 }),
            (new Contact { FirstName = "Jovan", LastName = "Jovanoski", IsCloseFriend = true, PhoneNumber = 07123456 }),
            (new Contact { FirstName = "Vladimir", LastName = "Poposki", IsCloseFriend = false, PhoneNumber = 071345678 })
        };


        [Route("get-all-contacts")]
        public IActionResult GetEveryone()
        {
            var friends = new ContactsViewModel
            {
                Contacts = contacts
            };
            return View("Views/Cool/Index.cshtml", friends);
        }
        [Route("get-closest-contacts")]
        public IActionResult GetFriends()
        {
            var friends = new ContactsViewModel
            {
                Contacts = contacts.Where(x => x.IsCloseFriend).ToList()
            };
            return View("Views/Cool/Index.cshtml", friends);

        }
        [Route("add-contact")]
        public IActionResult AddContact()
        {
            return View(new Contact());
        }
        [Route("add-contact")]
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = $"Successfully added {contact.FirstName}";
                return View(new Contact());
            }

            return View(contact);

        }

    }
}

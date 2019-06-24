using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsApp.Models;

namespace ContactsApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ContactsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Contacts.Any())
            {
                return;
            }
            var contacts= new List<Contact>
            {
            (new Contact { FirstName = "Goran", LastName = "Kuzmnanoski", IsCloseFriend = true, PhoneNumber = "+389076268808" }),
            (new Contact { FirstName = "Jovan", LastName = "Jovanoski", IsCloseFriend = true, PhoneNumber = "+38907123456" }),
            (new Contact { FirstName = "Vladimir", LastName = "Poposki", IsCloseFriend = false, PhoneNumber = "+389071345678" })
            };
            foreach (var contact in contacts)
            {
                context.Contacts.Add(contact);
            }
            context.SaveChanges();

        }
    }
}

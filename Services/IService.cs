using Contact_manager.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager.Services
{
        public interface IService
        {
            void AddContact(string name, string phone, string email);
            void EditContact(int id, string name, string phone, string email);
            void DeleteContact(int id);
            Contact GetContact(int id);
            List<Contact> GetAllContacts();

            // Some filter and search are done as not specified 
            // Search by which property and filter by which property also
            List<Contact> Search(string keyword);
            List<Contact> FilterByDate(DateTime date);

            void Save();
            void Load();
        }
    
}



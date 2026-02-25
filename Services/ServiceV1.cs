using Contact_manager.Components;
using Contact_manager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Contact_manager.Services
{
    public class ServiceV1 :IService
    {
        private List<Contact> contacts = new();
        private int nextId = 1;
        private const string FilePath = "contacts.json";

        public void AddContact(string name, string phone, string email)
        {
            contacts.Add(new Contact(nextId++, name, phone, email));
        }

        public void EditContact(int id, string name, string phone, string email)
        {
            var c = GetContact(id);
            if (c == null) return;

            c.Name = name;
            c.Phone = phone;
            c.Email = email;
        }

        public void DeleteContact(int id)
        {
            contacts.RemoveAll(c => c.Id == id);
            Console.WriteLine("Done !");
        }

        public Contact GetContact(int id)
        {
            return contacts.FirstOrDefault(c => c.Id == id);
        }

        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

       
        public List<Contact> Search(string keyword)
        {
            return contacts.Where(c =>
                c.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                c.Phone.Contains(keyword) ||
                c.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        public List<Contact> FilterByDate(DateTime date)
        {
            return contacts.Where(c => c.CreatedAt.Date == date.Date).ToList();
        }

        
        public void Save()
        {
            var json = JsonSerializer.Serialize(contacts);
            File.WriteAllText(FilePath, json);
        }

       
        public void Load()
        {
            if (!File.Exists(FilePath)) return;

            var json = File.ReadAllText(FilePath);
            contacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? new();

            if (contacts.Any())
                nextId = contacts.Max(c => c.Id) + 1;
        }

    }
}




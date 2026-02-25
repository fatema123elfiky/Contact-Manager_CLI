using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_manager.Components
{
    // Data of the contact 
    public class Contact
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; private set; }

        public Contact(int id, string name, string phone, string email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            CreatedAt = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine($"{Id} | {Name} | {Phone} | {Email} | {CreatedAt}");
        }
    }

 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipApi.Models
{
    public class User
    {
        public string Id { get; set; }
        public string AddressId { get; set; }
        public string UserLevel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public User() { }

        public User(string id, string addressId, 
            string userLevel, string firstName, 
            string lastName, string email, string phone)
        {
            Id = id;
            AddressId = addressId;
            UserLevel = userLevel;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
    }
}

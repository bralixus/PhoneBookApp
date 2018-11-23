using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Web;

namespace PhoneBookApp.Models
{
    public class PersonModel
    {
        public PersonModel()
        {

        }
        public PersonModel(int iD, string name, string lastName, int phone, string email, DateTime created, DateTime updated)
        {
            ID = iD;
            Name = name;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Created = created;
            Updated = updated;
        }

        public int? ID { get; set; }

        [Required(ErrorMessage = "Pole wymagane!"), StringLength(20, ErrorMessage = "Zbyt długi wpis!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole wymagane!"), StringLength(20, ErrorMessage = "Zbyt długi wpis!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Pole wymagane!"), Range(111111111,999999999, ErrorMessage = "Podaj 9 cyfr numeru telefonu")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Pole wymagane!"), EmailAddress(ErrorMessage = "To nie jest poprawny format!")]
        public string Email { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }

    
}
﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "First name required")]
        [Display(Name = "First name")]
        [MaxLength(30), MinLength(3)]
        public string FirstName  { get; set; }
        [Required(ErrorMessage = "Surname Required")]
        [MaxLength(30)]

        public string Surname{ get; set; }
        [Required(ErrorMessage = "Age required")]
        public byte Age { get; set; }
        [Required(ErrorMessage = "Country required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "City required")]
        public string City { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Birth date Required")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [Display(Name = "Birth date")]
        public DateTime BirthDate { get; set; }
        
        [Required(ErrorMessage = "Salary required")]
        [DataType(DataType.Currency)]
        [Range(15000, 60000, ErrorMessage = "Salary must between 150 to 60000")]
        public int Salary { get; set; }
        [Required(ErrorMessage = "Phone number required")]
        [Phone]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email Address required")]
        [EmailAddress]

        public string Email { get; set; }
        [Required(ErrorMessage = "Position Required")]
        public string Position { get; set; }
        [Required]
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }






    }
}
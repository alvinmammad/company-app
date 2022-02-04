using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "First name required")]
        [Display(Name = "First name")]
        [MaxLength(30, ErrorMessage = "Name maximum length must be 30"), MinLength(3, ErrorMessage = "Name minimum length must be 3")]
        public string FirstName  { get; set; }
        [Required(ErrorMessage = "Surname Required")]
        [MaxLength(30,ErrorMessage ="Surname maximum length must be 30"), MinLength(3, ErrorMessage = "Surname minimum length must be 3")]

        public string Surname{ get; set; }
        [Required(ErrorMessage = "Age required")]
        [Range(18, 65, ErrorMessage = "Age must between 18 to 65")]
        public byte? Age { get; set; }
        [Required(ErrorMessage = "Country required")]
        [MinLength(3, ErrorMessage = "Country minimum length must be 3")]
        public string Country { get; set; }
        [Required(ErrorMessage = "City required")]
        [MinLength(3, ErrorMessage = "City minimum length must be 3")]

        public string City { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Birth date required")]
        [Display(Name = "Birth date")]
        public DateTime? BirthDate { get; set; }
        
        [Required(ErrorMessage = "Salary required")]
        [Range(150, 60000, ErrorMessage = "Salary must between 150 ₼ to 60000 ₼")]
        public int? Salary { get; set; }
        [Required(ErrorMessage = "Phone number required")]
        [Phone]
        
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email Address required")]
        [EmailAddress]

        public string Email { get; set; }
        [Required(ErrorMessage = "Position Required")]
        [MinLength(2, ErrorMessage = "Position minimum length must be 3")]
        public string Position { get; set; }
        [Required(ErrorMessage ="Department required")]
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }






    }
}

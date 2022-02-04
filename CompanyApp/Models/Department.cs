using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompanyApp.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Department name required")]
        [Display(Name = "Department name")]
        [MaxLength(40,ErrorMessage = "Department name maximum length must be 40"),MinLength(2, ErrorMessage = "Department name minimum length must be 2")]
        public string DepName { get; set; }
        [Required(ErrorMessage = "Department manager name required")]
        [Display(Name = "Department manager name")]
        [MaxLength(30, ErrorMessage = "Department manager name maximum length must be 30"), MinLength(3, ErrorMessage = "Department manager name minimum length must be 3")]
        public string DepManagerName { get; set; }
        [Required(ErrorMessage = "Department manager surname required")]
        [Display(Name = "Department manager surname")]
        [MaxLength(40, ErrorMessage = "Department manager surname maximum length must be 40"),MinLength(3, ErrorMessage = "Department manager surname minimum length must be 3")]

        public string DepManagerSurname { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
    }
}

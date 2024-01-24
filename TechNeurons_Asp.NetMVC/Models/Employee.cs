using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TechNeurons_Asp.NetMVC.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }

        [Required(ErrorMessage ="Required Employee Name")]
        [DisplayName("Name")]
        public string Emp_Name { get; set; }

        [Required(ErrorMessage = "Required Employee Age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Required Job Description")]
        [DisplayName("Job Description")]
        public string Job_Description { get; set; }

        [Required(ErrorMessage ="Required Salary")]
        public int Salary { get; set; }
    }

    public class EFCodeFirstEntities : DbContext
    {
        public DbSet<Employee> employees { get; set; }
    }
}
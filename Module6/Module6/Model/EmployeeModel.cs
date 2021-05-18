using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Module6.Model
{
   public class EmployeeModel
    {
        [Key]

        public int Id { get; set; }
        public string Employeename { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
}

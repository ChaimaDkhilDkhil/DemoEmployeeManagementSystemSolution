using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Employee 
    {
       public int Id { get; set; }
       public string? Name { get; set; }
       public String? CivilId { get; set; }
       public String? FileNumber { get; set; }
       public String? JobName { get; set; }
       public String? Address { get; set; }
       public String? TelephoneNumber { get; set; }
       public String? Photo{ get; set; }
       public String? Other{ get; set; }

        public Employee() { }

        //Relationship : Many to One
        public GeneralDepartment? GeneralDepartment { get; set; }
        public int GeneralDepartmentId { get; set; }
        public Department? Department { get; set; }
        public int DepartmentId { get; set; }

        public Branch? Branch { get; set; }
        public int  BranchId { get; set; }
        public Town? Town { get; set; }
        public int TownId { get; set; }







    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSytem
{
    class Registration
    {
        public bool exist { get; set; }

        public Registration(int id, string fullname, string dateBirth, string department, string role)
        {
             Employee RegistrationEmployee = new Employee(id, fullname, dateBirth, department, role);
             AddEmployee addEmp = new AddEmployee(id, fullname, dateBirth, department, role);
             exist = addEmp.exist;

        }

    }
}

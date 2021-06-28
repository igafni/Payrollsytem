using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSytem
{
    class InsertWorkTime
    {
        public string _eror { get; set; }

        public InsertWorkTime(int id, string fullname,string start, string end)
        {
            AddEmployeeWorkTime emp = new AddEmployeeWorkTime(id, fullname, start, end);
            _eror = emp._Eror;
        }
    }
}

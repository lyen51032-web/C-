using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjMultiTable.Models
{
    public class CVMDepEmp
    {


        public List<tDepartment> department { get; set; }
        public List<tEmployee> employee { get; set; }

    }
}
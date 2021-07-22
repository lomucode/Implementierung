using System;
using System.Collections.Generic;

#nullable disable

namespace testcsharp.models
{
    public partial class EmployeeDb
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int? Salary { get; set; }
    }
}

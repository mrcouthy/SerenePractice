
namespace MovieTutorial.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Employee")]
    [BasedOnRow(typeof(Entities.EmployeeRow))]
    public class EmployeeForm
    {
        public String Name { get; set; }
        public Int32 Address { get; set; }
        public String Email { get; set; }
    }
}
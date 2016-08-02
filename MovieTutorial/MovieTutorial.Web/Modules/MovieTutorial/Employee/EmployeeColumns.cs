
namespace MovieTutorial.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Employee")]
    [BasedOnRow(typeof(Entities.EmployeeRow))]
    public class EmployeeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 EmployeeId { get; set; }
        [EditLink]
        [DisplayName("Name of Employee"), Width(150), AlignRight]
        public String Name { get; set; }
        public Int32 Address { get; set; }
        public String Email { get; set; }
    }
}
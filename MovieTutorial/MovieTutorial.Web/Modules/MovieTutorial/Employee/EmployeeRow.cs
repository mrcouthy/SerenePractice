
namespace MovieTutorial.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Employee"), InstanceName("Employee"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class EmployeeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Employee Id"), Identity]
        public Int32? EmployeeId
        {
            get { return Fields.EmployeeId[this]; }
            set { Fields.EmployeeId[this] = value; }
        }

        [DisplayName("Name"), Size(255), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Address Details"), NotNull]
        public Int32? Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Email Address"), Size(255)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.EmployeeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public EmployeeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field EmployeeId;
            public StringField Name;
            public Int32Field Address;
            public StringField Email;

            public RowFields()
                : base("[mov].[Employee]")
            {
                LocalTextPrefix = "Employee";
            }
        }
    }
}
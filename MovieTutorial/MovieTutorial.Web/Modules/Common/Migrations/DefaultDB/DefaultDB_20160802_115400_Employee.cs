using FluentMigrator;

namespace MovieTutorial.Migrations.DefaultDB
{
    [Migration(20160802115400)]
    public class DefaultDB_20160802_115400_Employee : Migration
    {
        public override void Up()
        {
            Create.Table("Employee").InSchema("mov")
                .WithColumn("EmployeeId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Address").AsInt32().NotNullable()
                .WithColumn("Email").AsString().Nullable()
                ;

          
        }

        public override void Down()
        {
        }
    }
}
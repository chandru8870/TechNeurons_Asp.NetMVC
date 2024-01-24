namespace TechNeurons_Asp.NetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Emp_Id = c.Int(nullable: false, identity: true),
                        Emp_Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Job_Description = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Emp_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}

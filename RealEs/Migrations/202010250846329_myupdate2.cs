namespace RealEs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myupdate2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Branches", newName: "Branch_tbl");
            RenameTable(name: "dbo.Staffs", newName: "Staff_tbl");
            RenameTable(name: "dbo.Owners", newName: "Owner_tbl");
            RenameTable(name: "dbo.Rents", newName: "Rent_tbl");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Rent_tbl", newName: "Rents");
            RenameTable(name: "dbo.Owner_tbl", newName: "Owners");
            RenameTable(name: "dbo.Staff_tbl", newName: "Staffs");
            RenameTable(name: "dbo.Branch_tbl", newName: "Branches");
        }
    }
}

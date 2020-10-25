namespace RealEs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mynew1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchNo = c.String(nullable: false, maxLength: 128),
                        Street = c.String(),
                        City = c.String(),
                        Postcode = c.String(),
                    })
                .PrimaryKey(t => t.BranchNo);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffNo = c.String(nullable: false, maxLength: 128),
                        Fname = c.String(),
                        Lname = c.String(),
                        Position = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Salary = c.Int(nullable: false),
                        BranchNoRef = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.StaffNo)
                .ForeignKey("dbo.Branches", t => t.BranchNoRef)
                .Index(t => t.BranchNoRef);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerNo = c.String(nullable: false, maxLength: 128),
                        Fname = c.String(),
                        Lname = c.String(),
                        Address = c.String(),
                        TelNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OwnerNo);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        PropertyNo = c.String(nullable: false, maxLength: 128),
                        Street = c.String(),
                        City = c.String(),
                        Ptype = c.String(),
                        Rooms = c.Int(nullable: false),
                        OwnerNoRef = c.String(maxLength: 128),
                        StaffNoRef = c.String(maxLength: 128),
                        BranchNoRef = c.String(maxLength: 128),
                        Rents = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyNo)
                .ForeignKey("dbo.Branches", t => t.BranchNoRef)
                .ForeignKey("dbo.Owners", t => t.OwnerNoRef)
                .ForeignKey("dbo.Staffs", t => t.StaffNoRef)
                .Index(t => t.OwnerNoRef)
                .Index(t => t.StaffNoRef)
                .Index(t => t.BranchNoRef);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "StaffNoRef", "dbo.Staffs");
            DropForeignKey("dbo.Rents", "OwnerNoRef", "dbo.Owners");
            DropForeignKey("dbo.Rents", "BranchNoRef", "dbo.Branches");
            DropForeignKey("dbo.Staffs", "BranchNoRef", "dbo.Branches");
            DropIndex("dbo.Rents", new[] { "BranchNoRef" });
            DropIndex("dbo.Rents", new[] { "StaffNoRef" });
            DropIndex("dbo.Rents", new[] { "OwnerNoRef" });
            DropIndex("dbo.Staffs", new[] { "BranchNoRef" });
            DropTable("dbo.Rents");
            DropTable("dbo.Owners");
            DropTable("dbo.Staffs");
            DropTable("dbo.Branches");
        }
    }
}

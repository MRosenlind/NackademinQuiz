namespace QuizProjekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alternatives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Correct = c.Boolean(nullable: false),
                        Questions_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Questions_Id)
                .Index(t => t.Questions_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Test_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id)
                .Index(t => t.Test_Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Public = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.Alternatives", "Questions_Id", "dbo.Questions");
            DropIndex("dbo.Questions", new[] { "Test_Id" });
            DropIndex("dbo.Alternatives", new[] { "Questions_Id" });
            DropTable("dbo.Tests");
            DropTable("dbo.Questions");
            DropTable("dbo.Alternatives");
        }
    }
}

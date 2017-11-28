namespace AluguelDeCarros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipadoIncluidoNoTrab : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ValorTotal = c.Double(nullable: false),
                        Alugado_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alugados", t => t.Alugado_Id)
                .Index(t => t.Alugado_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipados", "Alugado_Id", "dbo.Alugados");
            DropIndex("dbo.Equipados", new[] { "Alugado_Id" });
            DropTable("dbo.Equipados");
        }
    }
}

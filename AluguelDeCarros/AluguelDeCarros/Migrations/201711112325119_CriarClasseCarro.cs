namespace AluguelDeCarros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarClasseCarro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Marca = c.String(),
                        Quilometragem = c.String(),
                        Cor = c.String(),
                        Placa = c.String(),
                        Cambio = c.String(),
                        Ano = c.Int(nullable: false),
                        Portas = c.Int(nullable: false),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carros");
        }
    }
}

namespace AluguelDeCarros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Cpf = c.String(),
                        Rg = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Rua = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Idade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}

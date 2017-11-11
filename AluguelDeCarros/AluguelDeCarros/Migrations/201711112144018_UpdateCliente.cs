namespace AluguelDeCarros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Numero", c => c.Int(nullable: false));
            DropColumn("dbo.Clientes", "DataNasc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "DataNasc", c => c.Int(nullable: false));
            DropColumn("dbo.Clientes", "Numero");
        }
    }
}

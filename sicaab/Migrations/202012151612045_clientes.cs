namespace sicaab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id_cliente = c.Int(nullable: false, identity: true),
                        dni = c.String(nullable: false, maxLength: 20),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Edad = c.Int(nullable: false),
                        Correo = c.Int(nullable: false),
                        Celular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_cliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}

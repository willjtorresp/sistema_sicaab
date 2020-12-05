namespace sicaab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulos",
                c => new
                    {
                        id_articulo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        cantidad = c.Int(nullable: false),
                        categoria = c.String(nullable: false),
                        descripcion = c.String(nullable: false),
                        stock = c.Int(nullable: false),
                        condicion = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id_articulo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articulos");
        }
    }
}

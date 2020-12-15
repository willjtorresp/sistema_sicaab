namespace sicaab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Correo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Correo", c => c.Int(nullable: false));
        }
    }
}

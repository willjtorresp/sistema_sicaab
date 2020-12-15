namespace sicaab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Celular", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Celular", c => c.Int(nullable: false));
        }
    }
}

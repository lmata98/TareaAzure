namespace bases.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.estudiantes", "cedula", c => c.String());
            AlterColumn("dbo.carreras", "idCarrera", c => c.Int(nullable: false));
            AlterColumn("dbo.estudiantes", "idCarrera", c => c.Int(nullable: false));
            AlterColumn("dbo.estudiantes", "fecha", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.estudiantes", "fecha", c => c.String());
            AlterColumn("dbo.estudiantes", "idCarrera", c => c.String());
            AlterColumn("dbo.carreras", "idCarrera", c => c.String());
            DropColumn("dbo.estudiantes", "cedula");
        }
    }
}

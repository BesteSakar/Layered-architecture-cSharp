namespace DataAcessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migra2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Urunlers", "KategoriID", "dbo.Kategoris");
            DropIndex("dbo.Urunlers", new[] { "KategoriID" });
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 40),
                        stock = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            DropTable("dbo.Kategoris");
            DropTable("dbo.Urunlers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(maxLength: 40),
                        Stok = c.Int(nullable: false),
                        KategoriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunID);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        kategoriID = c.Int(nullable: false, identity: true),
                        kategoriAdi = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.kategoriID);
            
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            CreateIndex("dbo.Urunlers", "KategoriID");
            AddForeignKey("dbo.Urunlers", "KategoriID", "dbo.Kategoris", "kategoriID", cascadeDelete: true);
        }
    }
}

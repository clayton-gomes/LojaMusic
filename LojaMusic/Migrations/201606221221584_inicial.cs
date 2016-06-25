namespace LojaMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        CategoriaNome = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        ClienteNome = c.String(),
                        ClienteCpf = c.String(),
                        ClienteTelefone = c.String(),
                        ClienteCep = c.String(),
                        ClienteIdade = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Emprestimos",
                c => new
                    {
                        EmprestimoId = c.Int(nullable: false, identity: true),
                        DataDoEmprestimo = c.DateTime(nullable: false),
                        Cliente_ClienteId = c.Int(),
                    })
                .PrimaryKey(t => t.EmprestimoId)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId)
                .Index(t => t.Cliente_ClienteId);
            
            CreateTable(
                "dbo.ItensEmprestimo",
                c => new
                    {
                        ItemEmprestimoId = c.Int(nullable: false, identity: true),
                        PrecoUnitario = c.Double(nullable: false),
                        Instrumento_InstrumentoId = c.Int(),
                        Emprestimo_EmprestimoId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemEmprestimoId)
                .ForeignKey("dbo.Instrumentos", t => t.Instrumento_InstrumentoId)
                .ForeignKey("dbo.Emprestimos", t => t.Emprestimo_EmprestimoId)
                .Index(t => t.Instrumento_InstrumentoId)
                .Index(t => t.Emprestimo_EmprestimoId);
            
            CreateTable(
                "dbo.Instrumentos",
                c => new
                    {
                        InstrumentoId = c.Int(nullable: false, identity: true),
                        InstrumentoNome = c.String(),
                        InstrumentoPreco = c.Single(nullable: false),
                        InstrumentoCategoria_CategoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.InstrumentoId)
                .ForeignKey("dbo.Categorias", t => t.InstrumentoCategoria_CategoriaId)
                .Index(t => t.InstrumentoCategoria_CategoriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItensEmprestimo", "Emprestimo_EmprestimoId", "dbo.Emprestimos");
            DropForeignKey("dbo.ItensEmprestimo", "Instrumento_InstrumentoId", "dbo.Instrumentos");
            DropForeignKey("dbo.Instrumentos", "InstrumentoCategoria_CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.Emprestimos", "Cliente_ClienteId", "dbo.Clientes");
            DropIndex("dbo.Instrumentos", new[] { "InstrumentoCategoria_CategoriaId" });
            DropIndex("dbo.ItensEmprestimo", new[] { "Emprestimo_EmprestimoId" });
            DropIndex("dbo.ItensEmprestimo", new[] { "Instrumento_InstrumentoId" });
            DropIndex("dbo.Emprestimos", new[] { "Cliente_ClienteId" });
            DropTable("dbo.Instrumentos");
            DropTable("dbo.ItensEmprestimo");
            DropTable("dbo.Emprestimos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}

using MarcaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MarcaApi.Data
{
    public class MarcaApiContext : DbContext
    {
        public DbSet<Marca> Marcas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=marcas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>().HasData(
                new Marca { Id = 1, Nome = "Samsung", AnoFundacao = 1969, PaisOrigem = "Coreia do Sul", Setor = "Tecnologia", Slogan = "Faça o que você não pode", Website = "https://www.samsung.com/br/", Descricao = "Empresa líder no setor de tecnologia, especializada em dispositivos eletrônicos e soluções digitais." },
                new Marca { Id = 2, Nome = "Apple", AnoFundacao = 1976, PaisOrigem = "EUA", Setor = "Tecnologia", Slogan = "Think Different", Website = "https://www.apple.com/", Descricao = "Empresa líder no desenvolvimento de hardware e software inovadores." },
                new Marca { Id = 3, Nome = "Sony", AnoFundacao = 1946, PaisOrigem = "Japão", Setor = "Tecnologia", Slogan = "Make.Believe", Website = "https://www.sony.com/", Descricao = "Especializada em eletrônicos de consumo, games, entretenimento e finanças." },
                new Marca { Id = 4, Nome = "LG", AnoFundacao = 1958, PaisOrigem = "Coreia do Sul", Setor = "Tecnologia", Slogan = "Life's Good", Website = "https://www.lg.com/", Descricao = "Fornecedor global de produtos de eletrônicos de consumo, desde TVs até eletrodomésticos." },
                new Marca { Id = 5, Nome = "Microsoft", AnoFundacao = 1975, PaisOrigem = "EUA", Setor = "Tecnologia", Slogan = "Be what's next", Website = "https://www.microsoft.com/", Descricao = "Uma das maiores empresas de software do mundo, com soluções em computação e nuvem." }
            );
        }
    }
}

using KnowledgePolyDataBaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace KnowledgePolyDataBaseImplement
{
    public class KnowledgePolyDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JS88CIM\SQLEXPRESS;Initial Catalog=KnowledgePolyDatabase;Integrated Security=True;MultipleActiveResultSets=True;;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Answer> Answers { set; get; }

        public virtual DbSet<DataBaseImplement.Models.Question> Questions { set; get; }
    }
}

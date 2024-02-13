using Microsoft.EntityFrameworkCore;
using Shared.Entities;

namespace DataAccess.Context
{
    public class HaberContext : DbContext
    {
        public HaberContext(DbContextOptions<HaberContext> opt) : base(opt)
        {

        }

        DbSet<Haberler> Haberlers { get; set; }
        DbSet<Kategoriler> Kategorilers { get; set; }
        DbSet<Slaytlar> Slaytlars { get; set; }
        DbSet<Yazarlar> Yazars { get; set; }
        DbSet<Yorumlar> Yorumlars { get; set; }
    }
}

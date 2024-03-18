using BlazorToDoList.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlazorToDoList.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options): base(options) { 

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ToDoListDB;Trusted_Connection=True;MultipleActiveResultSets=true");
		}

		public DbSet<Todolist> Todolists { get; set; }
		public DbSet<Cpr> Cprs { get; set; }
	}
}

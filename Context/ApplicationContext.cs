using Microsoft.EntityFrameworkCore;
using MVCAssignment.Models;

namespace MVCAssignment.Context
{
	public class ApplicationContext:DbContext
	{
	   public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { 

		}

		public DbSet<User> Users { get; set; }
	}
}

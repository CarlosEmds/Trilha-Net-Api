using Microsoft.EntityFrameworkCore;
using TrilhaNetApi.Models;

namespace TrilhaNetApi.Context
{
	public class OrganizadorContext : DbContext
	{
		public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) 
		{ 

		}
		public DbSet<Tarefa> Tarefas { get; set; }
	}
}

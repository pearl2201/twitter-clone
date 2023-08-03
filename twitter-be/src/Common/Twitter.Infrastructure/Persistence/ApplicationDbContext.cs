using System;
using Microsoft.EntityFrameworkCore;
using Twitter.Application.Data;

namespace Twitter.Infrastructure.Persistence
{
	public class ApplicationDbContext: DbContext,IApplicationDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{
		}
	}
}


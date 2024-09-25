using EventStoreEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventStoreEF
{
    public class EventStoreDbContext<TContext> : DbContext where TContext : DbContext
    {
        public DbSet<EventLog> EventLogs { get; set; }

        public EventStoreDbContext(DbContextOptions<TContext> options) : base(options)
        {
        }
    }
}

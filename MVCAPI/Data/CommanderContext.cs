using Microsoft.EntityFrameworkCore;
using MVCAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPI.Data
{
    public class CommanderContext: DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt): base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}

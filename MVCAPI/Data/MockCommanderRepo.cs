using MVCAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, Howto = "Biol an potato", Line = "Boil Water", Platform = "Kettle & Pan" },
                new Command { Id = 2, Howto = "Cut a Bread", Line = "Get a Knife", Platform = "Knife and chopping board" },
                new Command { Id = 3, Howto = "Job apply", Line = "Get a Seek", Platform = "Seek" },
                new Command { Id = 4, Howto = "Waer a shoe", Line = "Buy from a Shop", Platform = "Shopping Mall" }
            };

            return commands;

        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, Howto = "Biol an potato", Line = "Boil Water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }

}

      

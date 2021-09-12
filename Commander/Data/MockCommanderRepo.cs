using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
            new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & pan" },
            new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knief", Platform = "knief & chopping board" },
            new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place tea bag in cup", Platform = "Kettle & cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & pan" };
        }
    }
}
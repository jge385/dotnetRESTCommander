using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="boil an egg", Line="boil water", Platform="xxxxxx"},
                new Command{Id=1, HowTo="boil an aaa", Line="boil aaaa", Platform="yyyyy"},
                new Command{Id=2, HowTo="boil an egbbbg", Line="boil bbbb", Platform="zzzzzzz"}
            };

            return commands;

        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="boil an egg", Line="boil water", Platform="xxxxxx"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
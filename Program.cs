using SDLab5_6.Models;

namespace SDLab5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Test Name", "Test Position", new Pass());
            var departament = new Department("Test Dep", employee);
            var Rooms = new List<Room>()
            {
                new Room("Test Room"),
                new Room("Test Room 2", employee.Pass),
                new Room("Test Room 3", employee.Pass)
            };
            foreach(var room in Rooms) 
            {
                employee.TryOpenRoom(room);
            }
            Console.WriteLine($"{employee.Name} Position: {employee.Position} | History Positions:");
            employee.ShowHistoryPositions();
            var testPosition2 = "Test Position 2";
            Console.WriteLine($"{employee.Name} change position to \"{testPosition2}\"");
            employee.Position = testPosition2;
            Console.WriteLine($"{employee.Name} Position: {employee.Position} | History Positions:");
            employee.ShowHistoryPositions();

        }
    }
}

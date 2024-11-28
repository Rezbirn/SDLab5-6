using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLab5_6.Models
{
    internal class Employee
    {
        public string Name { get; private set; }
        private bool _isFirstPosition = true;
        private string _position;
        public string Position {
            get
            {
                return _position;
            }
            set 
            {
                if(_isFirstPosition)
                    _isFirstPosition = false;
                else
                    HistoryPositions.Add(value);

                _position = value;
            }
        }
        public List<string> HistoryPositions { get; private set; }
        public Pass Pass { get; set; }

        public Employee(string name, string position, Pass pass, params string[] positions)
        {
            Name = name;
            Position = position;
            Pass = pass;
            HistoryPositions = new List<string>();
            if (positions != null) 
            {
                HistoryPositions.AddRange(positions);
            }
        }
        public void TryOpenRoom(Room room) 
        {
            var roomOpened = room.TryOpen(Pass);
            if (roomOpened)
                Console.WriteLine($"Welcome to room {room.Name}");
            else
                Console.WriteLine($"Closed {room.Name}");
        }
        public void ShowHistoryPositions()
        {
            Console.WriteLine(string.Join(",", HistoryPositions));
        }

    }
}

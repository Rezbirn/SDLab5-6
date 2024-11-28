using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDLab5_6.Models
{
    internal class Room
    {
        public string Name { get; private set; }
        private HashSet<string> _passToOpen;

        public Room(string name, params Pass[] passes)
        {
            Name = name;
            _passToOpen = new HashSet<string>();

            if(passes != null)
                foreach(Pass p in passes)
                    AddPass(p);
            
        }

        public void AddPass(Pass pass) 
        {
            _passToOpen.Add(pass.Id);
        }
        public void RemovePass(Pass pass) 
        {
            _passToOpen.Remove(pass.Id);
        }
        public bool TryOpen(Pass pass)
        {
            return _passToOpen.TryGetValue(pass.Id, out _);
        }
    }
}

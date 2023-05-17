using System;

namespace SharedElements.Models
{
    public class Role
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

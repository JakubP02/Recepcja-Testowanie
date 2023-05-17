using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedElements.Models
{
    public class Office
    {
        public int? Id { get; private set; }
        public string Number { get; private set; }
        public Specialization Specialization { get; private set; }
        public bool IsActive { get; private set; }
        public bool IsGeneral { get; private set; }

        public Office(int? id, string number,Specialization specialization, bool isActive, bool isGeneral) 
        {
            Id = id;
            Number = number;
            Specialization = specialization;
            IsActive = isActive;
            IsGeneral = isGeneral;
        }

        public override string ToString()
        {
            return "Office number: " + Number;
        }
    }
}

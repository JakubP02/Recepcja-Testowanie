using SharedElements.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedElements.Interfaces
{
    internal interface ISpecializationService
    {
        public List<Specialization> GetAllSpecializations();
        public Specialization GetSpecializationById(int specializationId);
        public void AddSpecialization(string specializationName);
        public void UpdateSpecialization(Specialization specialization);
        public void DeleteSpecialization(int specializationId);
    }
}

using SharedElements.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharedElements.Helpers
{
    public static class OfficeHelpers
    {
        public static bool validateOfficeData(string number, Specialization spec)
        {
            Regex regex = new Regex(@"[0-9]");
            Match match = regex.Match(number);
            if (!match.Success)
            {
                throw new Exception("Number of office must contain only numbers");
            }
            if(spec == null)
            {
                throw new Exception("Specialization can't be empty");
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAssignmentTwo
{
    public class Checks
    {
        public static bool checkEmpty(string val)
        {
            return val != null && val.Length == 0;
        }

        public static bool checkNumber(string val)
        {
            try
            {
                int.Parse(val.Trim());
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }
    }
}

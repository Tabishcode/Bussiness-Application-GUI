using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.BL
{
    class CommonBL
    {
        public static int isValidInteger(string InputString)
        {
            bool isConversionSuccesful = int.TryParse(InputString, out int integerOutput);
            if (isConversionSuccesful && integerOutput > 0)
            {
                return integerOutput;
            }
            else
            {
                return 0;
            }
        }
    }
}

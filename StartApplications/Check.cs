using System;
using System.Collections.Generic;
using System.Text;

namespace StartApplications
{
    class Check
    {


        /**
         * CHECK IF EITHER ENDS OR NOT...
         */
        public static bool EndsWith(string _str)
        {
            foreach(string _extension in Extensions.ExtensionList) {
                if(_str.EndsWith(_extension)) {
                    return true;
                }
            }

            return false;
        }

    }
}

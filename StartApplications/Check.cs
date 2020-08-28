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
        public static bool Contains(string _str)
        {

            foreach(string _extension in Extensions.ExtensionList) {
                
                if(_str.Contains(_extension)) {
                    return true;
                }
            }

            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StartApplications
{
    class Settings
    {

        static string m_URL = @"C:\Users\"+Environment.UserName+ @"\Documents\LauncherScript\Config";
        static string m_FILENAME = @"loader.txt";

        public static string URL
        {

            get => m_URL;
        
        }

        public static string FILENAME
        {

            get => m_FILENAME;

        }

        public static string FILE
        {

            get => m_URL + "\\" + m_FILENAME;
        
        }


    }
}

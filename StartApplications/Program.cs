using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace StartApplications
{
    class Program
    {

        static ArrayList _list;

        static void Main(string[] args)
        {
            _list = new ArrayList();

            Start();
        }

        public static void Start()
        {

            bool _firstLaunch = false;

            // If file not exists, activate first launch...
            if(!File.Exists(Settings.FILE)) {
                _firstLaunch = true;
            }



            // WriteDefaultFile class is used to create file
            // and write the default setup...
            WriteDefaultFile _defaultFile = new WriteDefaultFile(Settings.FILE);
            


            // Write default setup in file if not exists...
            _defaultFile.Write();



            // LoadFile class is used to load the setup...
            LoadFile _file = new LoadFile(Settings.FILE);

            // If loader.txt doesnt contains any inserted
            // directory or application, do nothing...
            if(_file.Applications.Count > 0) {

                /**
                 * OPEN APPLICATIONS...
                 */
                foreach(string _str in _file.Applications) {
                    Console.WriteLine(_str);

                    // Launch application only...
                    if(Check.Contains(_str)) {
                        Process.Start(_str);
                    }
                }

            }

            if(_file.Directories.Count > 0) {

                /**
                 * OPEN DIRECTORIES...
                 */
                foreach(string _str in _file.Directories) {

                    // OPEN FOLDERS ONLY...
                    if(!Check.Contains(_str)) {
                        Process.Start("explorer.exe", _str);
                    }
                }
            }

            Console.ReadLine();
            // If first launch was activate...
            if(_firstLaunch) {
                Console.Write("\n\n"+
                    "This is an automatic message and this message appears only\n"+
                    "in first launch.\n\n"+
                    "loader.txt can be located at 'C:\\Users\\"+Environment.UserName+"\\Documents\\LauncherScript\\Config'\n\n" +
                    "To close this window hit Enter 3 times...");


                Console.ReadLine();
                Console.ReadLine();
                Console.ReadLine();
            }
        }

    }
}

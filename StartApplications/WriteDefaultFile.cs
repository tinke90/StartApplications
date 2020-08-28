using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace StartApplications
{
    class WriteDefaultFile
    {
        string m_file;

        public WriteDefaultFile(string _file)
        {

            this.m_file = _file;

        }

        // Default loader.txt file text...
        string[] m_defaultText = { "########################################################", "# DO NOT EDIT THIS AREA", "#",
        "# This text will not be processed...", "#", "# If you like to open directories",
        "# COPY DIRECTORY FULL PATH INSIDE THE {DIRECTORY}",
        "# or applications easily and automatically", "#", "# EACH PATH OR APPLICATION TO NEW LINE!!!",
        "#", "# Directory full path inside the DIRECTORY { }",
        "#", "# Application full path and filename inside APPLICATION { }",
        "# FOR EXAMPLE:", "# C:\\Users", "# D:\\", "# E:\\", "#", "#", "# Any issue with automatic script take contact",
        "# fintoy.flr@gmail.com", "#", "########################################################",
        "\n\n", "DIRECTORY", "{", "\n", "}", "\n\n", "APPLICATION", "{", "\n", "}"};


        // Create and write file...
        public void Write()
        {


            // If directory not exists, create one...
            if(!Directory.Exists(Settings.URL)) {
                Directory.CreateDirectory(Settings.URL);
                Console.WriteLine("Folder {0} created",Settings.URL);
            }

            // If file not exists, create and write
            // default setup...
            if(!File.Exists(Settings.FILE)) {


                var _file = File.Create(Settings.FILE);
                Console.WriteLine("File {0} create", Settings.FILE);
                _file.Close();
                Console.WriteLine("File closed...");

                // Write file...
                using(StreamWriter _write = new StreamWriter(m_file)) {

                    for(int i = 0; i < m_defaultText.Length; i++) {
                        _write.WriteLine(m_defaultText[i]);
                    }

                    Console.WriteLine("File written...");
                }
            }
        }

    }
}

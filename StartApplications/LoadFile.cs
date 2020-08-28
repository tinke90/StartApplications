using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StartApplications
{
    class LoadFile
    {

        string m_directory = "DIRECTORY";
        string m_app = "APPLICATION";

        static string m_FILE;

        public LoadFile(string _FILE)
        {

            m_FILE = _FILE;

        }

        public ArrayList Directories
        {

            get => GetDirectories();

        }

        public ArrayList Applications
        {

            get => GetApplications();


        }

        // Collect listed directories...
        private ArrayList GetDirectories()
        {

            string _text = null;

            // Read file...
            using(var _reader = new StreamReader(m_FILE, Encoding.UTF8)) {
                _text = _reader.ReadToEnd();
            }

            return StoreDirectories(_text);
            
        }

        // Collect directories...
        private ArrayList StoreDirectories(string _string)
        {

            ArrayList _list = new ArrayList();

            string[] _tmp = _string.Split('\n');

            for(int i = 0; i < _tmp.Length; i++) {


                // Collect all the lines that doesnt start with #
                if(!_tmp[i].StartsWith("#")) {

                    // If line start with DIRECTORY
                    if(_tmp[i].StartsWith(m_directory)) {

                        int _index = i;

                        // Collect all the data that is set inside { }
                        if(_tmp[_index += 1].StartsWith("{")) {

                            _index += 1;

                            while(true) {
                                
                                if(_tmp[_index].StartsWith("}")) {

                                    break;

                                } else {

                                    if(!string.IsNullOrEmpty(_tmp[_index].Trim())) {

                                        // Store data to the arraylist and return the list...
                                        _list.Add(_tmp[_index]);
                                    }

                                }

                                _index++;
                            }

                            break;

                        }

                    }

                }

            }

            return _list;

        }


        // Collect listed applications...
        private ArrayList GetApplications()
        {

            string _text = null;

            using(var _reader = new StreamReader(m_FILE, Encoding.UTF8)) {
                _text = _reader.ReadToEnd();
            }

            return StoreApplications(_text);

        }


        // Collect applications...
        private ArrayList StoreApplications(string _string)
        {

            ArrayList _list = new ArrayList();

            string[] _tmp = _string.Split('\n');


            // Collect all the lines that doesnt start with #
            for(int i = 0; i < _tmp.Length; i++) {

                if(!_tmp[i].StartsWith("#")) {

                    // If line start with APPLICATION
                    if(_tmp[i].StartsWith(m_app)) {

                        int _index = i;

                        // Collect all the data that is set inside { }
                        if(_tmp[_index += 1].StartsWith("{")) {

                            _index += 1;

                            while(true) {

                                if(_tmp[_index].StartsWith("}")) {

                                    break;

                                } else {

                                    if(!string.IsNullOrEmpty(_tmp[_index].Trim())) {

                                        // Store data to the arraylist and return the list...
                                        _list.Add(_tmp[_index]);
                                    }
                                }

                                _index++;
                            }

                            break;

                        }

                    }

                }

            }

            return _list;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StartApplications
{
    class Extensions
    {

        // Most common file extension...
        static string[] m_extensions = { ".aif", ".cda", ".mid", ".mp3", ".mpa", ".ogg", ".wav",
        ".wma", ".wpl", ".7z", ".arj", ".deb", ".pkg", ".rar", ".rpm", ".tar.gz", ".z", ".zip",
        ".bin", ".dmg", ".iso", ".toast", ".vcd", ".csv", ".dat", ".db", ".dbf", ".log", ".mdb",
        ".sav", ".sql", ".tar", ".xml", ".email", ".eml", ".emlx", ".msg", ".oft", ".ost", ".pst",
        ".vcf", ".apk", ".bat", ".bin", ".cgi", ".pl", ".com", ".exe", ".gadget", ".jar", ".msi",
        ".py", ".wsf", ".fnt", ".fon", ".otf", ".ttf", ".ai", ".gif", ".ico", ".jpeg", ".jpg",
        ".png", ".ps", ".psd", ".svg", ".tif", ".tiff", ".asp", ".aspx", ".cer", ".cfm", ".cgi", ".css",
        ".htm",".html", ".js", ".jsp", ".part", ".php", ".py", ".rss", ".xhtml", ".key", ".odp", ".pps",
        ".ppt",".pptx",".c",".class",".cpp",".cs",".h",".java",".pl",".sh",".swift",".vb",".ods",".xls",
        ".xlsm", ".xlsx", ".bak", ".cab", ".cfg", ".cpl", ".cur", ".dll", ".dmp", ".drv", ".icns", ".ico",
        ".ini", ".lnk", ".msi",".sys",".tmp",".3g2",".3gp",".avi",".flv",".h264",".m4v",".mkv",".mov",".mp4",
        ".mpg",".rm",".swf",".vob",".wmv",".doc",".docx",".odt",".pdf", ".rtf",".tex",".txt",".wpd" };




        public static string[] ExtensionList
        {
            get => m_extensions;
        }

    }
}

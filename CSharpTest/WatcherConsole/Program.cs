using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WatcherConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher incoming = new FileSystemWatcher();

            incoming.Path = @"C:\DreamSoft";
            incoming.NotifyFilter = NotifyFilters.LastAccess |
                                    NotifyFilters.LastWrite |
                                    NotifyFilters.FileName |
                                    NotifyFilters.DirectoryName;
            incoming.Filter = "*.*";

            incoming.Changed += Incoming_Changed;

            incoming.EnableRaisingEvents = true;

            Console.WriteLine("Press \'q\' to quit.");
            while (Console.Read() != 'q') ;

        }

        private static void Incoming_Changed(object sender, FileSystemEventArgs e)
        {
            // Edited in GitHub 2016-04-27 
            Console.WriteLine("{0} : Changed", e.FullPath);
        }
    }
}

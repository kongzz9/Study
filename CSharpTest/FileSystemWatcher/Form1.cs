using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileSystemWatcherTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
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

        }

        private void Incoming_Changed(object sender, FileSystemEventArgs e)
        {
            richTextBox1.Text += string.Format("{0} : Changed", e.FullPath) + Environment.NewLine;          
        }
    }
}

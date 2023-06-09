using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUnzip
{
    public partial class Form1 : Form
    {
        
        public Form1(string[] args)
        {
            InitializeComponent();


            if (args.Length > 0)
            {

                // Do something magical...

                for (int i = 0; i < args.Length; i++)
                {

                    System.Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);

                }

            }

            zip_uncompress(args[1]);


        }
        public void zip_uncompress(string fileName)
        {
            //ZipFile zip = new ZipFile();
            string zipFileName = fileName;
            //ZipFile zip = ZipFile.Read(zipFileName);

            //string outputDirectory = @"C:\Users\bests\desktop\chp02_forces_test";
            string outputDirectory = Path.GetFileNameWithoutExtension(fileName);

            Directory.CreateDirectory(outputDirectory);
            
            //zip.ExtractProgress += zip_ExtractProgress;
            using (ZipFile zip = ZipFile.Read(zipFileName))
            {
                zip.ExtractProgress += zip_ExtractProgress;
                zip.ExtractAll(outputDirectory,
                       ExtractExistingFileAction.OverwriteSilently);
                Console.WriteLine("DONE");
            }

        }
        public void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Extracting_AfterExtractEntry)
            {
                progressBar1.Maximum = (int)e.EntriesTotal;
                Console.WriteLine(String.Format("{0} : {1} / {2} = {3}%", e.CurrentEntry.FileName, e.EntriesExtracted, e.EntriesTotal, ((double)e.EntriesExtracted / (double)e.EntriesTotal) * 100.00));
                progressBar1.Value = (int)e.EntriesExtracted;
            }
        }
    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardEx
{
    public partial class Form1 : Form
    {
        static int pageNum = 1;
        int lastNum = 2;
        public Form1()
        {
            InitializeComponent();

            button3.Enabled = false;
            page1.Show();
            page2.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            page1.Hide();
            page2.Show();
            pageNum++;
            if (pageNum == lastNum)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = true;

            }
            if (pageNum == 1)
            {

                button1.Enabled = false;
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button5.Visible = true;
            //System.Windows.Forms.Application.Exit();

            RegistryKey rkey = Registry.ClassesRoot.CreateSubKey(@"Folder\shell\.fzip");
            Registry.SetValue(@"HKEY_CLASSES_ROOT\Folder\shell\.fzip", "", @"&FZip으로 압축하기");
            RegistryKey ekey = rkey.CreateSubKey("command");
            ekey.SetValue("", @"C:\Users\bests\Downloads\FZip-master\FZip\bin\Debug\FZip.exe %1");

            string path = @"C:\Program Files\FZip";
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch
            {
                //Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Use the Path.Combine method to safely append the file name to the path.
            // Will overwrite if the destination file already exists.
            string fName1 = "FZip.exe";
            string fName2 = "Uninstaleller.exe";
            string installDir = @"C:\Program Files\FZip";
            try
            {
                File.Copy(Path.Combine(Directory.GetCurrentDirectory(), fName1), Path.Combine(installDir, fName1), true);
                File.Copy(Path.Combine(Directory.GetCurrentDirectory(), fName2), Path.Combine(installDir, fName2), true);
            }
            catch { MessageBox.Show("error"); }
            finally {
                MessageBox.Show("설치가 완료되었습니다");
            }
        }
           

        private void button1_Click(object sender, EventArgs e)
        {
            page2.Hide();
            page1.Show();
            pageNum--;
            if (pageNum == 1)
            {

                button2.Enabled = true;
                button1.Enabled = false;
                button3.Enabled = false;
            }
        }
    }
}

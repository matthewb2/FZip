
using Ionic.Zip;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FZip
{
    public partial class Form1 : Form
    {
        string selectedFolderPath;

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

            this.listView1.Items.Clear();

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);

            
            //AddFolderIcon(ref imageList, @"C:\Users\bests\Desktop\TextBox");
            AddFolderIcon(ref imageList, args[1]);
            this.listView1.LargeImageList = imageList;
            
            //for installation
            /*
            RegistryKey rkey = Registry.ClassesRoot.CreateSubKey(@"Folder\shell\.fzip");
            Registry.SetValue(@"HKEY_CLASSES_ROOT\Folder\shell\.fzip", "", @"&FZip으로 압축하기");
            RegistryKey ekey = rkey.CreateSubKey("command");
            ekey.SetValue("", @"C:\Users\bests\Downloads\FZip-master\FZip\bin\Debug\FZip.exe %1");

            */

            List<string> list = listView1.Items.Cast<ListViewItem>()
                                 .Select(item => item.Text)
                                 .ToList();
            compress_exec(list);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ListView의 표시방법을 LrageIcon으로 설정
            this.listView1.View = View.LargeIcon;
            this.listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
              OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "파일 오픈 예제창";
            ofd.FileName = "test";
            ofd.Filter = "그림 파일 (*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp; | 모든 파일 (*.*) | *.*";
 
            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();
             
            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = ofd.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = ofd.FileName;
                //File경로만 가지고 온다.
                string filePath = fileFullName.Replace(fileName, "");


                insertList();

            }
            */
            
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                this.selectedFolderPath = fb.SelectedPath;
                AddListViewLargeImageItem(fb.SelectedPath);
            }

        }

        private void AddListViewLargeImageItem(string folderPath)
        {
            this.listView1.Items.Clear();

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);

            AddFolderIcon(ref imageList, folderPath);
            AddFileIcon(ref imageList, folderPath);

            this.listView1.LargeImageList = imageList;
        }


        /// <summary>
        /// 파일의 아이콘을 추가합니다.
        /// </summary>
        /// <param name="imageList"></param>
        /// <param name="folderPath"></param>
        private void AddFileIcon(ref ImageList imageList, string folderPath)
        {
            string[] files = System.IO.Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                //아이콘 추가
                Icon icon = Etier.IconHelper.IconReader.GetFileIcon(file, Etier.IconHelper.IconReader.IconSize.Large, false);
                imageList.Images.Add(icon);

                this.listView1.Items.Add(System.IO.Path.GetFileName(file), imageList.Images.Count - 1);
            }
        }

        /// <summary>
        /// 폴더의 아이콘을 추가합니다.
        /// </summary>
        /// <param name="imageList"></param>
        /// <param name="folderPath"></param>
        private void AddFolderIcon(ref ImageList imageList, string folderPath)
        {
            
                //아이콘 추가
                Icon icon = Etier.IconHelper.IconReader.GetFolderIcon(Etier.IconHelper.IconReader.IconSize.Large, Etier.IconHelper.IconReader.FolderType.Open);
                imageList.Images.Add(icon);

                this.listView1.Items.Add(folderPath, imageList.Images.Count-1);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> list = listView1.Items.Cast<ListViewItem>()
                                 .Select(item => item.Text)
                                 .ToList();
            compress_exec(list);

            
        }
        public void compress_exec(List<string> list)
        {
            try
            {
                foreach (var item in list)
                {
                    using (ZipFile zip = new ZipFile())
                    {
                        zip.UseUnicodeAsNecessary = true;  // utf-8
                        zip.AddDirectory(item);
                        zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");
                        zip.Save(item + ".zip");
                        Console.WriteLine("success");
                    }
                }
            }
            catch
            {
                MessageBox.Show("압축 실패");
                return;
            }

            MessageBox.Show("압축이 완료되었습니다");
        }

        private string GetCleanFolderName(string source, string filepath)
        {
            if (string.IsNullOrWhiteSpace(filepath))
            {
                return string.Empty;
            }

            var result = filepath.Substring(source.Length);

            if (result.StartsWith("\\"))
            {
                result = result.Substring(1);
            }

            result = result.Substring(0, result.Length - new FileInfo(filepath).Name.Length);

            return result;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

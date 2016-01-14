using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace newArchive
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        public void create_archive_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog choseFile = new OpenFileDialog();
            if (choseFile.ShowDialog() == DialogResult.OK)
            {
                string startfile = choseFile.FileName;
                string zipPath;
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "zip files (*.zip)|*.zip|rar files (*.rar)|*.rar";
                // saveFileDialog1.FilterIndex = 2;
                saveFile.RestoreDirectory = true;


                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileNameWithoutExtension(saveFile.FileName);
                    string directoryFile = Path.GetDirectoryName(saveFile.FileName);
                    string typeFile = Path.GetExtension(saveFile.FileName);
                    zipPath = Path.Combine(directoryFile, fileName + typeFile);
                    create_to_archive(startfile, zipPath);

                }
            }*/
        }

        }
    }

    

        /*  public void create_to_archive()
          {
              //FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
             // if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
             // {
                //string startPath = folderBrowserDialog1.SelectedPath;
              string zipPath;
                  SaveFileDialog saveFile = new SaveFileDialog();
                  saveFile.Filter = "zip files (*.zip)|*.zip|rar files (*.rar)|*.rar";
                 // saveFileDialog1.FilterIndex = 2;
                  saveFile.RestoreDirectory = true;


                  if (saveFile.ShowDialog() == DialogResult.OK)
                  {
                      string fileName = Path.GetFileNameWithoutExtension(saveFile.FileName);
                      string directoryFile = Path.GetDirectoryName(saveFile.FileName);
                      string typeFile = Path.GetExtension(saveFile.FileName);
                      zipPath = Path.Combine(directoryFile, fileName + typeFile);
                    
                   //   ZipFile.CreateFromDirectory(startPath, zipPath);

         *
                  }*/
  
           

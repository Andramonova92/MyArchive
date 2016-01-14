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
    public partial class proba : Form
    {
        public proba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string file = "D:\\1.txt"; //  переменная которой присвоен путь к файлу для архивации
            string rar= "D:\\1.rar"; //переменная которой присвоено путь к файлу архива
          
           
            FileInfo f = new FileInfo(file);  
            FileInfo r = new FileInfo(rar); // создаем экземпляр класса FileInfo для использования в потоке filerar
           
            using (FileStream rarStream = r.Create()) // создали поток в котором создаем файл архива
            {
              
               
             File.SetAttributes(rar, FileAttributes.Archive); //задали атрибут файла Archive
              
                using (FileStream fileStream = f.Open(FileMode.Open)) //создали(открыли) поток в котором открываем файл для чтения
                {
                    fileStream.CopyTo(rarStream); // считывание потока fileStream и запись данных в rarStream
                    r.Refresh(); // обновление файла архива
                }
            }
        }
    }
}

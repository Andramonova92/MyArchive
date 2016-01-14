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

            string file = "D:\\1.txt"; // файл для архивации
            string rar = "D:\\1.rar"; //файл архива
          //  FileInfo f = new FileInfo(file);  
            FileInfo r = new FileInfo(rar); // создаем экземпляр класса FileInfo для использования в потоке filerar
            FileStream filerar = null; 
            try
            {
                byte[] array = File.ReadAllBytes(file); // в масив байтов считываем все байты файла для архива
                MemoryStream memory = new MemoryStream(array); // создаем обьект MemoryStream в который помещаем масив байтов
                 filerar = r.Create(); // создаем файл архива
                
                    memory.CopyTo(filerar); // копируем сорержимое мемори в поток
                
            }
            catch
            {

                MessageBox.Show("ошибка архивации");

            }
            finally {
                if (r!= null) // если файл не пустой
                    filerar.Close(); // закрываем поток
            }
        }
    }
}

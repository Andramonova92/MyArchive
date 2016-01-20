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
using System.Runtime.Serialization.Formatters.Binary;

namespace ArchiveProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void create_archive_Click(object sender, EventArgs e)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = "D:\\";
            watcher.Filter = "*txt";
            watcher.EnableRaisingEvents = true;
            List <object> files = new List<object>{"1.txt", "2.txt"};
           
            string rar = "D:\\rar";
            FileInfo r = new FileInfo(rar); // создаем экземпляр класса FileInfo для использования в потоке filerar
            //FileInfo f = new FileInfo();
            FileStream filerar = null;
            try
            {
              // byte[] array = files.SelectMany(s => s.ToString())
               //.Select(Convert.ToByte)
              // .ToArray(); // в масив байтов считываем все байты файла для архива

                MemoryStream memory = new MemoryStream(); // создаем обьект MemoryStream в который помещаем масив байтов
                filerar = r.Create(); // создаем файл архива
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(memory, files);
                memory.WriteTo(filerar); // копируем сорержимое мемори в поток

            }
            catch
            {

                MessageBox.Show("ошибка архивации");

            }
            finally
            {
                if (rar != null) // если файл не пустой
                    filerar.Close(); // закрываем поток
            }
        }
    }
}

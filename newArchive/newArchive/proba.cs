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

            string file = "D:\\1.txt";
            string rar = "D:\\1.rar";
            FileInfo f = new FileInfo(file);
            FileInfo r = new FileInfo(rar);
            FileStream filerar = null;
            try
            {
                byte[] array = File.ReadAllBytes(file);
                MemoryStream memory = new MemoryStream(array);
                 filerar = r.Create();
                
                    memory.CopyTo(filerar);
                
            }
            catch
            {

                MessageBox.Show("ошибка архивации");

            }
            finally {
                if (r!= null)
                    filerar.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKimlikNoDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkontrolet_Click(object sender, EventArgs e)
        {
            TcKimlikNoDogrulama.KPSPublic kps = new TcKimlikNoDogrulama.KPSPublic();

            try
            {
                bool kontrol = kps.TCKimlikNoDogrula(long.Parse(txtTcKimlik.Text), txtisim.Text.ToUpper(), txtsoyisim.Text.ToUpper(), int.Parse(txtdoğumyili.Text));
            }
            catch
            {
                MessageBox.Show("Bilgileriniz Doğrulandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (true)
                {
                    MessageBox.Show("Bilgileriniz Doğrulanamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        

          
            





        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace giris
{
    public partial class kullanici : DevExpress.XtraEditors.XtraForm
    {
        public kullanici()
        {
            InitializeComponent();
        }

        private void btnGrs_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "admin" && txtSfre.Text == "123")
            {
                txtSonuc.Text = "Giriş işlemi başarılı";
                islem yeniform = new islem();
                yeniform.Show();
                this.Hide();
            }
            else if (txtKadi.Text != "admin")
            {
                txtSonuc.Text = "Kullanıcı Adı Hatalı";
            }
            else if (txtSfre.Text != "123")
            {
                txtSonuc.Text = "Kullanıcı Şifresi Hatalı";
            }          
        }

        private void btnKpt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


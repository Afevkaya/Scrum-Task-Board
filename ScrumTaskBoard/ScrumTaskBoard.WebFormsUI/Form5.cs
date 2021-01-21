using ScrumTaskBoard.Business.Abstarct;
using ScrumTaskBoard.Business.Concrete;
using ScrumTaskBoard.Entities.Concrete;
using ScrumTaskBorad.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumTaskBoard.WebFormsUI
{
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        private static Form5 _instance;
        public static Form5 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form5();
                return _instance;
            }
        }
        public Form5()
        {
            InitializeComponent();
            _isTakipService = new IsTakipManager(new EfIsTakipDal());
            _kartService = new KartManager(new EfKartDal());
        }
   

        private void LoadKart()
        {
            mgrdKartlar.DataSource = _kartService.GetAll();
        }

        private void LoadIsTakip()
        {
            mgrdGuncelle.DataSource = _isTakipService.GetIsTakipByKart(Convert.ToInt32(mgrdKartlar.CurrentRow.Cells[0].Value));
        }

        private bool Kontrol()
        {
            if(mgrdKartlar.CurrentRow == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Kontrol2()
        {
            if (mgrdGuncelle.CurrentRow == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void UyarıMesajı()
        {
            MessageBox.Show("Mevcutta bir kartınız bulunmamaktadır");
        }
        private static void UyarıMesajı2()
        {
            MessageBox.Show("Mevcutta bir kartınıza ait iş takip bulunmamaktadır");
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        IIsTakipService _isTakipService;
        IKartService _kartService;
        private void Form5_Load(object sender, EventArgs e)
        {
            LoadKart();
            var kontrol = Kontrol();
            if (kontrol)
            {
                UyarıMesajı();
                mgrdKartlar.Enabled = false;
            }
            
            pnlGuncelle.Enabled = false;
        }

        private void mgrdKartlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadIsTakip();
            var kontrol2 = Kontrol2();
            if (kontrol2)
            {
                UyarıMesajı2();
                mgrdGuncelle.Enabled = false;
            }
            else
            {
                mgrdGuncelle.Enabled = true;
            }
            pnlGuncelle.Enabled = false;
        }

        private void mgrdGuncelle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxAciklamaGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[2].Value.ToString();
            pnlGuncelle.Enabled = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Kontrol();
            var kontrol2 = Kontrol2();
            if (!kontrol2)
            {
                try
                {
                    _isTakipService.Update(new IsTakip
                    {
                        IsTakipId = Convert.ToInt32(mgrdGuncelle.CurrentRow.Cells[0].Value),
                        KartId = Convert.ToInt32(mgrdKartlar.CurrentRow.Cells[0].Value),
                        IsTakipAciklama = tbxAciklamaGuncelle.Text
                    });
                    MessageBox.Show("İş Takip Güncellendi");
                    mgrdGuncelle.DataSource = _isTakipService.GetAll();
                    pnlGuncelle.Enabled = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
            else
            {
                UyarıMesajı();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var kontrol2 = Kontrol2();
            if (!kontrol2)
            {
                _isTakipService.Delete(new IsTakip
                {
                    IsTakipId = Convert.ToInt32(mgrdGuncelle.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("İş Takip Silindi");
                LoadIsTakip();
            }
            else
            {
                UyarıMesajı();
                mbtnSil.Enabled = false;
            }
            MessageBox.Show("İş Takip Silinemedi");
            LoadIsTakip();
            pnlGuncelle.Enabled = false;

        }

     
    }
}

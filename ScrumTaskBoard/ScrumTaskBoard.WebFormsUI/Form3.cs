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
   
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        private static Form3 _instance;
        public static Form3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form3();
                return _instance;
            }
        }
      
        public Form3()
        {
            InitializeComponent();
            _kartService = new KartManager(new EfKartDal());
            _isTakipService = new IsTakipManager(new EfIsTakipDal());
        }

        private void LoadKart()
        {
            mcbxKartlar.DataSource = _kartService.GetAll();
            mcbxKartlar.DisplayMember = "ProjeNoAd";
            mcbxKartlar.ValueMember = "KartId";
        }

        private void Temizle()
        {
            mcbxKartlar.ResetText();
            tbxIsTakip.Clear();
        }

        private bool Kontrol()
        {
            if(mcbxKartlar.Items.Count == 0)
            {
                return true;
            }
            return false;
        }

        private IKartService _kartService;
        private IIsTakipService _isTakipService;

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            LoadKart();
            bool kontrol = Kontrol();
            if (kontrol)
            {
                MessageBox.Show("Lütfen Önce Kart Ekleyin");
                mcbxKartlar.Enabled = false;
                mlblKartlar.Enabled = false;
            }
            mpnIsTakip.Enabled = false;
        }

        private void mcbxKartlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            mpnIsTakip.Enabled = true;
        }

        public void mbtnEkle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İŞ TAKİP EKLEMEK İSTEDİĞNİZE EMİN MİSİNİZ?", "UYARI ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    _isTakipService.Add(new IsTakip
                    {
                        KartId = Convert.ToInt32(mcbxKartlar.SelectedValue),
                        IsTakipAciklama = Control.FazlaBoşluklarıSil(tbxIsTakip.Text)  
                    });
                    MessageBox.Show("İş Takip Eklendi");
                    mpnIsTakip.Enabled = false;
                    Temizle();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }

            else
            {
                MessageBox.Show("İş Takip Eklenememiştir!");
                mpnIsTakip.Enabled = false;
                Temizle();
            }

           

        }
      

    }
}

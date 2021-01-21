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
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        private static Form4 _instance;
        public static Form4 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form4();
                return _instance;
            }
        }
        public Form4()
        {
            InitializeComponent();
            _kartService = new KartManager(new EfKartDal());
            _teknikUzmanService = new TeknikUzmanManager(new EfTeknikUzmanDal());
            _yapilacakServis = new YapilacakManager();
            _yapilanServis = new YapilanManager();
            _yapilmisServis = new YapilmisManager();
            _isTakipService = new IsTakipManager(new EfIsTakipDal());
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private IKartService _kartService;
        private ITeknikUzmanServis _teknikUzmanService;
        private IYapilacakServis _yapilacakServis;
        private IYapilanServis _yapilanServis;
        private IYapilmisServis _yapilmisServis;
        private IIsTakipService _isTakipService;

        private void LoadTeknikUzman()
        {
            mcbxTeknikUzmanGuncelle.DataSource = _teknikUzmanService.GetAll();
            mcbxTeknikUzmanGuncelle.DisplayMember = "TeknikUzmanAd";
            mcbxTeknikUzmanGuncelle.ValueMember = "TeknikUzmanId";
        }

        private bool Kontrol()
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

        private void Kontrol2()
        {
            bool kontrol = Kontrol();
            if (kontrol)
            {
                mgrdGuncelle.Enabled = false;
                pnlGuncelle.Enabled = false;
            }
            else
            {
                LoadTeknikUzman();
            }
        }

        private void Temizle()
        {
            mtbxKartNoGuncelle.Clear();
            mdtmTarihGuncelle.ResetText();
            mtbxProjeNoAdGuncelle.Clear();
            mcbxTahminiSureGuncelle.ResetText();
            mcbxTeknikUzmanGuncelle.ResetText();
            mtbxGerceklesenSureGuncelle.Clear();
            tbxIsAciklamaGuncelle.Clear();
            tbxNotlarGuncelle.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Temizle();
            mgrdGuncelle.DataSource = _kartService.GetAll();
            mgrdGuncelle.DataSource = _kartService.GetAll();
            Kontrol2();
            pnlGuncelle.Enabled = false;
            mtbxKartNoGuncelle.Enabled = false;
        }

        private void dgwKartGuncelle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kontrol2();
            pnlGuncelle.Enabled = true;
            mcbxTahminiSureGuncelle.Enabled = false;
            if(mgrdGuncelle.CurrentRow != null)
            {
                mcbxTeknikUzmanGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[1].Value.ToString();
                mdtmTarihGuncelle.Value = Convert.ToDateTime(mgrdGuncelle.CurrentRow.Cells[2].Value);
                mtbxKartNoGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[3].Value.ToString();
                mtbxProjeNoAdGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[4].Value.ToString();
                mcbxTahminiSureGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[5].Value.ToString();
                mtbxGerceklesenSureGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[6].Value.ToString();
                tbxIsAciklamaGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[7].Value.ToString();
                tbxNotlarGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void mcbxTeknikUzmanGuncelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mcbxTahminiSureGuncelle.DataSource = _teknikUzmanService.GetSureByTeknikUzman(Convert.ToInt32(mcbxTeknikUzmanGuncelle.SelectedValue)).ToList();
                mcbxTahminiSureGuncelle.DisplayMember = "Sure";
                mcbxTahminiSureGuncelle.ValueMember = "Sure";
            }
            catch
            {

            }
        }

        private void mgrdGuncelle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Kontrol2();
            pnlGuncelle.Enabled = true;
            mcbxTahminiSureGuncelle.Enabled = false;
            if (mgrdGuncelle.CurrentRow != null)
            {
                mcbxTeknikUzmanGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[1].Value.ToString();
                mdtmTarihGuncelle.Value = Convert.ToDateTime(mgrdGuncelle.CurrentRow.Cells[2].Value);
                mtbxKartNoGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[3].Value.ToString();
                mtbxProjeNoAdGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[4].Value.ToString();
                mcbxTahminiSureGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[5].Value.ToString();
                mtbxGerceklesenSureGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[6].Value.ToString();
                tbxIsAciklamaGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[7].Value.ToString();
                tbxNotlarGuncelle.Text = mgrdGuncelle.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void mbtnGuncelle_Click(object sender, EventArgs e)
        {
            bool kontrol = Kontrol();
            if (MessageBox.Show("KARTI GÜNCELLEMEK İSTEDİĞİNİZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (!kontrol)
                {
                    try
                    {
                        _kartService.Update(new Kart
                        {
                            KartId = Convert.ToInt32(mgrdGuncelle.CurrentRow.Cells[0].Value),
                            TeknikUzmanId = Convert.ToInt32(mcbxTeknikUzmanGuncelle.SelectedValue),
                            Tarih = Convert.ToDateTime(mdtmTarihGuncelle.Value),
                            KartNo = Convert.ToInt32(mtbxKartNoGuncelle.Text),
                            ProjeNoAd = mtbxProjeNoAdGuncelle.Text,
                            TahminiSure = Convert.ToInt32(mcbxTahminiSureGuncelle.SelectedValue),
                            GerceklesenSure = Convert.ToInt32(mtbxGerceklesenSureGuncelle.Text),
                            IsinAciklamasi = tbxIsAciklamaGuncelle.Text,
                            Notlar = tbxNotlarGuncelle.Text
                        });
                        MessageBox.Show("Kart Güncellendi");
                        mgrdGuncelle.DataSource = _kartService.GetAll();
                        Temizle();
                        pnlGuncelle.Enabled = false;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kart Güncellenemedi");
                Temizle();
                pnlGuncelle.Enabled = false;
            }
        }

        private void mbtnSil_Click(object sender, EventArgs e)
        {

            bool kontrol = Kontrol();
            if (MessageBox.Show("KARTI SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (!kontrol)
                {
                    _kartService.Delete(new Kart
                    {
                        KartId = Convert.ToInt32(mgrdGuncelle.CurrentRow.Cells[0].Value)
                    });
                 

                    _yapilacakServis.Delete("Delete From Yapilacaklar where KartId = '" + mgrdGuncelle.CurrentRow.Cells[3].Value + "'");
                    _yapilanServis.Delete("Delete From Yapilanlar where KartId = '" + mgrdGuncelle.CurrentRow.Cells[3].Value + "'");
                    _yapilmisServis.Delete("Delete From Yapilmislar where KartId = '" + mgrdGuncelle.CurrentRow.Cells[3].Value + "'");
                    mgrdGuncelle.DataSource = _kartService.GetAll();
                    Temizle();
                    pnlGuncelle.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Kart Silinemedi");
                Temizle();
                pnlGuncelle.Enabled = false;
            }
        }
    }
    
}

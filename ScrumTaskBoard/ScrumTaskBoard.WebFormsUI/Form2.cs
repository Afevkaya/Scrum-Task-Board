using ScrumTaskBoard.Business.Abstarct;
using ScrumTaskBoard.Business.Concrete;
using ScrumTaskBoard.Business.DTO;
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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        private static Form2 _instance;
        public static Form2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form2();
                return _instance;
            }
        }

        public Form2()
        {
            InitializeComponent();
            _kartService = new KartManager(new EfKartDal());
            _teknikUzmanService = new TeknikUzmanManager(new EfTeknikUzmanDal());
            _yapilacalServis = new YapilacakManager();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        private IKartService _kartService;
        private ITeknikUzmanServis _teknikUzmanService;
        private IYapilacakServis _yapilacalServis;

        private void Form2_Load(object sender, EventArgs e)
        {
            
            LoadTeknikUzman();
            mcbxTahminiSure.Enabled = false;
        }

        private void KartEkleme()
        {
            try
            {
                _kartService.Add(new Kart
                {
                    Tarih = Convert.ToDateTime(mdtmTarih.Value),
                    KartNo = Convert.ToInt32(mtbxKartNo.Text),
                    ProjeNoAd = Control.FazlaBoşluklarıSil(mtbxProjeNoAd.Text),
                    TeknikUzmanId = Convert.ToInt32(mcbxTeknikUzman.SelectedValue),
                    TahminiSure = Convert.ToInt32(mcbxTahminiSure.SelectedValue),
                    GerceklesenSure = Convert.ToInt32(mtbxGerceklesenSure.Text),
                    IsinAciklamasi = Control.FazlaBoşluklarıSil(tbxIsAciklama.Text),
                    Notlar = Control.FazlaBoşluklarıSil(tbxNotlar.Text)   

                });

                _yapilacalServis.Add("INSERT INTO Yapilacaklar (YapilacakKart,KartId) " +
                    "VALUES('" + mtbxKartNo.Text + " " + mtbxProjeNoAd.Text + " " + tbxIsAciklama.Text + " " + tbxNotlar.Text + "', '" + Convert.ToInt32(mtbxKartNo.Text) + "')");

                MessageBox.Show("Kart Eklendi!");
                Temizle();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoadTeknikUzman()
        {
            mcbxTeknikUzman.DataSource = _teknikUzmanService.GetAll();
            mcbxTeknikUzman.DisplayMember = "TeknikUzmanAd";
            mcbxTeknikUzman.ValueMember = "TeknikUzmanId";
        }

        private void Temizle()
        {
            mdtmTarih.ResetText();
            mtbxKartNo.Clear();
            mcbxTeknikUzman.Text = "";
            mcbxTahminiSure.Text = "";
            mtbxProjeNoAd.Clear();
            mtbxGerceklesenSure.Clear();
            tbxIsAciklama.Clear();
            tbxNotlar.Clear();
        }
        private void mcbxTeknikUzman_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mcbxTahminiSure.DataSource = _teknikUzmanService.GetSureByTeknikUzman(Convert.ToInt32(mcbxTeknikUzman.SelectedValue)).ToList();
                mcbxTahminiSure.DisplayMember = "Sure";
                mcbxTahminiSure.ValueMember = "Sure";
            }
            catch
            {

            }
        }

        private void mbtnEkle_Click(object sender, EventArgs e)
        {
            List<Kart> GetAll = _kartService.GetAll();
            if (GetAll.Count == 0)
            {
                KartEkleme();
            }
            else
            {
                foreach (var gtl in GetAll)
                {
                    try
                    {
                        if (mtbxKartNo.Text == "")
                        {
                            MessageBox.Show("Sütunlar boş olamaz");
                            break;
                        }
                        else if (Convert.ToInt32(mtbxKartNo.Text) == gtl.KartNo)
                        {

                            MessageBox.Show("Lütfen Kart Numaranızı Değiştiriniz...");
                            break;
                        }
                        else
                        {
                            KartEkleme();
                            break;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                  
                }
            }


        }
    }
}

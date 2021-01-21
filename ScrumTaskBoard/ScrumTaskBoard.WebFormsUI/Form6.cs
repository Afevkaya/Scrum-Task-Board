using ScrumTaskBoard.Business.Abstarct;
using ScrumTaskBoard.Business.Concrete;
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

    public partial class Form6 : MetroFramework.Forms.MetroForm
    {

        private static Form6 _instance;
        public static Form6 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form6();
                return _instance;
            }
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        private void Temizle(ListBox listBox)
        {
            listBox.Items.Clear();   
        }

        private void YapilacaklarListele()
        {
            Temizle(ltbxYapilacaklar);
            var sonuc = _yapilacakServis.GetAll("Select * from Yapilacaklar");
            if (sonuc != null)
            {
                foreach (var yap in sonuc)
                {
                    ltbxYapilacaklar.Items.Add(yap.YapilacakKart);
                }
            }
        }

        private void YapilanlarListele()
        {
            Temizle(ltbxYapilanlar);
            var sonuc2 = _yapilanServis.GetAll("Select * from Yapilanlar");
            if (sonuc2 != null)
            {
                if (sonuc2 != null)
                {
                    foreach (var yap in sonuc2)
                    {
                        ltbxYapilanlar.Items.Add(yap.YapilanKart);
                    }
                }
            }
        }

        private void YapilmislarListele()
        {
            Temizle(ltbxYapilmislar);
            var sonuc3 = _yapilmisServis.GetAll("Select * from Yapilmislar");
            if (sonuc3 != null)
            {
                if (sonuc3 != null)
                {
                    foreach (var yap in sonuc3)
                    {
                        ltbxYapilmislar.Items.Add(yap.YapilmisKart);
                    }
                }
            }
        }

        IYapilacakServis _yapilacakServis = new YapilacakManager();
        IYapilanServis _yapilanServis = new YapilanManager();
        IYapilmisServis _yapilmisServis = new YapilmisManager();

        private void Form6_Load(object sender, EventArgs e)
        {
            YapilacaklarListele();

            YapilanlarListele();

            YapilmislarListele();

        }

        private static void Hareket(DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void Konumlandırma(object sender, MouseEventArgs e)
        {
            listbox_Item_Alinan = sender as ListBox;

            Point kor_nokta = new Point(e.X, e.Y);
            Listbox_Index = listbox_Item_Alinan.IndexFromPoint(kor_nokta);
            if (Listbox_Index == -1)
                return;
            if (e.Button == MouseButtons.Left)
                listbox_Item_Alinan.DoDragDrop(listbox_Item_Alinan.Items[Listbox_Index].ToString(), DragDropEffects.All);
        }

        private void Alma(object sender)
        {
            lstbox_Item_Birakilan = sender as ListBox;
            lstbox_Item_Birakilan.Items.Add(listbox_Item_Alinan.Items[Listbox_Index]);
            listbox_Item_Alinan.Items.Remove(listbox_Item_Alinan.Items[Listbox_Index]);
        }

        private void ltbxYapilacaklar_DragOver(object sender, DragEventArgs e)
        {
            Hareket(e);
        }

        private void ltbxYapilanlar_DragOver(object sender, DragEventArgs e)
        {
            Hareket(e);
        }

        private void ltbxYapilmislar_DragOver(object sender, DragEventArgs e)
        {
            Hareket(e);
        }

        ListBox listbox_Item_Alinan;
        ListBox lstbox_Item_Birakilan;
        int Listbox_Index = 0;

        private void ltbxYapilacaklar_MouseDown(object sender, MouseEventArgs e)
        {
            Konumlandırma(sender, e);
        }

        private void ltbxYapilanlar_MouseDown(object sender, MouseEventArgs e)
        {
            Konumlandırma(sender, e);
        }

        private void ltbxYapilmislar_MouseDown(object sender, MouseEventArgs e)
        {
            Konumlandırma(sender, e);
        }

        private void ltbxYapilacaklar_DragDrop(object sender, DragEventArgs e)
        {
            Alma(sender);
        }

        private void ltbxYapilanlar_DragDrop(object sender, DragEventArgs e)
        {
            Alma(sender);
        }

        private void ltbxYapilmislar_DragDrop(object sender, DragEventArgs e)
        {
            Alma(sender);
        }

        private static void Deneme(object lst, out string değer, out int kartId)
        {
            değer = lst.ToString();
            string[] ayırma = değer.Split(' ');
            kartId = Convert.ToInt32(ayırma[0]);
        }

        private void mbtnKaydet_Click(object sender, EventArgs e)
        {
            _yapilacakServis.Truncate("Truncate table Yapilacaklar");
            _yapilanServis.Truncate("Truncate table Yapilanlar");
            _yapilmisServis.Truncate("Truncate table Yapilmislar");
            string değer;
            int kartId;
            if (ltbxYapilacaklar != null)
            {
                foreach (var lst in ltbxYapilacaklar.Items)
                {

                    Deneme(lst, out değer, out kartId);
                    _yapilacakServis.Add("insert into Yapilacaklar (YapilacakKart,KartId) values('" + değer + "', '" + kartId + "')");
                }
            }
            YapilacaklarListele();

            if (ltbxYapilanlar != null)
            {
                foreach (var lst in ltbxYapilanlar.Items)
                {
                    Deneme(lst, out değer, out kartId);
                    _yapilacakServis.Add("insert into Yapilanlar (YapilanKart,KartId) values('" + değer + "', '" + kartId + "')");
                }
            }
            YapilanlarListele();

            if (ltbxYapilmislar != null)
            {
                foreach (var lst in ltbxYapilmislar.Items)
                {
                    Deneme(lst, out değer, out kartId);
                    _yapilacakServis.Add("insert into Yapilmislar (YapilmisKart,KartId) values('" + değer + "', '" + kartId + "')");
                }
            }
            YapilmislarListele();
        }
    }
}


namespace ScrumTaskBoard.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işTakipEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işTakipGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.metroContextMenu2 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.metroContextMenu3 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.kARTEKLEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iŞTAKİPEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu4 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.metroContextMenu5 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu6 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.eKLEMEİŞLEMERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tODOLARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu7 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.eKLEMEİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tODOLARToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.metroContextMenu3.SuspendLayout();
            this.metroContextMenu5.SuspendLayout();
            this.metroContextMenu6.SuspendLayout();
            this.metroContextMenu7.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartEkleToolStripMenuItem,
            this.işTakipEkleToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.ekleToolStripMenuItem.Text = "EKLEME İŞLEMLERİ";
            // 
            // kartEkleToolStripMenuItem
            // 
            this.kartEkleToolStripMenuItem.Name = "kartEkleToolStripMenuItem";
            this.kartEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kartEkleToolStripMenuItem.Text = "KART EKLEME";
            this.kartEkleToolStripMenuItem.Click += new System.EventHandler(this.kartEkleToolStripMenuItem_Click);
            // 
            // işTakipEkleToolStripMenuItem
            // 
            this.işTakipEkleToolStripMenuItem.Name = "işTakipEkleToolStripMenuItem";
            this.işTakipEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.işTakipEkleToolStripMenuItem.Text = "İŞ TAKİP EKLEME";
            this.işTakipEkleToolStripMenuItem.Click += new System.EventHandler(this.işTakipEkleToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.güncelleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartGüncelleToolStripMenuItem,
            this.işTakipGüncelleToolStripMenuItem});
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(193, 20);
            this.güncelleToolStripMenuItem.Text = "GÜNCELLEME - SİLME İŞLEMLERİ";
            // 
            // kartGüncelleToolStripMenuItem
            // 
            this.kartGüncelleToolStripMenuItem.Name = "kartGüncelleToolStripMenuItem";
            this.kartGüncelleToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.kartGüncelleToolStripMenuItem.Text = "KART GÜNCELLE - SİL";
            this.kartGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kartGüncelleToolStripMenuItem_Click);
            // 
            // işTakipGüncelleToolStripMenuItem
            // 
            this.işTakipGüncelleToolStripMenuItem.Name = "işTakipGüncelleToolStripMenuItem";
            this.işTakipGüncelleToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.işTakipGüncelleToolStripMenuItem.Text = "İŞ TAKİP GÜNCELLE - SİL";
            this.işTakipGüncelleToolStripMenuItem.Click += new System.EventHandler(this.işTakipGüncelleToolStripMenuItem_Click);
            // 
            // todolarToolStripMenuItem
            // 
            this.todolarToolStripMenuItem.BackColor = System.Drawing.Color.Aqua;
            this.todolarToolStripMenuItem.Name = "todolarToolStripMenuItem";
            this.todolarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.todolarToolStripMenuItem.Text = "TODOLAR";
            this.todolarToolStripMenuItem.Click += new System.EventHandler(this.todolarToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.todolarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // metroContextMenu2
            // 
            this.metroContextMenu2.Name = "metroContextMenu2";
            this.metroContextMenu2.Size = new System.Drawing.Size(61, 4);
            // 
            // metroContextMenu3
            // 
            this.metroContextMenu3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kARTEKLEToolStripMenuItem1,
            this.iŞTAKİPEKLEToolStripMenuItem});
            this.metroContextMenu3.Name = "metroContextMenu3";
            this.metroContextMenu3.Size = new System.Drawing.Size(145, 48);
            // 
            // kARTEKLEToolStripMenuItem1
            // 
            this.kARTEKLEToolStripMenuItem1.Name = "kARTEKLEToolStripMenuItem1";
            this.kARTEKLEToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.kARTEKLEToolStripMenuItem1.Text = "KART EKLE";
            // 
            // iŞTAKİPEKLEToolStripMenuItem
            // 
            this.iŞTAKİPEKLEToolStripMenuItem.Name = "iŞTAKİPEKLEToolStripMenuItem";
            this.iŞTAKİPEKLEToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.iŞTAKİPEKLEToolStripMenuItem.Text = "İŞ TAKİP EKLE";
            // 
            // metroContextMenu4
            // 
            this.metroContextMenu4.Name = "metroContextMenu4";
            this.metroContextMenu4.Size = new System.Drawing.Size(61, 4);
            // 
            // metroContextMenu5
            // 
            this.metroContextMenu5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.metroContextMenu5.Name = "metroContextMenu5";
            this.metroContextMenu5.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // metroContextMenu6
            // 
            this.metroContextMenu6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eKLEMEİŞLEMERİToolStripMenuItem});
            this.metroContextMenu6.Name = "metroContextMenu6";
            this.metroContextMenu6.Size = new System.Drawing.Size(168, 26);
            // 
            // eKLEMEİŞLEMERİToolStripMenuItem
            // 
            this.eKLEMEİŞLEMERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem});
            this.eKLEMEİŞLEMERİToolStripMenuItem.Name = "eKLEMEİŞLEMERİToolStripMenuItem";
            this.eKLEMEİŞLEMERİToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.eKLEMEİŞLEMERİToolStripMenuItem.Text = "EKLEME İŞLEMERİ";
            // 
            // gÜNCELLEMEİŞLEMLERİToolStripMenuItem
            // 
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODOLARToolStripMenuItem1});
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem.Name = "gÜNCELLEMEİŞLEMLERİToolStripMenuItem";
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem.Text = "GÜNCELLEME İŞLEMLERİ";
            // 
            // tODOLARToolStripMenuItem1
            // 
            this.tODOLARToolStripMenuItem1.Name = "tODOLARToolStripMenuItem1";
            this.tODOLARToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tODOLARToolStripMenuItem1.Text = "TODOLAR";
            // 
            // metroContextMenu7
            // 
            this.metroContextMenu7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eKLEMEİŞLEMLERİToolStripMenuItem});
            this.metroContextMenu7.Name = "metroContextMenu7";
            this.metroContextMenu7.Size = new System.Drawing.Size(174, 26);
            // 
            // eKLEMEİŞLEMLERİToolStripMenuItem
            // 
            this.eKLEMEİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem1});
            this.eKLEMEİŞLEMLERİToolStripMenuItem.Name = "eKLEMEİŞLEMLERİToolStripMenuItem";
            this.eKLEMEİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.eKLEMEİŞLEMLERİToolStripMenuItem.Text = "EKLEME İŞLEMLERİ";
            // 
            // gÜNCELLEMEİŞLEMLERİToolStripMenuItem1
            // 
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODOLARToolStripMenuItem2});
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem1.Name = "gÜNCELLEMEİŞLEMLERİToolStripMenuItem1";
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.gÜNCELLEMEİŞLEMLERİToolStripMenuItem1.Text = "GÜNCELLEME İŞLEMLERİ";
            // 
            // tODOLARToolStripMenuItem2
            // 
            this.tODOLARToolStripMenuItem2.Name = "tODOLARToolStripMenuItem2";
            this.tODOLARToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.tODOLARToolStripMenuItem2.Text = "TODOLAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 426);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ANA SAYFA";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroContextMenu3.ResumeLayout(false);
            this.metroContextMenu5.ResumeLayout(false);
            this.metroContextMenu6.ResumeLayout(false);
            this.metroContextMenu7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işTakipEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işTakipGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todolarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu2;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu3;
        private System.Windows.Forms.ToolStripMenuItem kARTEKLEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iŞTAKİPEKLEToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu4;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu6;
        private System.Windows.Forms.ToolStripMenuItem eKLEMEİŞLEMERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÜNCELLEMEİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tODOLARToolStripMenuItem1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu7;
        private System.Windows.Forms.ToolStripMenuItem eKLEMEİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÜNCELLEMEİŞLEMLERİToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tODOLARToolStripMenuItem2;
    }
}


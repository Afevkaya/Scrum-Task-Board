
namespace ScrumTaskBoard.WebFormsUI
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxIsTakip = new System.Windows.Forms.TextBox();
            this.mcbxKartlar = new MetroFramework.Controls.MetroComboBox();
            this.mlblKartlar = new MetroFramework.Controls.MetroLabel();
            this.mlblAciklama = new MetroFramework.Controls.MetroLabel();
            this.mpnIsTakip = new MetroFramework.Drawing.Html.HtmlPanel();
            this.mbtnEkle = new MetroFramework.Controls.MetroButton();
            this.mpnIsTakip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxIsTakip
            // 
            this.tbxIsTakip.BackColor = System.Drawing.Color.White;
            this.tbxIsTakip.Location = new System.Drawing.Point(11, 51);
            this.tbxIsTakip.Multiline = true;
            this.tbxIsTakip.Name = "tbxIsTakip";
            this.tbxIsTakip.Size = new System.Drawing.Size(571, 131);
            this.tbxIsTakip.TabIndex = 2;
            // 
            // mcbxKartlar
            // 
            this.mcbxKartlar.FormattingEnabled = true;
            this.mcbxKartlar.ItemHeight = 23;
            this.mcbxKartlar.Location = new System.Drawing.Point(117, 86);
            this.mcbxKartlar.Name = "mcbxKartlar";
            this.mcbxKartlar.Size = new System.Drawing.Size(121, 29);
            this.mcbxKartlar.TabIndex = 5;
            this.mcbxKartlar.UseSelectable = true;
            this.mcbxKartlar.SelectedIndexChanged += new System.EventHandler(this.mcbxKartlar_SelectedIndexChanged);
            // 
            // mlblKartlar
            // 
            this.mlblKartlar.AutoSize = true;
            this.mlblKartlar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblKartlar.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblKartlar.Location = new System.Drawing.Point(12, 86);
            this.mlblKartlar.Name = "mlblKartlar";
            this.mlblKartlar.Size = new System.Drawing.Size(99, 25);
            this.mlblKartlar.TabIndex = 6;
            this.mlblKartlar.Text = "KARTLAR:";
            // 
            // mlblAciklama
            // 
            this.mlblAciklama.AutoSize = true;
            this.mlblAciklama.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblAciklama.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblAciklama.Location = new System.Drawing.Point(11, 23);
            this.mlblAciklama.Name = "mlblAciklama";
            this.mlblAciklama.Size = new System.Drawing.Size(159, 25);
            this.mlblAciklama.TabIndex = 4;
            this.mlblAciklama.Text = "İş Takip Açıklama";
            // 
            // mpnIsTakip
            // 
            this.mpnIsTakip.AutoScroll = true;
            this.mpnIsTakip.AutoScrollMinSize = new System.Drawing.Size(594, 0);
            this.mpnIsTakip.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mpnIsTakip.Controls.Add(this.mbtnEkle);
            this.mpnIsTakip.Controls.Add(this.mlblAciklama);
            this.mpnIsTakip.Controls.Add(this.tbxIsTakip);
            this.mpnIsTakip.Location = new System.Drawing.Point(12, 146);
            this.mpnIsTakip.Name = "mpnIsTakip";
            this.mpnIsTakip.Size = new System.Drawing.Size(594, 253);
            this.mpnIsTakip.TabIndex = 7;
            // 
            // mbtnEkle
            // 
            this.mbtnEkle.Location = new System.Drawing.Point(11, 188);
            this.mbtnEkle.Name = "mbtnEkle";
            this.mbtnEkle.Size = new System.Drawing.Size(112, 34);
            this.mbtnEkle.TabIndex = 5;
            this.mbtnEkle.Text = "EKLE";
            this.mbtnEkle.UseSelectable = true;
            this.mbtnEkle.Click += new System.EventHandler(this.mbtnEkle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 457);
            this.Controls.Add(this.mpnIsTakip);
            this.Controls.Add(this.mlblKartlar);
            this.Controls.Add(this.mcbxKartlar);
            this.Name = "Form3";
            this.Text = "İŞ TAKİP EKLEME SAYFASI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.mpnIsTakip.ResumeLayout(false);
            this.mpnIsTakip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxIsTakip;
        private MetroFramework.Controls.MetroComboBox mcbxKartlar;
        private MetroFramework.Controls.MetroLabel mlblKartlar;
        private MetroFramework.Controls.MetroLabel mlblAciklama;
        private MetroFramework.Drawing.Html.HtmlPanel mpnIsTakip;
        private MetroFramework.Controls.MetroButton mbtnEkle;
    }
}
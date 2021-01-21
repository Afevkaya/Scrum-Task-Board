
namespace ScrumTaskBoard.WebFormsUI
{
    partial class Form2
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
            this.tbxIsAciklama = new System.Windows.Forms.TextBox();
            this.tbxNotlar = new System.Windows.Forms.TextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.mcbxTeknikUzman = new MetroFramework.Controls.MetroComboBox();
            this.mlblTarih = new MetroFramework.Controls.MetroLabel();
            this.mlblKartNo = new MetroFramework.Controls.MetroLabel();
            this.mlblProjeNoAd = new MetroFramework.Controls.MetroLabel();
            this.mlblTeknikUzman = new MetroFramework.Controls.MetroLabel();
            this.mlblTahminiSüre = new MetroFramework.Controls.MetroLabel();
            this.mlblGerceklesenSure = new MetroFramework.Controls.MetroLabel();
            this.mlblİşinAçıklaması = new MetroFramework.Controls.MetroLabel();
            this.mlblNotlar = new MetroFramework.Controls.MetroLabel();
            this.mcbxTahminiSure = new MetroFramework.Controls.MetroComboBox();
            this.mtbxProjeNoAd = new MetroFramework.Controls.MetroTextBox();
            this.mtbxKartNo = new MetroFramework.Controls.MetroTextBox();
            this.mtbxGerceklesenSure = new MetroFramework.Controls.MetroTextBox();
            this.mdtmTarih = new MetroFramework.Controls.MetroDateTime();
            this.mbtnEkle = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tbxIsAciklama
            // 
            this.tbxIsAciklama.Location = new System.Drawing.Point(12, 247);
            this.tbxIsAciklama.Multiline = true;
            this.tbxIsAciklama.Name = "tbxIsAciklama";
            this.tbxIsAciklama.Size = new System.Drawing.Size(779, 75);
            this.tbxIsAciklama.TabIndex = 12;
            // 
            // tbxNotlar
            // 
            this.tbxNotlar.Location = new System.Drawing.Point(12, 362);
            this.tbxNotlar.Multiline = true;
            this.tbxNotlar.Name = "tbxNotlar";
            this.tbxNotlar.Size = new System.Drawing.Size(776, 75);
            this.tbxNotlar.TabIndex = 13;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(102, 48);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.Color.Aqua;
            this.htmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.htmlLabel1.Location = new System.Drawing.Point(12, 14);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(111, 49);
            this.htmlLabel1.TabIndex = 19;
            this.htmlLabel1.Text = "Nitelik";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(226, 48);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.Color.Aqua;
            this.htmlLabel2.Location = new System.Drawing.Point(295, 15);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(234, 48);
            this.htmlLabel2.TabIndex = 20;
            this.htmlLabel2.Text = "TEKNİK KART";
            // 
            // mcbxTeknikUzman
            // 
            this.mcbxTeknikUzman.FormattingEnabled = true;
            this.mcbxTeknikUzman.ItemHeight = 23;
            this.mcbxTeknikUzman.Location = new System.Drawing.Point(140, 180);
            this.mcbxTeknikUzman.Name = "mcbxTeknikUzman";
            this.mcbxTeknikUzman.Size = new System.Drawing.Size(135, 29);
            this.mcbxTeknikUzman.TabIndex = 21;
            this.mcbxTeknikUzman.UseSelectable = true;
            this.mcbxTeknikUzman.SelectedIndexChanged += new System.EventHandler(this.mcbxTeknikUzman_SelectedIndexChanged);
            // 
            // mlblTarih
            // 
            this.mlblTarih.AutoSize = true;
            this.mlblTarih.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mlblTarih.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTarih.Location = new System.Drawing.Point(591, 24);
            this.mlblTarih.Name = "mlblTarih";
            this.mlblTarih.Size = new System.Drawing.Size(54, 19);
            this.mlblTarih.TabIndex = 22;
            this.mlblTarih.Text = "TARİH:";
            // 
            // mlblKartNo
            // 
            this.mlblKartNo.AutoSize = true;
            this.mlblKartNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mlblKartNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblKartNo.Location = new System.Drawing.Point(591, 69);
            this.mlblKartNo.Name = "mlblKartNo";
            this.mlblKartNo.Size = new System.Drawing.Size(75, 19);
            this.mlblKartNo.TabIndex = 23;
            this.mlblKartNo.Text = "KART NO:";
            // 
            // mlblProjeNoAd
            // 
            this.mlblProjeNoAd.AutoSize = true;
            this.mlblProjeNoAd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mlblProjeNoAd.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblProjeNoAd.Location = new System.Drawing.Point(14, 137);
            this.mlblProjeNoAd.Name = "mlblProjeNoAd";
            this.mlblProjeNoAd.Size = new System.Drawing.Size(115, 19);
            this.mlblProjeNoAd.TabIndex = 24;
            this.mlblProjeNoAd.Text = "PROJE NO / AD:";
            // 
            // mlblTeknikUzman
            // 
            this.mlblTeknikUzman.AutoSize = true;
            this.mlblTeknikUzman.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mlblTeknikUzman.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTeknikUzman.Location = new System.Drawing.Point(14, 182);
            this.mlblTeknikUzman.Name = "mlblTeknikUzman";
            this.mlblTeknikUzman.Size = new System.Drawing.Size(118, 19);
            this.mlblTeknikUzman.TabIndex = 25;
            this.mlblTeknikUzman.Text = "TEKNİK UZMAN:";
            // 
            // mlblTahminiSüre
            // 
            this.mlblTahminiSüre.AutoSize = true;
            this.mlblTahminiSüre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mlblTahminiSüre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblTahminiSüre.Location = new System.Drawing.Point(443, 137);
            this.mlblTahminiSüre.Name = "mlblTahminiSüre";
            this.mlblTahminiSüre.Size = new System.Drawing.Size(111, 19);
            this.mlblTahminiSüre.TabIndex = 26;
            this.mlblTahminiSüre.Text = "TAHMİNİ SÜRE:";
            // 
            // mlblGerceklesenSure
            // 
            this.mlblGerceklesenSure.AutoSize = true;
            this.mlblGerceklesenSure.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mlblGerceklesenSure.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblGerceklesenSure.Location = new System.Drawing.Point(422, 182);
            this.mlblGerceklesenSure.Name = "mlblGerceklesenSure";
            this.mlblGerceklesenSure.Size = new System.Drawing.Size(142, 19);
            this.mlblGerceklesenSure.TabIndex = 27;
            this.mlblGerceklesenSure.Text = "GERÇEKLEŞEN SÜRE:";
            // 
            // mlblİşinAçıklaması
            // 
            this.mlblİşinAçıklaması.AutoSize = true;
            this.mlblİşinAçıklaması.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mlblİşinAçıklaması.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblİşinAçıklaması.Location = new System.Drawing.Point(12, 225);
            this.mlblİşinAçıklaması.Name = "mlblİşinAçıklaması";
            this.mlblİşinAçıklaması.Size = new System.Drawing.Size(128, 19);
            this.mlblİşinAçıklaması.TabIndex = 28;
            this.mlblİşinAçıklaması.Text = "İŞİN AÇIKLAMASI:";
            // 
            // mlblNotlar
            // 
            this.mlblNotlar.AutoSize = true;
            this.mlblNotlar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mlblNotlar.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblNotlar.Location = new System.Drawing.Point(14, 340);
            this.mlblNotlar.Name = "mlblNotlar";
            this.mlblNotlar.Size = new System.Drawing.Size(68, 19);
            this.mlblNotlar.TabIndex = 29;
            this.mlblNotlar.Text = "NOTLAR:";
            // 
            // mcbxTahminiSure
            // 
            this.mcbxTahminiSure.FormattingEnabled = true;
            this.mcbxTahminiSure.ItemHeight = 23;
            this.mcbxTahminiSure.Location = new System.Drawing.Point(570, 137);
            this.mcbxTahminiSure.Name = "mcbxTahminiSure";
            this.mcbxTahminiSure.Size = new System.Drawing.Size(135, 29);
            this.mcbxTahminiSure.TabIndex = 30;
            this.mcbxTahminiSure.UseSelectable = true;
            // 
            // mtbxProjeNoAd
            // 
            // 
            // 
            // 
            this.mtbxProjeNoAd.CustomButton.Image = null;
            this.mtbxProjeNoAd.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.mtbxProjeNoAd.CustomButton.Name = "";
            this.mtbxProjeNoAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbxProjeNoAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxProjeNoAd.CustomButton.TabIndex = 1;
            this.mtbxProjeNoAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxProjeNoAd.CustomButton.UseSelectable = true;
            this.mtbxProjeNoAd.CustomButton.Visible = false;
            this.mtbxProjeNoAd.Lines = new string[0];
            this.mtbxProjeNoAd.Location = new System.Drawing.Point(140, 137);
            this.mtbxProjeNoAd.MaxLength = 32767;
            this.mtbxProjeNoAd.Name = "mtbxProjeNoAd";
            this.mtbxProjeNoAd.PasswordChar = '\0';
            this.mtbxProjeNoAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxProjeNoAd.SelectedText = "";
            this.mtbxProjeNoAd.SelectionLength = 0;
            this.mtbxProjeNoAd.SelectionStart = 0;
            this.mtbxProjeNoAd.ShortcutsEnabled = true;
            this.mtbxProjeNoAd.Size = new System.Drawing.Size(135, 23);
            this.mtbxProjeNoAd.TabIndex = 31;
            this.mtbxProjeNoAd.UseSelectable = true;
            this.mtbxProjeNoAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxProjeNoAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbxKartNo
            // 
            // 
            // 
            // 
            this.mtbxKartNo.CustomButton.Image = null;
            this.mtbxKartNo.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.mtbxKartNo.CustomButton.Name = "";
            this.mtbxKartNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbxKartNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxKartNo.CustomButton.TabIndex = 1;
            this.mtbxKartNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxKartNo.CustomButton.UseSelectable = true;
            this.mtbxKartNo.CustomButton.Visible = false;
            this.mtbxKartNo.Lines = new string[0];
            this.mtbxKartNo.Location = new System.Drawing.Point(672, 69);
            this.mtbxKartNo.MaxLength = 32767;
            this.mtbxKartNo.Name = "mtbxKartNo";
            this.mtbxKartNo.PasswordChar = '\0';
            this.mtbxKartNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxKartNo.SelectedText = "";
            this.mtbxKartNo.SelectionLength = 0;
            this.mtbxKartNo.SelectionStart = 0;
            this.mtbxKartNo.ShortcutsEnabled = true;
            this.mtbxKartNo.Size = new System.Drawing.Size(135, 23);
            this.mtbxKartNo.TabIndex = 32;
            this.mtbxKartNo.UseSelectable = true;
            this.mtbxKartNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxKartNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbxGerceklesenSure
            // 
            // 
            // 
            // 
            this.mtbxGerceklesenSure.CustomButton.Image = null;
            this.mtbxGerceklesenSure.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.mtbxGerceklesenSure.CustomButton.Name = "";
            this.mtbxGerceklesenSure.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbxGerceklesenSure.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxGerceklesenSure.CustomButton.TabIndex = 1;
            this.mtbxGerceklesenSure.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxGerceklesenSure.CustomButton.UseSelectable = true;
            this.mtbxGerceklesenSure.CustomButton.Visible = false;
            this.mtbxGerceklesenSure.Lines = new string[0];
            this.mtbxGerceklesenSure.Location = new System.Drawing.Point(570, 180);
            this.mtbxGerceklesenSure.MaxLength = 32767;
            this.mtbxGerceklesenSure.Name = "mtbxGerceklesenSure";
            this.mtbxGerceklesenSure.PasswordChar = '\0';
            this.mtbxGerceklesenSure.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxGerceklesenSure.SelectedText = "";
            this.mtbxGerceklesenSure.SelectionLength = 0;
            this.mtbxGerceklesenSure.SelectionStart = 0;
            this.mtbxGerceklesenSure.ShortcutsEnabled = true;
            this.mtbxGerceklesenSure.Size = new System.Drawing.Size(135, 23);
            this.mtbxGerceklesenSure.TabIndex = 33;
            this.mtbxGerceklesenSure.UseSelectable = true;
            this.mtbxGerceklesenSure.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxGerceklesenSure.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mdtmTarih
            // 
            this.mdtmTarih.Location = new System.Drawing.Point(672, 24);
            this.mdtmTarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtmTarih.Name = "mdtmTarih";
            this.mdtmTarih.Size = new System.Drawing.Size(200, 29);
            this.mdtmTarih.TabIndex = 34;
            // 
            // mbtnEkle
            // 
            this.mbtnEkle.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mbtnEkle.Location = new System.Drawing.Point(12, 443);
            this.mbtnEkle.Name = "mbtnEkle";
            this.mbtnEkle.Size = new System.Drawing.Size(111, 38);
            this.mbtnEkle.TabIndex = 35;
            this.mbtnEkle.Text = "EKLE";
            this.mbtnEkle.UseSelectable = true;
            this.mbtnEkle.Click += new System.EventHandler(this.mbtnEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 573);
            this.Controls.Add(this.mbtnEkle);
            this.Controls.Add(this.mdtmTarih);
            this.Controls.Add(this.mtbxGerceklesenSure);
            this.Controls.Add(this.mtbxKartNo);
            this.Controls.Add(this.mtbxProjeNoAd);
            this.Controls.Add(this.mcbxTahminiSure);
            this.Controls.Add(this.mlblNotlar);
            this.Controls.Add(this.mlblİşinAçıklaması);
            this.Controls.Add(this.mlblGerceklesenSure);
            this.Controls.Add(this.mlblTahminiSüre);
            this.Controls.Add(this.mlblTeknikUzman);
            this.Controls.Add(this.mlblProjeNoAd);
            this.Controls.Add(this.mlblKartNo);
            this.Controls.Add(this.mlblTarih);
            this.Controls.Add(this.mcbxTeknikUzman);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.tbxNotlar);
            this.Controls.Add(this.tbxIsAciklama);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxIsAciklama;
        private System.Windows.Forms.TextBox tbxNotlar;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroComboBox mcbxTeknikUzman;
        private MetroFramework.Controls.MetroLabel mlblTarih;
        private MetroFramework.Controls.MetroLabel mlblKartNo;
        private MetroFramework.Controls.MetroLabel mlblProjeNoAd;
        private MetroFramework.Controls.MetroLabel mlblTeknikUzman;
        private MetroFramework.Controls.MetroLabel mlblTahminiSüre;
        private MetroFramework.Controls.MetroLabel mlblGerceklesenSure;
        private MetroFramework.Controls.MetroLabel mlblİşinAçıklaması;
        private MetroFramework.Controls.MetroLabel mlblNotlar;
        private MetroFramework.Controls.MetroComboBox mcbxTahminiSure;
        private MetroFramework.Controls.MetroTextBox mtbxProjeNoAd;
        private MetroFramework.Controls.MetroTextBox mtbxKartNo;
        private MetroFramework.Controls.MetroTextBox mtbxGerceklesenSure;
        private MetroFramework.Controls.MetroDateTime mdtmTarih;
        private MetroFramework.Controls.MetroButton mbtnEkle;
    }
}
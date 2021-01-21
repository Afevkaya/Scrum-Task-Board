
namespace ScrumTaskBoard.WebFormsUI
{
    partial class Form6
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
            this.ltbxYapilacaklar = new System.Windows.Forms.ListBox();
            this.ltbxYapilanlar = new System.Windows.Forms.ListBox();
            this.ltbxYapilmislar = new System.Windows.Forms.ListBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.mbtnKaydet = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ltbxYapilacaklar
            // 
            this.ltbxYapilacaklar.AllowDrop = true;
            this.ltbxYapilacaklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ltbxYapilacaklar.FormattingEnabled = true;
            this.ltbxYapilacaklar.ItemHeight = 16;
            this.ltbxYapilacaklar.Location = new System.Drawing.Point(10, 149);
            this.ltbxYapilacaklar.Name = "ltbxYapilacaklar";
            this.ltbxYapilacaklar.Size = new System.Drawing.Size(357, 420);
            this.ltbxYapilacaklar.TabIndex = 0;
            this.ltbxYapilacaklar.DragDrop += new System.Windows.Forms.DragEventHandler(this.ltbxYapilacaklar_DragDrop);
            this.ltbxYapilacaklar.DragOver += new System.Windows.Forms.DragEventHandler(this.ltbxYapilacaklar_DragOver);
            this.ltbxYapilacaklar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ltbxYapilacaklar_MouseDown);
            // 
            // ltbxYapilanlar
            // 
            this.ltbxYapilanlar.AllowDrop = true;
            this.ltbxYapilanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ltbxYapilanlar.FormattingEnabled = true;
            this.ltbxYapilanlar.ItemHeight = 16;
            this.ltbxYapilanlar.Location = new System.Drawing.Point(397, 149);
            this.ltbxYapilanlar.Name = "ltbxYapilanlar";
            this.ltbxYapilanlar.Size = new System.Drawing.Size(357, 420);
            this.ltbxYapilanlar.TabIndex = 1;
            this.ltbxYapilanlar.DragDrop += new System.Windows.Forms.DragEventHandler(this.ltbxYapilanlar_DragDrop);
            this.ltbxYapilanlar.DragOver += new System.Windows.Forms.DragEventHandler(this.ltbxYapilanlar_DragOver);
            this.ltbxYapilanlar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ltbxYapilanlar_MouseDown);
            // 
            // ltbxYapilmislar
            // 
            this.ltbxYapilmislar.AllowDrop = true;
            this.ltbxYapilmislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ltbxYapilmislar.FormattingEnabled = true;
            this.ltbxYapilmislar.ItemHeight = 16;
            this.ltbxYapilmislar.Location = new System.Drawing.Point(780, 149);
            this.ltbxYapilmislar.Name = "ltbxYapilmislar";
            this.ltbxYapilmislar.Size = new System.Drawing.Size(357, 420);
            this.ltbxYapilmislar.TabIndex = 2;
            this.ltbxYapilmislar.DragDrop += new System.Windows.Forms.DragEventHandler(this.ltbxYapilmislar_DragDrop);
            this.ltbxYapilmislar.DragOver += new System.Windows.Forms.DragEventHandler(this.ltbxYapilmislar_DragOver);
            this.ltbxYapilmislar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ltbxYapilmislar_MouseDown);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(354, 48);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.htmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.htmlLabel1.Location = new System.Drawing.Point(10, 88);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(357, 55);
            this.htmlLabel1.TabIndex = 7;
            this.htmlLabel1.Text = "YAPILACAK KARTLAR";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(310, 48);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.htmlLabel2.Location = new System.Drawing.Point(397, 88);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(357, 55);
            this.htmlLabel2.TabIndex = 8;
            this.htmlLabel2.Text = "YAPILAN KARTLAR";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(323, 48);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.htmlLabel3.Location = new System.Drawing.Point(780, 88);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(357, 55);
            this.htmlLabel3.TabIndex = 9;
            this.htmlLabel3.Text = "YAPILMIŞ KARTLAR";
            // 
            // mbtnKaydet
            // 
            this.mbtnKaydet.Location = new System.Drawing.Point(10, 575);
            this.mbtnKaydet.Name = "mbtnKaydet";
            this.mbtnKaydet.Size = new System.Drawing.Size(106, 33);
            this.mbtnKaydet.TabIndex = 10;
            this.mbtnKaydet.Text = "KAYDET";
            this.mbtnKaydet.UseSelectable = true;
            this.mbtnKaydet.Click += new System.EventHandler(this.mbtnKaydet_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 653);
            this.Controls.Add(this.mbtnKaydet);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.ltbxYapilmislar);
            this.Controls.Add(this.ltbxYapilanlar);
            this.Controls.Add(this.ltbxYapilacaklar);
            this.Name = "Form6";
            this.Text = "TODOLAR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbxYapilacaklar;
        private System.Windows.Forms.ListBox ltbxYapilanlar;
        private System.Windows.Forms.ListBox ltbxYapilmislar;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroButton mbtnKaydet;
    }
}
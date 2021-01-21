
namespace ScrumTaskBoard.WebFormsUI
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbxAciklamaGuncelle = new System.Windows.Forms.TextBox();
            this.mlblAciklamaGuncelle = new MetroFramework.Controls.MetroLabel();
            this.mlblKartlar = new MetroFramework.Controls.MetroLabel();
            this.pnlGuncelle = new MetroFramework.Drawing.Html.HtmlPanel();
            this.mbtnSil = new MetroFramework.Controls.MetroButton();
            this.mbtnGuncelle = new MetroFramework.Controls.MetroButton();
            this.mgrdGuncelle = new MetroFramework.Controls.MetroGrid();
            this.mgrdKartlar = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdKartlar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxAciklamaGuncelle
            // 
            this.tbxAciklamaGuncelle.Location = new System.Drawing.Point(12, 51);
            this.tbxAciklamaGuncelle.Multiline = true;
            this.tbxAciklamaGuncelle.Name = "tbxAciklamaGuncelle";
            this.tbxAciklamaGuncelle.Size = new System.Drawing.Size(593, 130);
            this.tbxAciklamaGuncelle.TabIndex = 2;
            // 
            // mlblAciklamaGuncelle
            // 
            this.mlblAciklamaGuncelle.AutoSize = true;
            this.mlblAciklamaGuncelle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblAciklamaGuncelle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblAciklamaGuncelle.Location = new System.Drawing.Point(12, 23);
            this.mlblAciklamaGuncelle.Name = "mlblAciklamaGuncelle";
            this.mlblAciklamaGuncelle.Size = new System.Drawing.Size(111, 25);
            this.mlblAciklamaGuncelle.TabIndex = 6;
            this.mlblAciklamaGuncelle.Text = "AÇIKLAMA:";
            // 
            // mlblKartlar
            // 
            this.mlblKartlar.AutoSize = true;
            this.mlblKartlar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblKartlar.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblKartlar.Location = new System.Drawing.Point(56, 85);
            this.mlblKartlar.Name = "mlblKartlar";
            this.mlblKartlar.Size = new System.Drawing.Size(94, 25);
            this.mlblKartlar.TabIndex = 5;
            this.mlblKartlar.Text = "KARTLAR";
            // 
            // pnlGuncelle
            // 
            this.pnlGuncelle.AutoScroll = true;
            this.pnlGuncelle.AutoScrollMinSize = new System.Drawing.Size(624, 0);
            this.pnlGuncelle.BackColor = System.Drawing.SystemColors.Window;
            this.pnlGuncelle.Controls.Add(this.mbtnSil);
            this.pnlGuncelle.Controls.Add(this.mbtnGuncelle);
            this.pnlGuncelle.Controls.Add(this.tbxAciklamaGuncelle);
            this.pnlGuncelle.Controls.Add(this.mlblAciklamaGuncelle);
            this.pnlGuncelle.Location = new System.Drawing.Point(44, 508);
            this.pnlGuncelle.Name = "pnlGuncelle";
            this.pnlGuncelle.Size = new System.Drawing.Size(624, 318);
            this.pnlGuncelle.TabIndex = 5;
            // 
            // mbtnSil
            // 
            this.mbtnSil.Location = new System.Drawing.Point(137, 187);
            this.mbtnSil.Name = "mbtnSil";
            this.mbtnSil.Size = new System.Drawing.Size(111, 33);
            this.mbtnSil.TabIndex = 8;
            this.mbtnSil.Text = "SİL";
            this.mbtnSil.UseSelectable = true;
            this.mbtnSil.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // mbtnGuncelle
            // 
            this.mbtnGuncelle.Location = new System.Drawing.Point(12, 187);
            this.mbtnGuncelle.Name = "mbtnGuncelle";
            this.mbtnGuncelle.Size = new System.Drawing.Size(111, 33);
            this.mbtnGuncelle.TabIndex = 7;
            this.mbtnGuncelle.Text = "GÜNCELLE";
            this.mbtnGuncelle.UseSelectable = true;
            this.mbtnGuncelle.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mgrdGuncelle
            // 
            this.mgrdGuncelle.AllowUserToResizeRows = false;
            this.mgrdGuncelle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgrdGuncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgrdGuncelle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgrdGuncelle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdGuncelle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgrdGuncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgrdGuncelle.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgrdGuncelle.EnableHeadersVisualStyles = false;
            this.mgrdGuncelle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgrdGuncelle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdGuncelle.Location = new System.Drawing.Point(44, 328);
            this.mgrdGuncelle.Name = "mgrdGuncelle";
            this.mgrdGuncelle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdGuncelle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgrdGuncelle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgrdGuncelle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrdGuncelle.Size = new System.Drawing.Size(605, 150);
            this.mgrdGuncelle.TabIndex = 6;
            this.mgrdGuncelle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrdGuncelle_CellClick);
            // 
            // mgrdKartlar
            // 
            this.mgrdKartlar.AllowUserToResizeRows = false;
            this.mgrdKartlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgrdKartlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdKartlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgrdKartlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgrdKartlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdKartlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgrdKartlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgrdKartlar.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgrdKartlar.EnableHeadersVisualStyles = false;
            this.mgrdKartlar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgrdKartlar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrdKartlar.Location = new System.Drawing.Point(44, 134);
            this.mgrdKartlar.Name = "mgrdKartlar";
            this.mgrdKartlar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrdKartlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgrdKartlar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgrdKartlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrdKartlar.Size = new System.Drawing.Size(605, 150);
            this.mgrdKartlar.TabIndex = 7;
            this.mgrdKartlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrdKartlar_CellClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(56, 300);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "İŞ TAKİPLERİ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 794);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mgrdKartlar);
            this.Controls.Add(this.mgrdGuncelle);
            this.Controls.Add(this.pnlGuncelle);
            this.Controls.Add(this.mlblKartlar);
            this.Name = "Form5";
            this.Text = "İŞ TAKİP GÜNCELLE - SİL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.pnlGuncelle.ResumeLayout(false);
            this.pnlGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgrdKartlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxAciklamaGuncelle;
        private MetroFramework.Controls.MetroLabel mlblAciklamaGuncelle;
        private MetroFramework.Controls.MetroLabel mlblKartlar;
        private MetroFramework.Drawing.Html.HtmlPanel pnlGuncelle;
        private MetroFramework.Controls.MetroGrid mgrdGuncelle;
        private MetroFramework.Controls.MetroButton mbtnSil;
        private MetroFramework.Controls.MetroButton mbtnGuncelle;
        private MetroFramework.Controls.MetroGrid mgrdKartlar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
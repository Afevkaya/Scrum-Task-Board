using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ScrumTaskBoard.WebFormsUI
{
    public partial class Form1 : MetroForm
    {
        
        public void LoadForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
            form.Activate();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void kartEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(Form2.Instance);
        }

        private void işTakipEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(Form3.Instance);
        }

        private void kartGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(Form4.Instance);
        }

        private void işTakipGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(Form5.Instance);
        }

        private void todolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(Form6.Instance);
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parent_child
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void العملياتالحسابيةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        addform add;
        subform sub;
        multform mult;
        divform div;
        private void جمعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(add ==null || add.IsDisposed)
            { add = new addform();
                add.MdiParent = this;
                add.Show();
            }
            else
            { add.Show();
                add.Focus();
            }

        }

        private void طرحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sub == null || sub.IsDisposed)
            {
                sub = new subform();
                sub.MdiParent = this;
                sub.Show();
            }
            else
            {
                sub.Show();
                sub.Focus();
            }
        }

        private void ضربToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mult == null || mult.IsDisposed)
            {
                mult = new multform();
                mult.MdiParent = this;
                mult.Show();
            }
            else
            {
                mult.Show();
                mult.Focus();
            }
        }

        private void قسمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (div == null || div.IsDisposed)
            {
                div = new divform();
                div.MdiParent = this;
                div.Show();
            }
            else
            {
                div.Show();
                div.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

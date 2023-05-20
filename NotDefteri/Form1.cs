using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            chkListe.Items.Add(rchMesaj.Text);
            rchMesaj.Clear();
        }

        private void chkListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkListe.Items.Contains(rchMesaj.Text);


        }

        private void chkListe_SelectedValueChanged(object sender, EventArgs e)
        {
                        
        }

        private void chkListe_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }
    }
}

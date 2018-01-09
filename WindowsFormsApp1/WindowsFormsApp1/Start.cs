using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelP
{
    public partial class Start : Form
    {
       internal static Hotel z = new Hotel();
        
        public Start()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hotel z = new Hotel();
            z.DodajRezerwacje("Jan", "Kowalski", 23, 23.22d);
            z.DodajRezerwacje("Kudes", "Janko", 5, 87.22d);
            label1.Text = z.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void klik(object sender, EventArgs e)
        {

        }

        private void paintForm(object sender, PaintEventArgs e)
        {
            // z.UstawDate =  userControl11.s 
            //if (z.SprawdzDate()) { MessageBox.Show("Korekt"); }
        }
    }
}

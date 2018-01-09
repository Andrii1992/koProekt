using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelP
{
    public partial class UserControl1 : UserControl
    {
        internal DateTime s;
        internal static UserControl ser;
        public UserControl1()
        {
            InitializeComponent();
            ser = this;
        }

        private void klik(object sender, EventArgs e)
        {
            try
            {
                s = Convert.ToDateTime(formF.Text);
                Start.z.UstawDate(s);
            }
            catch { MessageBox.Show("Nie korektne dane daty!"); }
            if (Start.z.SprawdzDate()) { MessageBox.Show("Jest");}
            if (s.Date >= DateTime.Now) { MessageBox.Show("Jest00000000"); }

        }

        private void formF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

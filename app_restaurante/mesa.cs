using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_restaurante
{
    public partial class mesa : Form
    {
        public mesa()
        {
            InitializeComponent();
        }

        private void btnmesa1_Click(object sender, EventArgs e)
        {
            Pedidos pedd = new Pedidos();
            pedd.Show();
            this.Hide();
            
        }

        private void btnmesa2_Click(object sender, EventArgs e)
        {
            Pedidos pedd = new Pedidos();
            pedd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pedidos pedd = new Pedidos();
            pedd.Show();
            this.Hide();
        }

        private void btnmesa4_Click(object sender, EventArgs e)
        {
            Pedidos pedd = new Pedidos();
            pedd.Show();
            this.Hide();

        }
    }
}

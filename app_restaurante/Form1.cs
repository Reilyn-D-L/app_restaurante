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
    public partial class Pedidos : Form
    {

        public Pedidos()
        {
            InitializeComponent();
        }
        double total, a;
        private void btntomarorden_Click(object sender, EventArgs e)
        {
              //int contar = Convert.ToInt32(txtcantidadp.Text);//
           
            
                listBox1.Items.Clear();
                listBox1.Items.Add("Orden de " + txtnombre.Text);
                listBox1.Items.Add(" ");
                listBox1.Items.Add(" ");
                if (checkBox1.Checked == true)
                {
                    listBox1.Items.Add(checkBox1.Text + "          " + "$ 50");

                }
                else
                {
                    listBox1.Items.Remove(checkBox1.Text);
                }
                if (checkBox2.Checked == true)
                {
                    listBox1.Items.Add(checkBox2.Text + "          " + "$ 120");
                }
                else
                {
                    listBox1.Items.Remove(checkBox2.Text);
                }
                if (checkBox3.Checked == true)
                {
                    listBox1.Items.Add(checkBox3.Text + "          " + "$ 75");
                }
                else
                {
                    listBox1.Items.Remove(checkBox3.Text);
                }
                if (checkBox4.Checked == true)
                {
                    listBox1.Items.Add(checkBox4.Text + "          " + "$ 25");
                }
                else
                {
                    listBox1.Items.Remove(checkBox4.Text);
                }
                if (checkBox5.Checked == true)
                {
                    listBox1.Items.Add(checkBox5.Text + "          " + "$ 350");
                }
                else
                {
                    listBox1.Items.Remove(checkBox5.Text);
                }
                if (checkBox6.Checked == true)
                {
                    listBox1.Items.Add(checkBox6.Text + "          " + "$ 500");
                }
                else
                {
                    listBox1.Items.Remove(checkBox6.Text);
                }
                if (checkBox7.Checked == true)
                {
                    listBox1.Items.Add(checkBox7.Text + "          " + "$ 400");
                }
                else
                {
                    listBox1.Items.Remove(checkBox7.Text);
                }
                if (checkBox8.Checked == true)
                {
                    listBox1.Items.Add(checkBox8.Text + "          " + "$ 450");
                }
                else
                {
                    listBox1.Items.Remove(checkBox8.Text);
                }
                if (checkBox9.Checked == true)
                {
                    listBox1.Items.Add(checkBox9.Text + "          " + "$ 500");
                }
                else
                {
                    listBox1.Items.Remove(checkBox9.Text);
                }
                if (checkBox10.Checked == true)
                {
                    listBox1.Items.Add(checkBox10.Text + "          " + "$ 600");
                }
                else
                {
                    listBox1.Items.Remove(checkBox10.Text);
                }
                if (checkBox11.Checked == true)
                {
                    listBox1.Items.Add(checkBox11.Text + "          " + "$ 250");
                }
                else
                {
                    listBox1.Items.Remove(checkBox11.Text);
                }
                if (checkBox12.Checked == true)
                {
                    listBox1.Items.Add(checkBox12.Text + "          " + "$ 300");
                }
                else
                {
                    listBox1.Items.Remove(checkBox12.Text);
                }
                if (checkBox13.Checked == true)
                {
                    listBox1.Items.Add(checkBox13.Text + "          " + "$ 235");
                }
                else
                {
                    listBox1.Items.Remove(checkBox13.Text);
                }
                if (checkBox14.Checked == true)
                {
                    listBox1.Items.Add(checkBox14.Text + "          " + "$ 1200");
                }
                else
                {
                    listBox1.Items.Remove(checkBox14.Text);
                }
                if (checkBox15.Checked == true)
                {
                    listBox1.Items.Add(checkBox15.Text + "          " + "$ 400");
                }
                else
                {
                    listBox1.Items.Remove(checkBox15.Text);
                }
                if (checkBox16.Checked == true)
                {
                    listBox1.Items.Add(checkBox16.Text + "          " + "$ 100");
                }
                else
                {
                    listBox1.Items.Remove(checkBox16.Text);
                }
                if (checkBox17.Checked == true)
                {
                    listBox1.Items.Add(checkBox17.Text + "          " + "$ 45");
                }
                else
                {
                    listBox1.Items.Remove(checkBox17.Text);
                }
                if (checkBox18.Checked == true)
                {
                    listBox1.Items.Add(checkBox18.Text + "          " + "$ 60");
                }
                else
                {
                    listBox1.Items.Remove(checkBox18.Text);
                }
                if (checkBox19.Checked == true)
                {
                    listBox1.Items.Add(checkBox19.Text + "          " + "$ 25");
                }
                else
                {
                    listBox1.Items.Remove(checkBox19.Text);
                }
                if (checkBox20.Checked == true)
                {
                    listBox1.Items.Add(checkBox20.Text + "          " + "$ 15");
                }
                else
                {
                    listBox1.Items.Remove(checkBox20.Text);
                }
            
            //MessageBox.Show("Que desea ordenar la otra Persona?");
           
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            total = 0;
            txttotal.Clear();
            listBox1.Items.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;


        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                a = 50;
                total = total + a;

            }
            if (checkBox2.Checked == true)
            {
                a = 120;
                total = total + a;
            }
            if (checkBox3.Checked == true)
            {
                a = 75;
                total = total + a;
            }
         
            if (checkBox4.Checked == true)
            {
                a = 25;
                total = total + a;
            }
            
            if (checkBox5.Checked == true)
            {
                a = 350;
                total = total + a;
            }
            
            if (checkBox6.Checked == true)
            {
                a = 500;
                total = total + a;
            }
            
            if (checkBox7.Checked == true)
            {
                a = 400;
                total = total + a;
            }
            
            if (checkBox8.Checked == true)
            {
                a = 450;
                total = total + a;
            }
            
            if (checkBox9.Checked == true)
            {
                a = 500;
                total = total + a;
            }
            
            if (checkBox10.Checked == true)
            {
                a = 600;
                total = total + a;
            }
           
            if (checkBox11.Checked == true)
            {
                a = 250;
                total = total + a;
            }
           
            if (checkBox12.Checked == true)
            {
                a = 300;
                total = total + a;
            }
            
            if (checkBox13.Checked == true)
            {
                a = 235;
                total = total + a;
            }
            
            if (checkBox14.Checked == true)
            {
                a = 1200;
                total = total + a;
            }
            
            if (checkBox15.Checked == true)
            {
                a = 400;
                total = total + a; 
            }
            
            if (checkBox16.Checked == true)
            {
                a = 100;
                total = total + a;
            }
            
            if (checkBox17.Checked == true)
            {
                a = 45;
                total = total + a;
            }
            
            if (checkBox18.Checked == true)
            {
                a = 60;
                total = total + a;
            }
           
            if (checkBox19.Checked == true)
            {
                a = 25;
                total = total + a;
            }
            
            if (checkBox20.Checked == true)
            {
                a = 15;
                total = total + a;
            }
            txttotal.Text = "$" + total;

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            mesa ms = new mesa();
            ms.Show();
            this.Hide();
        }

        private void lblnom_Click(object sender, EventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void listprecio2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contarPersonas()
        {
            int contar = Convert.ToInt32(txtcantidadp.Text);
            
             while (contar == 3);
            {

            }

        }
    }
}

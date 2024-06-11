using System.Drawing.Text;
using System.Windows.Forms;

namespace proyecto_de_calculadora
{
    public partial class Form1 : Form
    {
        private int bandopc = 0;
        private double valor1;
        private double valor2;

        private double resultado;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bandopc = 1;
            panel2.Visible = true;
            panel10.Visible = false;
            textBox1.Location = new Point(11, 37);
            textBox1.Size = new Size(242, 48);
            panel2.Location = new Point(11, 87);
            panel11.Visible = false;

            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel6.Visible = false;
            panel9.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
        }

        private void cientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //activar cientifica
            estandarToolStripMenuItem.Checked = false;
            cientificaToolStripMenuItem.Checked = true;
            programadorToolStripMenuItem.Checked = false;
            bandopc = 2;

            button55.Enabled = true;
            button49.Enabled = true;
            button32.Enabled = true;
            button29.Enabled = true;
            button47.Enabled = true;
            button53.Enabled = true;
            button51.Enabled = true;
            button46.Enabled = true;

            panel10.Location = new Point(542, 37);            
            panel2.Location = new Point(270, 91);
            panel1.Location = new Point(20, 91);
            panel1.Visible = true;
            panel3.Visible = true;
            textBox1.Location = new Point(20, 37);
            textBox1.Size = new Size(491, 48);
            panel6.Visible = false;
            panel9.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //activar estandar  
            estandarToolStripMenuItem.Checked = true;
            cientificaToolStripMenuItem.Checked = false;
            programadorToolStripMenuItem.Checked = false;

            button55.Enabled = true;
            button49.Enabled = true;
            button32.Enabled = true;
            button29.Enabled = true;
            button47.Enabled = true;
            button53.Enabled = true;
            button51.Enabled = true;
            button46.Enabled = true;

            bandopc = 1;
            panel10.Visible = false;
            textBox1.Location = new Point(11, 37);
            textBox1.Size = new Size(231, 48);
            panel2.Location = new Point(11, 87);
            
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel6.Visible = false;
            panel9.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;

            textBox1.Size = new Size(241, 48);
            if (verLaAyudaToolStripMenuItem.Checked == true)
            {
                
                panel10.Visible = false;
                
            }
            else if (calculadoraDeFechasToolStripMenuItem1.Checked == true)
            {
                panel10.Visible = false;
                panel11.Visible = true;
                panel11.Location = new Point(281, 37);
            }
        }
        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estandarToolStripMenuItem.Checked = false;
            cientificaToolStripMenuItem.Checked = false;
            programadorToolStripMenuItem.Checked = true;
            bandopc = 3;
            if (panel10.Visible == true)
            {
                Size = new Size(845, 450);
            }
            else
            {
                Size = new Size(550, 450);
            }
            panel10.Location = new Point(542, 37);
            textBox1.Location = new Point(34, 37);
            panel1.Visible = false;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            textBox1.Size = new Size(478, 48);

            panel7.Visible = true;
            panel2.Location = new Point(271, 156);

            if (verLaAyudaToolStripMenuItem.Checked == true)
            {

                panel10.Visible = false;

            }
            else
            {

                panel10.Visible = true;
                panel10.Location = new Point(542, 37);
            }
            if(radioButton5.Checked == true)
            {
                panel4.Enabled = false;
                button55.Enabled = true;
                button49.Enabled = true;
                button32.Enabled = true;
                button29.Enabled = true;
                button47.Enabled = true;
                button53.Enabled = true;
                button51.Enabled = true;
                button46.Enabled = true;
            }
            else if (radioButton6.Checked == true)
            {
                button55.Enabled = false;
                button49.Enabled = false;
                button32.Enabled = true;
                button29.Enabled = true;
                button47.Enabled = true;
                button53.Enabled = true;
                button51.Enabled = true;
                button46.Enabled = true;
            }
            else if(radioButton7.Checked == true)
            {
                button55.Enabled = false;
                button49.Enabled = false;
                button32.Enabled = false;
                button29.Enabled = false;
                button47.Enabled = false;
                button53.Enabled = false;
                button51.Enabled = false;
                button46.Enabled = false;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            //resta
            operacion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            //suma
            operacion = 2;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

        }

        private void button44_Click(object sender, EventArgs e)
        {
            //multiplicacion
            operacion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            //divicion
            operacion = 4;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            //porcentaje
            operacion = 5;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }
        private void button36_Click(object sender, EventArgs e)
        {
            //boton 1/x
            operacion = 6;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //boton de raiz cudrada
            operacion = 7;
            textBox1.Text = "";

        }
        private void button41_Click(object sender, EventArgs e)
        {
            //boton ±
            operacion = 8;
            textBox1.Text = "-";
        }
        private void button50_Click(object sender, EventArgs e)
        {
            //punto decimal
            if (textBox1.Text == "")
            {
                textBox1.Text = "0,";
            }
            else
                textBox1.Text += ",";
        }

        private void button45_Click(object sender, EventArgs e)
        {
            //Boton CE
            textBox1.Text = "";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            //Boton C
            textBox1.Text = "";
        }
        private void button35_Click(object sender, EventArgs e)
        {
            // boton de igual
            valor2 = Convert.ToDouble(textBox1.Text);

            switch (operacion)
            {
                case 1:


                    resultado = valor1 - valor2;
                    textBox1.Text = resultado.ToString();

                    break;


                case 2:
                    resultado = valor1 + valor2;
                    textBox1.Text = resultado.ToString();
                    break;

                case 3:
                    resultado = valor1 * valor2;
                    textBox1.Text = resultado.ToString();
                    break;

                case 4:
                    if (valor2 == 0)
                    {
                        textBox1.Text = "error de sintaxis";
                        break;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                        textBox1.Text = resultado.ToString();
                        break;
                    }

                case 5:
                    resultado = valor1 * (valor2 / 100);
                    textBox1.Text = resultado.ToString();
                    break;

                case 6:
                    if (valor1 == 0)
                    {
                        textBox1.Text = "error de sintaxis";
                        break;
                    }
                    else
                    {
                        resultado = 1 / valor1;
                        textBox1.Text = resultado.ToString();
                        break;
                    }

                case 7:
                    if (valor1 < 0)
                    {
                        textBox1.Text = "no existe";
                        break;
                    }
                    else
                    {
                        resultado = Math.Sqrt(valor1 = Convert.ToDouble(textBox1.Text));
                        textBox1.Text = resultado.ToString();
                        break;
                    }
                case 8:
                    resultado = (-1) * valor1;
                    break;


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Enabled = true;
            button55.Enabled = true;
            button49.Enabled = true;
            button32.Enabled = true;
            button29.Enabled = true;
            button47.Enabled = true;
            button53.Enabled = true;
            button51.Enabled = true;
            button46.Enabled = true;
        }


        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Enabled = false;
            button55.Enabled = true;
            button49.Enabled = true;
            button32.Enabled = true;
            button29.Enabled = true;
            button47.Enabled = true;
            button53.Enabled = true;
            button51.Enabled = true;
            button46.Enabled = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button55.Enabled = false;
            button49.Enabled = false;
            button32.Enabled = true;
            button29.Enabled = true;
            button47.Enabled = true;
            button53.Enabled = true;
            button51.Enabled = true;
            button46.Enabled = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button55.Enabled = false;
            button49.Enabled = false;
            button32.Enabled = false;
            button29.Enabled = false;
            button47.Enabled = false;
            button53.Enabled = false;
            button51.Enabled = false;
            button46.Enabled = false;
        }

        private void conversionDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conversionDeUnidadesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void basicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            textBox1.Location = new Point(11, 37);
            textBox1.Size = new Size(231, 48);
            panel2.Location = new Point(11, 87);
            Size = new Size(283, 367);
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel6.Visible = false;
            panel9.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;

            textBox1.Size = new Size(241, 48);
        }

        private void verLaAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //activar basica
            verLaAyudaToolStripMenuItem.Checked = true;
            acToolStripMenuItem.Checked = false;
            calculadoraDeFechasToolStripMenuItem1.Checked = false;
   
            if (verLaAyudaToolStripMenuItem.Checked == true )
            {
                panel10.Visible = false;
                panel11.Visible = false;
                panel10.Location = new Point(281, 37);
            }
            else if (verLaAyudaToolStripMenuItem.Checked == false && bandopc == 2)
            {
                Size = new Size(550, 389);
                panel10.Visible = false;
            }

        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //opcion de convesion de unidades

            verLaAyudaToolStripMenuItem.Checked = false;
            acToolStripMenuItem.Checked = true;
            calculadoraDeFechasToolStripMenuItem1.Checked = false;

            if (acToolStripMenuItem.Checked == false)
            {
                panel2.Visible = true;
                panel10.Visible = false;
                panel10.Size = new Size(254, 286);
                textBox1.Location = new Point(11, 37);
                textBox1.Size = new Size(242, 48);
                panel2.Location = new Point(11, 87);
                Size = new Size(283, 367);
            }
            else
            {
                panel11.Visible = false;

                if (bandopc == 1)
                {
                    estandarToolStripMenuItem.Checked = true;
                    cientificaToolStripMenuItem.Checked = false;
                    programadorToolStripMenuItem.Checked = false;


                    if (verLaAyudaToolStripMenuItem.CheckOnClick == true)
                    {
                        Size = new Size(595, 382);
                        panel10.Visible = true;
                        panel10.Location = new Point(281, 37);
                        panel11.Visible = false;
                    }
                    else
                    {
                        panel10.Visible = false;
                    }

                }
                else if (bandopc == 2)
                {
                    textBox1.Location = new Point(20, 37);
                    textBox1.Size = new Size(491, 48);
                    panel1.Location = new Point(20, 91);
                    panel1.Visible = true;
                    panel3.Visible = true;
                    panel2.Location = new Point(270, 91);
                    Size = new Size(845, 376);
                    panel10.Visible = true;
                    panel10.Location = new Point(542, 37);
                    panel10.Size = new Size(254, 286);
                    panel11.Visible = false;

                    if (acToolStripMenuItem.Checked == false)
                    {
                        estandarToolStripMenuItem.Checked = false;
                        cientificaToolStripMenuItem.Checked = true;
                        programadorToolStripMenuItem.Checked = false;
                    }
                }
                else if (bandopc == 3)
                {
                    panel10.Visible = true;
                    panel11.Visible = false;
                    panel10.Location = new Point(542, 37);
                    panel10.Size = new Size(254, 351);
                    if (acToolStripMenuItem.Checked == false)
                    {

                        estandarToolStripMenuItem.Checked = false;
                        cientificaToolStripMenuItem.Checked = false;
                        programadorToolStripMenuItem.Checked = true;
                    }
                }
            }
            }

            private void calculadoraDeFechasToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                verLaAyudaToolStripMenuItem.Checked = false;
                acToolStripMenuItem.Checked = false;
                calculadoraDeFechasToolStripMenuItem1.Checked = true;
                
            if (calculadoraDeFechasToolStripMenuItem1.Checked == false)
            {
                AutoSize = true;
                panel11.Visible = false;
                panel11.Location = new Point(281, 37);

            }
            else  
            {
                
                if (bandopc == 1)
                {
                   
                    estandarToolStripMenuItem.Checked = true;
                    cientificaToolStripMenuItem.Checked = false;
                    programadorToolStripMenuItem.Checked = false;


                    if (calculadoraDeFechasToolStripMenuItem1.CheckOnClick == true)
                    {
                        
                        AutoSize = true;
                        panel11.Visible = true;
                        panel11.Location = new Point(286, 37);
                       
                        
                    }
                    else
                    {
                        AutoSize = true;
                        panel11.Visible = false;
                    }

                }
                else if (bandopc == 2)
                {
                    textBox1.Location = new Point(20, 37);
                    textBox1.Size = new Size(491, 48);
                    panel1.Location = new Point(20, 91);
                    panel1.Visible = true;
                    panel3.Visible = true;
                    panel2.Location = new Point(270, 91);
                    AutoSize = true;
                    panel11.Visible = true;
                    panel11 .Location = new Point(542, 37);
                    panel11.Size = new Size(254, 286);

                    if (calculadoraDeFechasToolStripMenuItem1.Checked == false)
                    {
                        estandarToolStripMenuItem.Checked = false;
                        cientificaToolStripMenuItem.Checked = true;
                        programadorToolStripMenuItem.Checked = false;
                    }
                }
                else if (bandopc == 3)
                {
                    panel11.Visible = true;
                    panel11.Location = new Point(542, 37);
                    panel11.Size = new Size(254, 351);
                    if (calculadoraDeFechasToolStripMenuItem1.Checked == false)
                    {

                        estandarToolStripMenuItem.Checked = false;
                        cientificaToolStripMenuItem.Checked = false;
                        programadorToolStripMenuItem.Checked = true;
                    }
                }
            }
            }

        }
    } 

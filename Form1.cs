using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPizzeria
{
    public partial class Form1 : Form
    {
        //declaro las variables globales
        public int precio, extras;
        public string seleccion, demora;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //al presionar enteer ejecuta el boton CALCULAR
            this.AcceptButton = btnCalcular;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //desmarco los controles del formulario, limpio los label y las variables
            foreach (Control control in Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control controlGrup in control.Controls)
                    {
                        if (controlGrup is RadioButton) ((RadioButton)controlGrup).Checked = false;
                        else if (controlGrup is CheckBox) ((CheckBox)controlGrup).Checked = false;
                    }
                }
            }
            precio = 0;
            extras = 0;
            demora = "";
            seleccion = "";
            lblEntrega.Text = "";
            lblPrecio.Text = "";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose(); //cierro el form
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // creo una variable booleana para controlar luego que al menos un radiobutton quede seleccionado
            bool v = false;
            
            //recorro el groupbox para saber cual radiobutton esta seleccionado, en cuyo cosa paso a true la variable booleana v
            foreach (RadioButton r in gbxTamaño.Controls)
            {
                if (r.Checked)
                {
                    seleccion = r.Name;
                    v = true;
                }      
            }

            //pongo un control para que en caso que no haya seleccionado ningun radiobutton, no se ejecute el código y muestre un mensaje
            if (v)
            {
                //recorro el groupbox para saber cuántos checkbox marcados
                foreach (CheckBox c in gbxExtras.Controls)
                {
                    if (c.Checked) extras++;
                }

                //asigno a la variable precio el valor correspondiente a la elección
                switch (seleccion)
                {
                    case "rbtnChica":
                        precio = 90;
                        break;
                    case "rbtnMediana":
                        precio = 130;
                        break;
                    case "rbtnGrande":
                        precio = 180;
                        break;
                    case "rbtnFamiliar":
                        precio = 210;
                        break;
                    default:
                        MessageBox.Show("Debe elegir un tamaño de Pizza", "Tamaño?");
                        btnLimpiar.PerformClick();
                        break;
                }

                //calculo el precio final
                precio += (extras * 25);

                //calculo la hora del momento del pedido para estimar la demora
                DateTime ahora = DateTime.Now;

                //Comparar hora y minutos y defino el valor de la demora
                if ((ahora.Hour >= 12 && ahora.Minute >= 00) && (ahora.Hour < 14 && ahora.Minute <= 59)
                    ||
                   ((ahora.Hour >= 20 && ahora.Minute >= 00) && (ahora.Hour < 22 && ahora.Minute <= 59)))
                    demora = "45 minutos";
                else demora = "20 minutos";

                //imprimo los resultados en los labels
                lblPrecio.Text = "Total a Pagar $ " + precio.ToString();
                lblEntrega.Text = "La demora estimada es de " + demora;
            }
            else
            {
                MessageBox.Show("Debe elegir un tamaño", "Tamaño?");
            }
        }
    }
}

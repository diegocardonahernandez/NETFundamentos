using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();

            List<Control> botones = new List<Control>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones.Add(this.textBox1);


            //-------------

            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);

            ((Button)coleccion[0]).BackColor = Color.Yellow;

            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.LightGoldenrodYellow;
                /*Cuando tenemos multiples objetos de diferentes calses,
                 * nos podemos abstraer en el recorrido, pero a lo mejor,
                 * necesitamos alguna carcateristica especial de cada uno.
                 * una caja tiene un metodo llamado Paste()
                 */

                if (boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }

            this.button1.Click += MetodoDelegado;

                 }
            void MetodoDelegado(object sender, EventArgs e)
            {
                
            }

        
    }
}

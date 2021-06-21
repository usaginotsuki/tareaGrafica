using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1
{
    public partial class Form1 : Form
    {

        //Crear el objeto de tipo clase CTriangle()
        private CTriangle objTriangle = new CTriangle();

        public Form1()
        {
            InitializeComponent();
        }

        private void lblPosY_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            //Desplegar coordenadas en el formulario
            txtPosX.Text = e.X.ToString();
            txtPosY.Text = e.Y.ToString();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            //Leemos las coordenadas iniciales
            txtPosX.Text = e.X.ToString();
            txtPosY.Text = e.Y.ToString();
            
            //Dibujar el Triangulo Equilatero
            objTriangle.ReadPosition(txtPosX, txtPosY, txtWidth);
            objTriangle.DrawTriangle(picCanvas);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            //Activar la forma del Triangulo Equilatero
            picCanvas.Cursor = Cursors.Hand;
        }
    }
}

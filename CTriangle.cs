using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Taller1
{
    class CTriangle
    {
        //Crear los Datos Miembros
        private Point mPoint1, mPoint2, mPointMed;
        private PointF mPoint3;
        //Definir el Lienzo
        private Graphics mGraph;
        //Definir mi Lapiz
        private Pen mPen;
        private int mScale;

        //Crear Constructor
        public CTriangle()
        {
            //Inicializar Variables
            mPoint1.X = -1;
            mPoint1.Y = -1;
            mPoint2.X = -1;
            mPoint2.Y = -1;
            mPoint3.X = -1;
            mPoint3.Y = -1;
            mScale = 2;

            //Incializar mi Lapiz
            mPen = new Pen(Color.Black, mScale);
        }

        //Método para Leer las Posiciones
        public void ReadPosition(TextBox txtPosX, TextBox txtPosY, TextBox txtWidth)
        {
            //Declaramos los catetos del triangulo Rectangulo
            int c = int.Parse(txtWidth.Text);
            int a = int.Parse(txtWidth.Text) / 2;
            double b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2)); //Fórmula del Teorema de Pitagoras para calcular la Altura
            float altura = ((float)b); //Casteamos a float
            
            //Leemos el punto Inicial
            mPoint1.X = int.Parse(txtPosX.Text);
            mPoint1.Y = int.Parse(txtPosY.Text);

            //Calculamos el segundo Punto a partir de la longitud ingresada
            mPoint2.X = int.Parse(txtPosX.Text) + c;
            mPoint2.Y = int.Parse(txtPosY.Text);

            //Calculamos el Punto Medio de la Linea
            mPointMed.X = (mPoint2.X + mPoint1.X) / 2;
            mPointMed.Y = mPoint1.Y;
            
            //Calculamos el tercer Punto del Triangulo
            mPoint3.X = mPointMed.X;
            mPoint3.Y = mPointMed.Y - altura;
        }

        //Método de graficación del Triangulo Equilatero
        public void DrawTriangle(PictureBox picCanvas)
        {

            //Crear el Lienzo del Dibujo
            mGraph = picCanvas.CreateGraphics();

            //Graficamos los lados del Triangulo Equilatero
            mGraph.DrawLine(mPen, mPoint1, mPoint2);
            mGraph.DrawLine(mPen, mPoint1, mPoint3);
            mGraph.DrawLine(mPen, mPoint2, mPoint3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint
{
    class CPoint
    {
        //Datos MIEMBROS
        private int mPosX, mPosY;
        //Definir el lienso
        private Graphics mGraph;
        //Definir el grosor
        private int mscale;
        //Definir el lapiz
        private Pen mPen, mPenFill;

        //CREAR EL CONSTRUCTOR
        public CPoint()
        {
            mPosX = mPosY = -1;
            mscale = 2;
            mPen = new Pen(Color.Black, mscale);
            mPenFill = new Pen(Color.Pink, mscale);
        }
        //Crear el método para ubicar la posicion del dibujo
        public void ReadPosition(TextBox PosX, TextBox PosY)
        {
            mPosX = int.Parse(PosX.Text);
            mPosY = int.Parse(PosY.Text);
        }
        //Seleccionar el Colo
        public void SelectColor(PictureBox picColor)
        {
            mPen.Color = picColor.BackColor;
        }
        public void DrawMyPoint(PictureBox picCanvas)
        {
            //Habilitar el Lienzo en el pictureBox del Formulario
            mGraph = picCanvas.CreateGraphics();
            try
            {
                //Dibujar el punto
                mGraph.DrawEllipse(mPen, mPosX, mPosY, 100, 100);
                //Rellenar el fondo con una imagen
                Bitmap image1 = (Bitmap)Image.FromFile(@"C:\Users\Alex\Pictures\logoBayer.png", true);
                TextureBrush texture = new TextureBrush(image1);
                texture.WrapMode = WrapMode.Clamp;
                //mGraph.FillEllipse(texture, mPosX, mPosY, 100, 100);
                mGraph.FillEllipse(texture, new RectangleF(90.0f,100.0f,300,200));
            }catch{
                MessageBox.Show("Error... \nEL archivo no Existe");
            }
        }

        public void SelectWidth(int grosor)
        {

            mPen.Width = grosor;
        }
    }
}

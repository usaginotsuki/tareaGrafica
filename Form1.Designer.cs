
namespace Taller1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbEnviroment = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbPosition = new System.Windows.Forms.GroupBox();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.grbDistance = new System.Windows.Forms.GroupBox();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.grbEnviroment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbPosition.SuspendLayout();
            this.grbDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEnviroment
            // 
            this.grbEnviroment.Controls.Add(this.picCanvas);
            this.grbEnviroment.Location = new System.Drawing.Point(12, 121);
            this.grbEnviroment.Name = "grbEnviroment";
            this.grbEnviroment.Size = new System.Drawing.Size(773, 317);
            this.grbEnviroment.TabIndex = 0;
            this.grbEnviroment.TabStop = false;
            this.grbEnviroment.Text = "Entorno";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(7, 20);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(760, 291);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            // 
            // grbPosition
            // 
            this.grbPosition.Controls.Add(this.txtPosY);
            this.grbPosition.Controls.Add(this.txtPosX);
            this.grbPosition.Controls.Add(this.lblPosY);
            this.grbPosition.Controls.Add(this.lblPosX);
            this.grbPosition.Location = new System.Drawing.Point(645, 12);
            this.grbPosition.Name = "grbPosition";
            this.grbPosition.Size = new System.Drawing.Size(140, 103);
            this.grbPosition.TabIndex = 1;
            this.grbPosition.TabStop = false;
            this.grbPosition.Text = "Posiciones";
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(8, 32);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(17, 13);
            this.lblPosX.TabIndex = 0;
            this.lblPosX.Text = "X:";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(8, 58);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(17, 13);
            this.lblPosY.TabIndex = 1;
            this.lblPosY.Text = "Y:";
            this.lblPosY.Click += new System.EventHandler(this.lblPosY_Click);
            // 
            // txtPosX
            // 
            this.txtPosX.Enabled = false;
            this.txtPosX.Location = new System.Drawing.Point(31, 29);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(100, 20);
            this.txtPosX.TabIndex = 2;
            // 
            // txtPosY
            // 
            this.txtPosY.Enabled = false;
            this.txtPosY.Location = new System.Drawing.Point(31, 55);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(100, 20);
            this.txtPosY.TabIndex = 3;
            // 
            // grbDistance
            // 
            this.grbDistance.Controls.Add(this.txtWidth);
            this.grbDistance.Controls.Add(this.btnTriangle);
            this.grbDistance.Location = new System.Drawing.Point(12, 12);
            this.grbDistance.Name = "grbDistance";
            this.grbDistance.Size = new System.Drawing.Size(169, 100);
            this.grbDistance.TabIndex = 2;
            this.grbDistance.TabStop = false;
            this.grbDistance.Text = "Lado del Triangulo";
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(42, 55);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.Text = "Triangulo";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(7, 25);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(156, 20);
            this.txtWidth.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.grbDistance);
            this.Controls.Add(this.grbPosition);
            this.Controls.Add(this.grbEnviroment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbEnviroment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbPosition.ResumeLayout(false);
            this.grbPosition.PerformLayout();
            this.grbDistance.ResumeLayout(false);
            this.grbDistance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEnviroment;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbPosition;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.GroupBox grbDistance;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnTriangle;
    }
}


namespace Cripto
{
    partial class BtnMonedero
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PnlMonedero = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.LblAbreviatura = new System.Windows.Forms.Label();
            this.LblCantidadUsd = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.guna2TaskBarProgress1 = new Guna.UI2.WinForms.Guna2TaskBarProgress(this.components);
            this.PnlMonedero.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMonedero
            // 
            this.PnlMonedero.BorderRadius = 12;
            this.PnlMonedero.Controls.Add(this.LblAbreviatura);
            this.PnlMonedero.Controls.Add(this.LblCantidadUsd);
            this.PnlMonedero.Controls.Add(this.LblNombre);
            this.PnlMonedero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMonedero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(220)))), ((int)(((byte)(251)))));
            this.PnlMonedero.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(159)))), ((int)(((byte)(228)))));
            this.PnlMonedero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlMonedero.Location = new System.Drawing.Point(0, 0);
            this.PnlMonedero.Name = "PnlMonedero";
            this.PnlMonedero.Padding = new System.Windows.Forms.Padding(4);
            this.PnlMonedero.Size = new System.Drawing.Size(250, 150);
            this.PnlMonedero.TabIndex = 0;
            // 
            // LblAbreviatura
            // 
            this.LblAbreviatura.BackColor = System.Drawing.Color.Transparent;
            this.LblAbreviatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAbreviatura.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbreviatura.Location = new System.Drawing.Point(4, 37);
            this.LblAbreviatura.Name = "LblAbreviatura";
            this.LblAbreviatura.Size = new System.Drawing.Size(242, 90);
            this.LblAbreviatura.TabIndex = 4;
            this.LblAbreviatura.Text = "Cant + Abrev";
            this.LblAbreviatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAbreviatura.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // LblCantidadUsd
            // 
            this.LblCantidadUsd.BackColor = System.Drawing.Color.Transparent;
            this.LblCantidadUsd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblCantidadUsd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadUsd.Location = new System.Drawing.Point(4, 127);
            this.LblCantidadUsd.Margin = new System.Windows.Forms.Padding(0);
            this.LblCantidadUsd.Name = "LblCantidadUsd";
            this.LblCantidadUsd.Size = new System.Drawing.Size(242, 19);
            this.LblCantidadUsd.TabIndex = 3;
            this.LblCantidadUsd.Text = "Cantidad USD";
            this.LblCantidadUsd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LblCantidadUsd.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(4, 4);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.LblNombre.Size = new System.Drawing.Size(242, 33);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre Cripto";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            // 
            // guna2TaskBarProgress1
            // 
            this.guna2TaskBarProgress1.TargetForm = null;
            // 
            // BtnMonedero
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PnlMonedero);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "BtnMonedero";
            this.Size = new System.Drawing.Size(250, 150);
            this.PnlMonedero.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel PnlMonedero;
        private Guna.UI2.WinForms.Guna2TaskBarProgress guna2TaskBarProgress1;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCantidadUsd;
        private System.Windows.Forms.Label LblAbreviatura;
    }
}

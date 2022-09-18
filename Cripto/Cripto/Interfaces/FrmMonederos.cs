using Cripto.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cripto.Interfaces
{
    public partial class FrmMonederos : Form
    {
        private readonly FrmCotizaciones frmCotizaciones;
        private readonly MonederosServicio monederosServicio;

        public FrmMonederos(FrmCotizaciones _cotizaciones)
        {
            frmCotizaciones = _cotizaciones;
            monederosServicio = new MonederosServicio();
            InitializeComponent();
        }

        private void FrmMonederos_Load(object sender, EventArgs e)
        {
            PnlMonedero.Controls.Clear();
            CargarMonederos(PnlMonedero);
        }

        private void CargarMonederos(FlowLayoutPanel panel)
        {
            // monederos = Lista con todos los monederos 0 id, 1 usu, 2 saldo
            var monederos = monederosServicio.GetMonederos();

            BtnMonedero btn = new BtnMonedero();
            btn.ItemNombre = monederos[0].ToString();
            btn.ItemAbreviatura = "ETH";
            btn.ItemCantidad = "$" + monederos[2].ToString();
            if (monederos[0].ToString() != String.Empty)
            {
                panel.Controls.Add(btn);
            }
        }

        private void CerrarFormulario()
        {
            frmCotizaciones.Show();
            Dispose();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonederos));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.BtnEstadisticas = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMonedero = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTransacciones = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCotizaciones = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SdwFrmMonedero = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.BtnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMonedero1 = new Cripto.BtnMonedero();
            this.btnMonedero2 = new Cripto.BtnMonedero();
            this.btnMonedero3 = new Cripto.BtnMonedero();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.BtnVolver);
            this.guna2Panel1.Controls.Add(this.guna2TextBox2);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.BtnEstadisticas);
            this.guna2Panel1.Controls.Add(this.BtnMonedero);
            this.guna2Panel1.Controls.Add(this.BtnTransacciones);
            this.guna2Panel1.Controls.Add(this.BtnCotizaciones);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 742);
            this.guna2Panel1.TabIndex = 1;
            // 
            // BtnVolver
            // 
            this.BtnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnVolver.FillColor = System.Drawing.Color.Transparent;
            this.BtnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnVolver.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnVolver.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolver.Image")));
            this.BtnVolver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnVolver.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnVolver.Location = new System.Drawing.Point(10, 645);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(180, 45);
            this.BtnVolver.TabIndex = 5;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "U Wallet";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox2.Location = new System.Drawing.Point(0, 118);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(200, 50);
            this.guna2TextBox2.TabIndex = 2;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(15, 22);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(167, 107);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // BtnEstadisticas
            // 
            this.BtnEstadisticas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEstadisticas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEstadisticas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEstadisticas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEstadisticas.FillColor = System.Drawing.Color.Transparent;
            this.BtnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnEstadisticas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnEstadisticas.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnEstadisticas.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.BtnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("BtnEstadisticas.Image")));
            this.BtnEstadisticas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnEstadisticas.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnEstadisticas.Location = new System.Drawing.Point(10, 545);
            this.BtnEstadisticas.Name = "BtnEstadisticas";
            this.BtnEstadisticas.Size = new System.Drawing.Size(180, 45);
            this.BtnEstadisticas.TabIndex = 4;
            this.BtnEstadisticas.Text = "Estadísticas";
            // 
            // BtnMonedero
            // 
            this.BtnMonedero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMonedero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMonedero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMonedero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMonedero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnMonedero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnMonedero.ForeColor = System.Drawing.Color.White;
            this.BtnMonedero.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnMonedero.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnMonedero.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.BtnMonedero.Image = ((System.Drawing.Image)(resources.GetObject("BtnMonedero.Image")));
            this.BtnMonedero.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMonedero.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnMonedero.Location = new System.Drawing.Point(10, 445);
            this.BtnMonedero.Name = "BtnMonedero";
            this.BtnMonedero.Size = new System.Drawing.Size(180, 45);
            this.BtnMonedero.TabIndex = 3;
            this.BtnMonedero.Text = "Monedero";
            // 
            // BtnTransacciones
            // 
            this.BtnTransacciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransacciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnTransacciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnTransacciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnTransacciones.FillColor = System.Drawing.Color.Transparent;
            this.BtnTransacciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnTransacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnTransacciones.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnTransacciones.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnTransacciones.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.BtnTransacciones.Image = ((System.Drawing.Image)(resources.GetObject("BtnTransacciones.Image")));
            this.BtnTransacciones.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTransacciones.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnTransacciones.Location = new System.Drawing.Point(10, 345);
            this.BtnTransacciones.Name = "BtnTransacciones";
            this.BtnTransacciones.Size = new System.Drawing.Size(180, 45);
            this.BtnTransacciones.TabIndex = 2;
            this.BtnTransacciones.Text = "Transacciones";
            // 
            // BtnCotizaciones
            // 
            this.BtnCotizaciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCotizaciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCotizaciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCotizaciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCotizaciones.FillColor = System.Drawing.Color.Transparent;
            this.BtnCotizaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnCotizaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.BtnCotizaciones.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.BtnCotizaciones.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCotizaciones.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.BtnCotizaciones.Image = ((System.Drawing.Image)(resources.GetObject("BtnCotizaciones.Image")));
            this.BtnCotizaciones.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCotizaciones.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnCotizaciones.Location = new System.Drawing.Point(10, 245);
            this.BtnCotizaciones.Name = "BtnCotizaciones";
            this.BtnCotizaciones.Size = new System.Drawing.Size(180, 45);
            this.BtnCotizaciones.TabIndex = 1;
            this.BtnCotizaciones.Text = "Cotizaciones";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 165);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(205, 12);
            this.guna2Separator1.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMinimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMinimizar.ForeColor = System.Drawing.Color.White;
            this.BtnMinimizar.HoverState.FillColor = System.Drawing.Color.LightSteelBlue;
            this.BtnMinimizar.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(915, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(39, 30);
            this.BtnMinimizar.TabIndex = 7;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.HoverState.FillColor = System.Drawing.Color.Red;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(960, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(39, 30);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.AnimationSpeed = 0.2F;
            this.guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(858, 600);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.guna2CircleProgressBar1.TabIndex = 8;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.Value = 70;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.guna2Panel2.Location = new System.Drawing.Point(228, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(639, 156);
            this.guna2Panel2.TabIndex = 9;
            // 
            // btnMonedero1
            // 
            this.btnMonedero1.ForeColor = System.Drawing.Color.White;
            this.btnMonedero1.ItemAbreviatura = "78496 ETH";
            this.btnMonedero1.ItemCantidad = "800 USD";
            this.btnMonedero1.ItemNombre = "Ethereum";
            this.btnMonedero1.Location = new System.Drawing.Point(206, 201);
            this.btnMonedero1.MonederoID = null;
            this.btnMonedero1.Name = "btnMonedero1";
            this.btnMonedero1.Size = new System.Drawing.Size(250, 150);
            this.btnMonedero1.TabIndex = 10;
            // 
            // btnMonedero2
            // 
            this.btnMonedero2.ForeColor = System.Drawing.Color.White;
            this.btnMonedero2.ItemAbreviatura = "78496 ETH";
            this.btnMonedero2.ItemCantidad = "800 USD";
            this.btnMonedero2.ItemNombre = "Ethereum";
            this.btnMonedero2.Location = new System.Drawing.Point(471, 201);
            this.btnMonedero2.MonederoID = null;
            this.btnMonedero2.Name = "btnMonedero2";
            this.btnMonedero2.Size = new System.Drawing.Size(250, 150);
            this.btnMonedero2.TabIndex = 11;
            // 
            // btnMonedero3
            // 
            this.btnMonedero3.ForeColor = System.Drawing.Color.White;
            this.btnMonedero3.ItemAbreviatura = "78496 ETH";
            this.btnMonedero3.ItemCantidad = "800 USD";
            this.btnMonedero3.ItemNombre = "Ethereum";
            this.btnMonedero3.Location = new System.Drawing.Point(738, 201);
            this.btnMonedero3.MonederoID = null;
            this.btnMonedero3.Name = "btnMonedero3";
            this.btnMonedero3.Size = new System.Drawing.Size(250, 150);
            this.btnMonedero3.TabIndex = 12;
            // 

            // 
            // FrmMonederos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 742);
            this.Controls.Add(this.btnMonedero3);
            this.Controls.Add(this.btnMonedero2);
            this.Controls.Add(this.btnMonedero1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMonederos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monederos";
            this.Load += new System.EventHandler(this.FrmMonederos_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

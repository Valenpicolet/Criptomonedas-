using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cripto
{
    public partial class BtnMonedero : UserControl
    {
        public string MonederoID { get; set; }
        public string ItemNombre
        {
            get { return LblNombre.Text; }
            set { LblNombre.Text = value; }
        }
        public string ItemAbreviatura
        {
            get { return LblAbreviatura.Text; }
            set { LblAbreviatura.Text = value; }
        }        
        public string ItemCantidad
        {
            get { return LblCantidadUsd.Text; }
            set { LblCantidadUsd.Text = value; }
        }
        

        public BtnMonedero()
        {
            InitializeComponent();
        }

        private void LblNombre_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            
        }

    }
}

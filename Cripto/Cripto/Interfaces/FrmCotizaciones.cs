using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using Cripto.Interfaces;

namespace Cripto
{
    public partial class FrmCotizaciones : Form
    {

        public FrmCotizaciones()
        {

            InitializeComponent();
        }


        private void FrmCotizaciones_Load(object sender, EventArgs e)
        {
            SdwFrmCotizacion.SetShadowForm(this);

            //ArrayList x = new ArrayList {0, 1, 2, 3, 4, 5, 6, 7 };
            //ArrayList y = new ArrayList {6, 1, 5, 3, 1, 4, 9, 5 };

            //ArrayList x1 = new ArrayList {0, 1, 2, 3, 4, 5, 6, 7 };
            //ArrayList y1 = new ArrayList {9, 3, 3, 3, 9, 4, 9, 5 };

            //ArrayList x2 = new ArrayList {0, 1, 2, 3, 4, 5, 6, 7 };
            //ArrayList y2 = new ArrayList {4, 1, 5, 3, 1, 4, 9, 5 };

            //ArrayList x3 = new ArrayList {0, 1, 2, 3, 4, 5, 6, 7 };
            //ArrayList y3 = new ArrayList {2, 1, 5, 1, 1, 4, 6, 7 };

            //chart1.Series[0].Points.DataBindXY(x, y);
            //chart1.Series[1].Points.DataBindXY(x1, y1);
            //chart1.Series[2].Points.DataBindXY(x2, y2);
            //chart1.Series[3].Points.DataBindXY(x3, y3);

            DvgCotizaciones.Rows.Add(2);
            DvgCotizaciones.Rows[0].Cells[0].Value = Image.FromFile(@"C:\Users\Usuario\Documents\Mis Documentos Viejo\Valentina\facu\PAV1\Cripto\Cripto\Recursos\ethereum_icon.png");
            DvgCotizaciones.Rows[0].Cells[1].Value = "Ethereum";
            DvgCotizaciones.Rows[1].Cells[1].Value = "Bitcoin";
            DvgCotizaciones.Rows[1].Cells[0].Value = Image.FromFile(@"C:\Users\Usuario\Documents\Mis Documentos Viejo\Valentina\facu\PAV1\Cripto\Cripto\Recursos\2845693_bitcoin_cryptocurrency_line_template_icon.png");
        }

        private void BtnMonedero_Click(object sender, EventArgs e)
        {
            var frmMonedero = new FrmMonederos(this);
            frmMonedero.Show(); ;
            this.Hide();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

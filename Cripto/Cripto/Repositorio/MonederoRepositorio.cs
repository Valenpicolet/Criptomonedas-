using Cripto.Servicios;
using Pav.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto.Repositorio
{
    public class MonederoRepositorio
    {
        public List<Monedero> GetMonederos()
        {
            var monederos = new List<Monedero>();
            var sql = $"SELECT m.* FROM Monederos m";
            var tablaResultados = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablaResultados.Rows)
            {
                var _monedero = new Monedero();
                // Info Cripto Moneda
                _monedero.Id_cripto = Convert.ToInt64(fila["id_cripto"].ToString());

                // Info Usuario
                _monedero.Id_usuario = Convert.ToInt64(fila["id_usuario"].ToString());
                _monedero.Saldo = Convert.ToInt64(fila["saldo"].ToString());
                

                monederos.Add(_monedero);
            }
            return monederos;

        }
    }
}

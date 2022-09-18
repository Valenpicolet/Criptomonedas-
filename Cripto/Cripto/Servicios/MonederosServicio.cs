using Cripto.Repositorio;
using Pav.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto.Servicios
{
    public class MonederosServicio
    {
        private readonly MonederoRepositorio monederosRepositorio;

        public MonederosServicio()
        {
            monederosRepositorio = new MonederoRepositorio();
        }

        public List<Monedero> GetMonederos()
        {
            return monederosRepositorio.GetMonederos();
        }

    }
}

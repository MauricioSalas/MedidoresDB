using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class MedidorDALDB : IMedidorDALDB
    {
        private MedidoresDBEntities medidoresEnt = new MedidoresDBEntities();
        public void AgregarMedidores(Medidor medidor)
        {
            this.medidoresEnt.Medidors.Add(medidor);
            this.medidoresEnt.SaveChanges();
        }
        public List<Medidor> ObtenerMedidores()
        {
            return this.medidoresEnt.Medidors.ToList();
        }
    }
}

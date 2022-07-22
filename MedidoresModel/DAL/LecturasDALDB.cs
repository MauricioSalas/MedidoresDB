using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class LecturasDALDB : ILecturasDALDB
    {
        private MedidoresDBEntities medidoresEnt = new MedidoresDBEntities();
        public void AgregarLectura(Lectura lectura)
        {
            this.medidoresEnt.Lecturas.Add(lectura);
            this.medidoresEnt.SaveChanges();
        }

        public List<Lectura> ObtenerLecturas()
        {
            return this.medidoresEnt.Lecturas.ToList();
        }

        public List<Lectura> ObtenerLecturas(int codigoMedidor)
        {
            //LINQ
            var query = from a in medidoresEnt.Lecturas where a.IdMedidor == codigoMedidor select a;
            return query.ToList();
        }
    }
}

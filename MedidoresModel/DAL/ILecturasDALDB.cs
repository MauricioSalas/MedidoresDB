using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturasDALDB
    {
        List<Lectura> ObtenerLecturas();
        void AgregarLectura(Lectura lectura);
        List<Lectura> ObtenerLecturas(int codigoMedidor);
    }
}

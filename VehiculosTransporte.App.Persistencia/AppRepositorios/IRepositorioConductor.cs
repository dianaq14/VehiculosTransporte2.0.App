using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public interface IRepositorioConductor
    {
        IEnumerable<Conductor> GetAllConductores();
        Conductor AddConductor(Conductor conductor);
        Conductor UpdateConductor(Conductor conductor);
        void DeleteConductor(int idConductor);    
        Conductor GetConductor(int idConductor);
       
    }


}
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public class RepositorioConductor : IRepositorioConductor
    {
        private readonly AppContext _appContext;

        //CONSTRUCTOR
        public RepositorioConductor(AppContext appContext)
        {
            _appContext = appContext;
        }
        //se implementan los metodos IRepositorioConductor

        //Metodo Agregar
        Conductor IRepositorioConductor.AddConductor(Conductor conductor)
        {
            var ConductorAdicionado = _appContext.Conductores.Add(conductor);
            _appContext.SaveChanges();
            return ConductorAdicionado.Entity;
        }

        //Metodo Eliminar
        void IRepositorioConductor.DeleteConductor(int idConductor)
        {
            var conductorEncontrado = _appContext.Conductores.FirstOrDefault(c => c.Id == idConductor);
            if (conductorEncontrado == null)
                return;
            _appContext.Conductores.Remove(conductorEncontrado);
            _appContext.SaveChanges();
        }

        //Metodo
        IEnumerable<Conductor> IRepositorioConductor.GetAllConductores()
        {
            return _appContext.Conductores;
        }

        //Metodo

        Conductor IRepositorioConductor.GetConductor(int idConductor)
        {
            return _appContext.Conductores.SingleOrDefault(c => c.Id == idConductor);
        }

        //Metodo
        Conductor IRepositorioConductor.UpdateConductor(Conductor conductor)
        {
            var conductorEncontrado = _appContext.Conductores.FirstOrDefault(c => c.Id == conductor.Id);
            if (conductorEncontrado != null)
            {
                conductorEncontrado.Nombres = conductor.Nombres;
                conductorEncontrado.Apellidos = conductor.Apellidos;
                conductorEncontrado.Correo = conductor.Correo;
                conductorEncontrado.Telefono = conductor.Telefono;
                conductorEncontrado.LicenciaConduccion = conductor.LicenciaConduccion;

                _appContext.SaveChanges();
            }
           return conductorEncontrado;
        }

    }
}

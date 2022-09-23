using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public class RepositorioDuenio : IRepositorioDuenio
    {
        ///<summary>
        ///Referencia al contexto de JefeOperaciones
        ///<summary>

        private readonly AppContext _appContext;

        //CONSTRUCTOR
        public RepositorioDuenio(AppContext appContext)
        {
            _appContext = appContext;
        }
        //se implementan los metodos IRepositorioDueno

        //Metodo Agregar
        public Duenio AddDuenio(Duenio duenio)
        {
            var DuenioAdicionado = _appContext.Duenios.Add(duenio);
            _appContext.SaveChanges();
            return DuenioAdicionado.Entity;
        }

        //Metodo Eliminar
        public void DeleteDuenio(int idDuenio)
        {
            var duenioEncontrado = _appContext.Duenios.FirstOrDefault(d => d.Id == idDuenio);
            if (duenioEncontrado == null)
                return;
            _appContext.Duenios.Remove(duenioEncontrado);
            _appContext.SaveChanges();
        }

        //Metodo
        public IEnumerable<Duenio> GetAllDuenios()
        {
            return _appContext.Duenios;
        }

        //Metodo
        public Duenio GetDuenio(int idDuenio)
        {
            return _appContext.Duenios.FirstOrDefault(d => d.Id == idDuenio);
        }

        //Metodo
        public Duenio UpdateDuenio(Duenio duenio)
        {
            var duenioEncontrado = _appContext.Duenios.FirstOrDefault(d => d.Id == duenio.Id);
            if (duenioEncontrado != null)
            {
                duenioEncontrado.Nombres = duenio.Nombres;
                duenioEncontrado.Apellidos = duenio.Apellidos;
                duenioEncontrado.Correo = duenio.Correo;
                duenioEncontrado.Telefono = duenio.Telefono;

                _appContext.SaveChanges();
            }
            return duenioEncontrado;
        }

    }
}

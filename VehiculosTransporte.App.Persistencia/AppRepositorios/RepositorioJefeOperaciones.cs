using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{

    public class RepositorioJefeOperaciones : IRepositorioJefeOperaciones
    {
        ///<summary>
        ///Referencia al contexto de JefeOperaciones
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo constructor 
        ///Inyeccion depencias para indicar el contexto a usar
        ///</summary>
        ///<param name="appContext"></param>//


        public RepositorioJefeOperaciones(AppContext appContext)
        {
            _appContext = appContext;
        }
        JefeOperaciones IRepositorioJefeOperaciones.AddJefeOperaciones(JefeOperaciones jefeOperaciones)
        {
            var JefeOperacionesAdicionado = _appContext.JefesOperaciones.Add(jefeOperaciones);
            _appContext.SaveChanges();
            return JefeOperacionesAdicionado.Entity;
        }
        IEnumerable<JefeOperaciones>  IRepositorioJefeOperaciones.GetAllJefesOperaciones()
        {
            return _appContext.JefesOperaciones;
        }

        JefeOperaciones IRepositorioJefeOperaciones.UpdateJefeOperaciones(JefeOperaciones jefeOperaciones)
        {
            var JefeOperacionesEncontrado = _appContext.JefesOperaciones.FirstOrDefault(p => p.Id == jefeOperaciones.Id);
            if (JefeOperacionesEncontrado != null)
            {
                JefeOperacionesEncontrado.Nombres = jefeOperaciones.Nombres;
                JefeOperacionesEncontrado.Apellidos = jefeOperaciones.Apellidos;
                JefeOperacionesEncontrado.Correo = jefeOperaciones.Correo;
                JefeOperacionesEncontrado.Telefono = jefeOperaciones.Telefono;

                _appContext.SaveChanges();
            }
            return JefeOperacionesEncontrado;
        }
        JefeOperaciones IRepositorioJefeOperaciones.GetJefeOperaciones(int idJefeOperaciones)
        {
            return _appContext.JefesOperaciones.FirstOrDefault(p => p.Id == idJefeOperaciones);
        }
        void IRepositorioJefeOperaciones.DeleteJefeOperaciones(int idJefeOperaciones)
        {
            var JefeOperacionesEncontrado = _appContext.JefesOperaciones.FirstOrDefault(p => p.Id == idJefeOperaciones);
            if (JefeOperacionesEncontrado == null)
                return;
            _appContext.JefesOperaciones.Remove(JefeOperacionesEncontrado);
            _appContext.SaveChanges();
        }
    }


}
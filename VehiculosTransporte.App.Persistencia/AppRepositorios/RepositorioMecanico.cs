using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;


namespace VehiculosTransporte.App.Persistencia
{
public class RepositorioMecanico : IRepositorioMecanico
    {
        ///<summary>
        ///Referencia al contexto de JefeOperaciones
        ///<summary>

        private readonly AppContext _appContext;

        //CONSTRUCTOR
        public RepositorioMecanico(AppContext appContext)
        {
            _appContext = appContext;
        }
        //se implementan los metodos IRepositorioDueno

        //Metodo Agregar
        public Mecanico AddMecanico(Mecanico mecanico)
        {
            var MecanicoAdicionado = _appContext.Mecanicos.Add(mecanico);
            _appContext.SaveChanges();
            return MecanicoAdicionado.Entity;
        }

        //Metodo Eliminar
        public void DeleteMecanico(int idMecanico)
        {
            var mecanicoEncontrado = _appContext.Mecanicos.FirstOrDefault(m => m.Id == idMecanico);
            if (mecanicoEncontrado == null)
                return;
            _appContext.Mecanicos.Remove(mecanicoEncontrado);
            _appContext.SaveChanges();
        }

        //Metodo
        public IEnumerable<Mecanico> GetAllMecanicos()
        {
            return _appContext.Mecanicos;
        }

        //Metodo
        public Mecanico GetMecanico(int idMecanico)
        {
            return _appContext.Mecanicos.FirstOrDefault(m => m.Id == idMecanico);
        }

        //Metodo
        public Mecanico UpdateMecanico(Mecanico mecanico)
        {
            var mecanicoEncontrado = _appContext.Mecanicos.FirstOrDefault(m => m.Id == mecanico.Id);
            if (mecanicoEncontrado != null)
            {
                mecanicoEncontrado.Nombres = mecanico.Nombres;
                mecanicoEncontrado.Apellidos = mecanico.Apellidos;
                mecanicoEncontrado.Correo = mecanico.Correo;
                mecanicoEncontrado.Telefono = mecanico.Telefono;

                _appContext.SaveChanges();
            }
            return mecanicoEncontrado;
        }

    }
}



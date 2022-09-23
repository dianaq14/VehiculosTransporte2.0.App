using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public class RespositorioRevision:IRespositorioRevision 
    {
        private readonly AppContext _appContext;
        
        public RespositorioRevision(AppContext appContext)
        {
            _appContext=appContext; 
        }

        Revision IRespositorioRevision.AddRevision(Revision revision)
        {
            var revisionAdicionado= _appContext.Revisiones.Add(revision);
            _appContext.SaveChanges();
            return revisionAdicionado.Entity;
            
        }

        
        void IRespositorioRevision.DeleteRevision(int  idRevision)
        {
            var RevisionEncontrado=_appContext.Revisiones.FirstOrDefault(p => p.Id==idRevision) ;
            if (RevisionEncontrado==null) 
                return;
            _appContext.Revisiones.Remove(RevisionEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Revision> IRespositorioRevision.GetallIRevision()
        {
            return _appContext.Revisiones;
        }

        Revision IRespositorioRevision.GetRevision(int  idRevision)
        {
            return  _appContext.Revisiones.FirstOrDefault(p => p.Id==idRevision) ;
        }

        Revision IRespositorioRevision.UpdateRevision(Revision revision)
        {
        var revisionesEncontrado=_appContext.Revisiones.FirstOrDefault(p => p.Id== revision.Id) ;
        if(revisionesEncontrado != null)
        {
            revisionesEncontrado.NivelAceite = revision.NivelAceite;
            revisionesEncontrado.NivelLiquidoFrenos = revision.NivelLiquidoFrenos;
            revisionesEncontrado.NivelRefrigerante = revision.NivelRefrigerante;
            revisionesEncontrado.NivelLiquidoDireccion = revision.NivelLiquidoDireccion;
            revisionesEncontrado.Repuestos = revision.Repuestos;
            revisionesEncontrado.FechaRevision = revision.FechaRevision;
            revisionesEncontrado.ValorRepuestos = revision.ValorRepuestos;
            revisionesEncontrado.Vehiculo = revision.Vehiculo;
            
            _appContext.SaveChanges();
        
        }
        return revisionesEncontrado;
        }

    }
}
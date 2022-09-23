using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia 

{
public interface IRespositorioRevision
{
    IEnumerable <Revision> GetallIRevision();
    Revision AddRevision (Revision revision);
    Revision UpdateRevision(Revision revision);
    void DeleteRevision (int idRevision);
    Revision GetRevision(int idRevision); 

} 
}
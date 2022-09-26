using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehiculosTransporte.App.Dominio;
using VehiculosTransporte.App.Persistencia;

namespace VehiculosTransporte.App.Frontend.Pages
{
    public class ListaConductoresModel : PageModel
    {
        private static IRepositorioConductor _repoConductor = new RepositorioConductor(new Persistencia.AppContext());
        public IEnumerable<Conductor> listaConductores { get; set; }
        public void OnGet()
        {
            listaConductores = _repoConductor.GetAllConductores();
        }
    }
}

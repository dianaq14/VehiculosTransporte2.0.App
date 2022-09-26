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
    public class ListaDueniosModel : PageModel
    {
        private static IRepositorioDuenio _repoDuenio =new RepositorioDuenio(new Persistencia.AppContext());
        public IEnumerable<Duenio>listaDuenios {get; set;}
        public void OnGet()
        {
            listaDuenios = _repoDuenio.GetAllDuenios();
        }
    }
}
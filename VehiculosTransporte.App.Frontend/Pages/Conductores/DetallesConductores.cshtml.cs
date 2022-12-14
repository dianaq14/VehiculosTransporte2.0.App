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
    public class DetallesConductoresModel : PageModel
    {
        private readonly IRepositorioConductor _repoConductor;
        public Conductor conductor { get; set; }
        public DetallesConductoresModel()
        {
            this._repoConductor = new RepositorioConductor(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int conductorId)
        {
            conductor = _repoConductor.GetConductor(conductorId);
            if (conductor == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}

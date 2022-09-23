using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehiculosTransporte.App.Persistencia;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Frontend.Pages
{
    public class DetallesConductoresModel : PageModel
    {
        private readonly IRepositorioConductor repositorioConductor;
        public Conductor Conductor { get; set; }
        public DetallesConductoresModel(IRepositorioConductor repositorioConductor)
        {
            this.repositorioConductor = repositorioConductor;
        }
        public IActionResult OnGet(int conductorId)
        {
            Conductor = repositorioConductor.GetConductor(conductorId);
            if (Conductor == null)
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

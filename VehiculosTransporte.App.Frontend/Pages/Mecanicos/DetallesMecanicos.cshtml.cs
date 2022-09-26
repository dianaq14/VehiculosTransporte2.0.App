using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehiculosTransporte.App.Dominio;
using VehiculosTransporte.App.Persistencia;

namespace VehiculosTransporte.App.Frontend.Pages
{
    public class DetallesMecanicosModel : PageModel
    {
        private readonly IRepositorioMecanico _RepoMecanico;
        public Mecanico mecanico {get; set;}
        public DetallesMecanicosModel(){
            this._RepoMecanico = new RepositorioMecanico(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int MecanicoID)
        {
            mecanico = _RepoMecanico.GetMecanico(MecanicoID);
            if(mecanico == null)
            {
                return RedirectToPage("./NOTFOUND");
            }
            else
            {
                return Page();
            }
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehiculosTransporte.App.Persistencia;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Frontend.Pages
{
    public class LogInModel : PageModel
    {
         public string tituLogin { get; set; }

        public void OnGet()
        {
            tituLogin = "Inicio de Sesión";
        }
    }
}
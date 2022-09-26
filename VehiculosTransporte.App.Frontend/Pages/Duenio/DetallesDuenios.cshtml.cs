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
    public class DetallesDueniosModel : PageModel
    {
        public void OnGet()
        {
            duenio = _RepoDuenio.GetDuenio(DuenioId);
            if(duenio == null)
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
        
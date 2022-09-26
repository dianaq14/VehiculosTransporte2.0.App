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
    public class EditarDueniosModel : PageModel
    {
        private readonly IRepositorioDuenio _repoDuenio;
        [BindProperty]
        public Duenio duenio {get; set;}
        public EditarDueniosModel()
        {
            this._repoDuenio = new RepositorioDuenio(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int? duenioId)
        {
            if(duenioId.HasValue)
            {
                duenio = _repoDuenio.GetDuenio(duenioId.Value);
            }
            else
            {
                duenio = new Duenio();
            }
            if(duenio == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
        public IActionResult  OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if (duenio.Id >0)
            {
                duenio = _repoDuenio.UpdateDuenio(duenio);
            }
            else
            {
                _repoDuenio.AddDuenio( duenio);
            }
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
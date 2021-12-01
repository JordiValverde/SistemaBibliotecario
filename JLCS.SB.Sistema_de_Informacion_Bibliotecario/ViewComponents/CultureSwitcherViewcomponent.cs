using JLCS.SB.Sistema_de_Informacion_Bibliotecario.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Linq;

namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.ViewComponents
{
    //public class CultureSwitcherViewcomponent : ViewComponent
    //{
    //    //private readonly IOptions<RequestLocalizationOptions> localizationOptions;
    //    //public CultureSwitcherViewcomponent(IOptions<RequestLocalizationOptions> localizationOptions) =>
    //    //    this.localizationOptions = localizationOptions;

    //    public IViewComponentResult Invoke()
    //    {
    //        //var cultureFeature = HttpContext.Features.Get<IRequestCultureFeature>();
    //        //var model = new CultureSwitcherModel
    //        //{
    //        //    SupportedCultures = localizationOptions.Value.SupportedUICultures.ToList(),
    //        //    CurrentUICulture = cultureFeature.RequestCulture.UICulture
    //        //};
    //        //return View(model);
    //    }
    //}
}

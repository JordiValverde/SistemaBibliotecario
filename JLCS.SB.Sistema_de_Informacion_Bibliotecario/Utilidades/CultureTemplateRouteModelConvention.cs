using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Utilidades
{
    ///<summary>
    /// Configure {culture?} as first route parameter in the request path
    ///</summary>
    public class CultureTemplateRouteModelConvention : IPageRouteModelConvention
    {
        public void Apply(PageRouteModel model)
        {
            var selectorCount = model.Selectors.Count;
            for (var i = 0; i < selectorCount; i++)
            {
                var selector = model.Selectors[i];
                model.Selectors.Add(new SelectorModel
                {
                    AttributeRouteModel = new AttributeRouteModel
                    {
                        Order = -1,
                        Template = AttributeRouteModel.CombineTemplates(
                      "{culture?}",
                      selector.AttributeRouteModel.Template),
                    }
                });
            }
        }
    }
}

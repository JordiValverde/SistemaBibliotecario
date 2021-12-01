using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Models
{
        public class CultureSwitcherModel
        {
            public CultureInfo CurrentUICulture { get; set; }
            public List<CultureInfo> SupportedCultures { get; set; }
        }
}

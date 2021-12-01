using JLCS.SB.CapaDatos;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using LibreriaInterfaces;
using JLCS.SB.CapaEntidad;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace JLCS.SB.CapaNegocio
{
    public class PrestamoLogica : PrestamoInterface
    {
        private static ApplicationDbContext _context;
       
        public PrestamoLogica(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}

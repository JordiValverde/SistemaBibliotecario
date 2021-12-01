using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Extensions
{
    public enum NotificationType
    {
        Error,
        Info,
        Success
    }
    public class BaseController : Controller
    {
        public void BasicNotification (string msj, NotificationType type , string title = "")
        {
            TempData["notification"] = $" Swal.fire('{title}','{msj}','{type.ToString().ToLower()}')";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario.Servicios
{
    public class CounterHub : Hub
    {
        //public static int contador = 0;
        //public Task OnConnected()
        //{
        //    contador++;
        //    Clients.All.mostrar(contador);
        //    return base.OnConnectedAsync();
        //}
        //public Task OnDisconnected(bool stopCalled)
        //{
        //    contador--;
        //    Clients.All.mostrar(contador);
        //    return base.OnDisconnectedAsync(stopCalled);
        //}
    }
}


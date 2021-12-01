using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace JLCS.SB.Sistema_de_Informacion_Bibliotecario
{
    public static class SessionExtensions
    {
        public static bool? GetBoolean(this ISession session, string key)
        {
            byte[] value;
            var data = session.TryGetValue(key, out value);
            return BitConverter.ToBoolean(value, 0);
        }

        public static void SetBoolean(this ISession session, string key, bool value)
        {
            session.Set(key, BitConverter.GetBytes(value));
        }
    }
}

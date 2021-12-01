using Microsoft.Extensions.Hosting;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace ServiciosBackground
{
    public class IntervalTaskHostedService : IHostedService, IDisposable
    {
        private Timer _timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(SaveFile, null, TimeSpan.Zero, TimeSpan.FromSeconds(10));
            return Task.CompletedTask;
            //throw new NotImplementedException();
        }
        public void SaveFile(object state)
        {
            try
            {
                var randomGenerator = RandomNumberGenerator.Create();
                byte[] data = new byte[16];
                randomGenerator.GetBytes(data);
                string namefile = "a" + BitConverter.ToString(data) + ".txt";
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Temp", namefile);
                File.Create(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("error en el metodo serverfile: " + e);
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
            //throw new NotImplementedException();
        }
        public void Dispose()
        {
            _timer?.Dispose();
        }
    }

}

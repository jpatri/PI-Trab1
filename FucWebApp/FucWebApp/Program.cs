using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PI.WebGarten;
using PI.WebGarten.MethodBasedCommands;

namespace FucWebApp
{
    using Controllers;

    class Program
    {
        static void Main(string[] args)
        {
            var host = new HttpListenerBasedHost("http://localhost:8080/");
            host.Add(DefaultMethodBasedCommandFactory.GetCommandsFor(typeof(Controller)));
            host.OpenAndWaitForever();
        }
    }
}

﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MidwinterConvention.PL
{
    public class LocalEntryPoint
    {
        public static void Main() =>
            WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>()
                .Build()
                .Run();
    }
}

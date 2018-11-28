using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using day_03_workshop.Repositories;
using Microsoft.AspNetCore.Http;

namespace day_03_workshop.Services
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        private IPrinter _printer;
        private IColor _colorPrinter;

        public ConsoleLoggerMiddleware(IPrinter printer)
        {
            _printer = printer;
        }

//        public ConsoleLoggerMiddleware(IColor colorPrinter)
//        {
//            _colorPrinter = colorPrinter;
//        }

        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");

            _printer.Log("hello");

//            _colorPrinter.PrintColor();

            return next(context);
        }
    }
}

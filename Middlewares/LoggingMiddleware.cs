using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;
using MvcStaryApp.Models.Db;
using System.Security.Cryptography.X509Certificates;

namespace MvcStaryApp.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        /// <summary>
        ///  Middleware-компонент должен иметь конструктор, принимающий RequestDelegate
        /// </summary>
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        ///  Необходимо реализовать метод Invoke  или InvokeAsync
        /// </summary>
        public async Task InvokeAsync(HttpContext context, IRequestRepository irequest)
        {
            // Для логирования данных о запросе используем свойста объекта HttpContext
            Console.WriteLine($"[{DateTime.Now}]: New request to http://{context.Request.Host.Value + context.Request.Path}");

            var request = new Request()
            {
                Url = $"New request to http://{context.Request.Host.Value + context.Request.Path}"
            };

            await irequest.addRequest(request);
            // Передача запроса далее по конвейеру
            await _next.Invoke(context);
        }
    }
}

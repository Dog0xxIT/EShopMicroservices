namespace Identity.Api.Middlewares
{
    public class FormatResponseMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await using (var st = context.Response.Body)
            {
            }
        }
    }
}

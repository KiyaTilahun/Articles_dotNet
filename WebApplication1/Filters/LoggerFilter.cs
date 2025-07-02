using Microsoft.AspNetCore.Mvc.Filters;
using WebApplication1.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Filters
{
    public class LoggerFilter:IAsyncActionFilter
    {
        private readonly ILogger<LoggerFilter> _logger;
        private readonly IEmailService _emailService;
     
        public LoggerFilter(ILogger<LoggerFilter> logger,IEmailService emailService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controllerName = context.Controller.GetType().Name;
            var actionName = context.ActionDescriptor.DisplayName; // Or context.ActionDescriptor.RouteValues["action"]

            _logger.LogInformation($"[ActionFilter] Executing action: {actionName} in controller: {controllerName}");
            // throw new NotImplementedException();
        }


        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await _emailService.SendEmailAsync("kk@gmail.com", "to aply", "hey there");
        }
    }
}
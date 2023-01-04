namespace ShoppingCart.Api.BackgroundServices
{
    public class EmailNotificationBackgroundService : BackgroundService
    {
        private readonly IServiceProvider service;
        private readonly ILogger<EmailNotificationBackgroundService> logger;

        public EmailNotificationBackgroundService(IServiceProvider service, ILogger<EmailNotificationBackgroundService> logger)
        {
            this.service = service;
            this.logger = logger;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Service started");

            return base.StartAsync(cancellationToken);
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.LogInformation("Service processing....");

            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = service.CreateScope())
                {
                    //scope.ServiceProvider.GetService<I>

                }
                // Do work
            }

            logger.LogInformation("Service processing completed succesfully");


            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Service stoppeed");

            return base.StopAsync(cancellationToken);
        }
    }
}

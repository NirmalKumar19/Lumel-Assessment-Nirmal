namespace SalesAnalyticsAPI.Services
{
    public class RefreshJob : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;

        public RefreshJob(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = _serviceProvider.CreateScope();
            var importer = scope.ServiceProvider.GetRequiredService<CsvImportService>();
            await importer.ImportAsync("Data/sales.csv"); 
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }

}

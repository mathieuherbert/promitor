using Promitor.Core.Scraping.Configuration.Model.Metrics.Interfaces;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    public class StorageQueueMetricDefinition : IResourceMetricDefinition
    {
        /// <summary>
        ///     Name of the Azure Storage account
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        ///     Name of the queue
        /// </summary>
        public string QueueName { get; set; }

        /// <summary>
        ///     SAS token to authenticate with
        /// </summary>
        public Secret SasToken { get; set; }

        /// <summary>
        ///     Type of resource that is configured
        /// </summary>
        public ResourceType ResourceType { get; } = ResourceType.StorageQueue;
    }
}
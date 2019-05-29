using Promitor.Core.Scraping.Configuration.Model.Metrics.Interfaces;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    public class ServiceBusQueueMetricDefinition : IResourceMetricDefinition
    {
        /// <summary>
        ///     Name of the network interface
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        ///     Name of the network interface
        /// </summary>
        public string QueueName { get; set; }

        /// <summary>
        ///     Type of resource that is configured
        /// </summary>
        public ResourceType ResourceType { get; } = ResourceType.ServiceBusQueue;
    }
}
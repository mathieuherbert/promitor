using Promitor.Core.Scraping.Configuration.Model.Metrics.Interfaces;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    public class NetworkInterfaceMetricDefinition : IResourceMetricDefinition
    {
        /// <summary>
        ///     Name of the network interface
        /// </summary>
        public string NetworkInterfaceName { get; set; }

        /// <summary>
        ///     Type of resource that is configured
        /// </summary>
        public ResourceType ResourceType { get; } = ResourceType.NetworkInterface;
    }
}
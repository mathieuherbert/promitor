using Promitor.Core.Scraping.Configuration.Model.Metrics.Interfaces;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    public class ContainerInstanceMetricDefinition : IResourceMetricDefinition
    {
        /// <summary>
        ///     Container Group
        /// </summary>
        public string ContainerGroup { get; set; }

        /// <summary>
        ///     Type of resource that is configured
        /// </summary>
        public ResourceType ResourceType { get; } = ResourceType.ContainerInstance;
    }
}
using Promitor.Core.Scraping.Configuration.Model.Metrics.Interfaces;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    public class ContainerRegistryMetricDefinition : IResourceMetricDefinition
    {
        /// <summary>
        ///     Name of the Azure Container Registry
        /// </summary>
        public string RegistryName { get; set; }

        /// <summary>
        ///     Type of resource that is configured
        /// </summary>
        public ResourceType ResourceType { get; } = ResourceType.ContainerRegistry;
    }
}
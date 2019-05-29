using Promitor.Core.Scraping.Configuration.Model.Metrics.Interfaces;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    public class CosmosDbMetricDefinition : IResourceMetricDefinition
    {
        /// <summary>
        ///     Name of the Azure Cosmos Db instance
        /// </summary>
        public string DbName { get; set; }

        /// <summary>
        ///     Type of resource that is configured
        /// </summary>
        public ResourceType ResourceType { get; } = ResourceType.CosmosDb;
    }
}
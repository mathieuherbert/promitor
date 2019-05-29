using Promitor.Core.Scraping.Configuration.Model.Metrics.Interfaces;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    public class GenericAzureMetricDefinition : IResourceMetricDefinition
    {
        /// <summary>
        ///     The filter to use to have fine-grained metrics. Example: EntityName eq 'orders'
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        ///     The resource URI of the Azure resource to scrape
        /// </summary>
        public string ResourceUri { get; set; }

        /// <summary>
        ///     Type of resource that is configured
        /// </summary>
        public ResourceType ResourceType { get; } = ResourceType.Generic;
    }
}
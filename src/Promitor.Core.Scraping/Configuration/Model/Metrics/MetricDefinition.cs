using System.Collections.Generic;
using Promitor.Core.Scraping.Configuration.Model.Metrics.Interfaces;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics
{
    public class MetricDefinition
    {
        /// <summary>
        ///     Configuration about the Azure Monitor metric to scrape
        /// </summary>
        public AzureMetricConfiguration AzureMetricConfiguration { get; set; }

        /// <summary>
        ///     Description concerning metric that will be made available in the scraping endpoint
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Name of the metric to use when exposing in the scraping endpoint
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Specify a resource group to scrape that defers from the default resource group.
        ///     This enables you to do multi-resource group scraping with one configuration file.
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        ///     Resources to scrape
        /// </summary>
        public List<IResourceMetricDefinition> Resources { get; set; } = new List<IResourceMetricDefinition>();

        /// <summary>
        /// Gets or sets the scraping model.
        /// </summary>
        public Scraping Scraping { get; set; } = new Scraping();
    }
}

using Promitor.Core.Scraping.Configuration.Model.Metrics.Interfaces;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    public class VirtualMachineMetricDefinition : IResourceMetricDefinition
    {
        /// <summary>
        ///     Name of the virtual machine
        /// </summary>
        public string VirtualMachineName { get; set; }

        /// <summary>
        ///     Type of resource that is configured
        /// </summary>
        public ResourceType ResourceType { get; } = ResourceType.VirtualMachine;
    }
}
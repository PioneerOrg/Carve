using Carve.Plugins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carve.Plugins
{
    public interface IPluginManager
    {
        IEnumerable<PluginDescriptor> AvailablePlugins();
        IEnumerable<FeatureDescriptor> AvailableFeatures();

        PluginDescriptor GetExtension(string id);

        IEnumerable<Feature> LoadFeatures(IEnumerable<FeatureDescriptor> featureDescriptors);

    }

    public static class ExtensionManagerExtensions
    {
        public static IEnumerable<FeatureDescriptor> EnabledFeatures(this IPluginManager extensionManager, ShellDescriptor descriptor)
        {
            return EnabledFeatures(extensionManager, descriptor.Features);
        }

        public static IEnumerable<FeatureDescriptor> EnabledFeatures(this IPluginManager extensionManager, IEnumerable<ShellFeature> features)
        {
            return extensionManager.AvailableFeatures().Where(fd => features.Any(sf => sf.Name == fd.Id));
        }

        public static IEnumerable<FeatureDescriptor> DisabledFeatures(this IPluginManager extensionManager, ShellDescriptor descriptor)
        {
            return extensionManager.AvailableFeatures().Where(fd => descriptor.Features.All(sf => sf.Name != fd.Id));
        }
    }
}

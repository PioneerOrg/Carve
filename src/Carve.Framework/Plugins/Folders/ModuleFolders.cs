using Carve.Plugins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carve.Plugins.Folders
{
    public class ModuleFolders : IPluginFolders
    {
        private readonly IEnumerable<string> _paths;
        private readonly IPluginHarvester _extensionHarvester;

        public ModuleFolders(IEnumerable<string> paths, IPluginHarvester extensionHarvester)
        {
            _paths = paths;
            _extensionHarvester = extensionHarvester;
        }

        public IEnumerable<PluginDescriptor> AvailablePlugins()
        {
            return _extensionHarvester.HarvestPlugins(_paths, DefaultExtensionTypes.Module, "Module.txt", false/*isManifestOptional*/);
        }
    }

}

using Carve.Plugins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carve.Plugins.Folders
{
    public class ThemeFolders : IPluginFolders
    {
        private readonly IEnumerable<string> _paths;
        private readonly IPluginHarvester _pluginHarvester;

        public ThemeFolders(IEnumerable<string> paths, IPluginHarvester pluginHarvester)
        {
            _paths = paths;
            _pluginHarvester = pluginHarvester;
        }

        public IEnumerable<PluginDescriptor> AvailablePlugins()
        {
            return _pluginHarvester.HarvestPlugins(_paths, DefaultExtensionTypes.Theme, "Theme.txt", false/*isManifestOptional*/);
        }
    }
}

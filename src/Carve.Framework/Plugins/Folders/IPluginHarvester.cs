using Carve.Plugins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carve.Plugins.Folders
{
    public interface IPluginHarvester
    {
        IEnumerable<PluginDescriptor> HarvestPlugins(IEnumerable<string> paths, string extensionType, string manifestName, bool manifestIsOptional);

    }
}

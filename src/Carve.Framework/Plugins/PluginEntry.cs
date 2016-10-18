using System;
using System.Collections.Generic;
using System.Reflection;
using Orchard.Environment.Extensions.Models;
using Carve.Plugins.Models;

namespace Carve.Plugins { 
    public class PluginEntry
    {
        public PluginDescriptor Descriptor { get; set; }
        public Assembly Assembly { get; set; }
        public IEnumerable<Type> ExportedTypes { get; set; }
    }
}
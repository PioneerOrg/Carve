﻿using System.Collections.Generic;
using System.Linq;

namespace Carve.Plugins.Models
{
    public class FeatureDescriptor {
        public FeatureDescriptor() {
            Dependencies = Enumerable.Empty<string>();
        }

        public PluginDescriptor Plugin { get; set; }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public IEnumerable<string> Dependencies { get; set; }
    }
}
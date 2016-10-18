using System;
using System.Collections.Generic;

namespace Carve.Plugins.Models
{
    public class Feature {
        public FeatureDescriptor Descriptor { get; set; }
        public IEnumerable<Type> ExportedTypes { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlOptimization.Config.Elements
{
    public class CompressModuleElement : ModuleElementBase
    {
        [ConfigurationProperty("compressionType", DefaultValue = CompressionType.Deflate, IsRequired = false)]
        public CompressionType CompressionType
        {
            get
            {
                return (CompressionType)this["compressionType"];
            }
        }

        [ConfigurationProperty("extensions", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(CompressExtensionCollection), AddItemName = "add")]
        public CompressExtensionCollection Extensions
        {
            get
            {
                return (CompressExtensionCollection)base["extensions"];
            }
        }

    }
}

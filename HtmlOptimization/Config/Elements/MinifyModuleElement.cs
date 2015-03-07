﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlOptimization.Config.Elements
{
    public class MinifyModuleElement : ModuleElementBase
    {
        [ConfigurationProperty("extensions", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ExtensionCollection), AddItemName = "add")]
        public ExtensionCollection Extensions
        {
            get
            {
                return (ExtensionCollection)base["extensions"];
            }
        }
    }
}

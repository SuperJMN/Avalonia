// -----------------------------------------------------------------------
// <copyright file="TemplateContent.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Avalonia.Media;

namespace Avalonia.Controls
{
    public class TemplateContent
    {
        private XamlNodeList nodeList;

        private Dictionary<string, Type> typesByName;

        internal TemplateContent(XamlNodeList nodeList, Dictionary<string, Type> typesByName)
        {
            this.nodeList = nodeList;
            this.typesByName = typesByName;
        }

        internal Type GetTypeForName(string name)
        {
            Type result;

            if (!this.typesByName.TryGetValue(name, out result))
            {
                throw new KeyNotFoundException(string.Format(
                    "Element '{0}' not found in TemplateContent.",
                    name));
            }

            return result;
        }

        internal object Load()
        {
            return XamlReader.Load(this.nodeList.GetReader());
        }
    }
}

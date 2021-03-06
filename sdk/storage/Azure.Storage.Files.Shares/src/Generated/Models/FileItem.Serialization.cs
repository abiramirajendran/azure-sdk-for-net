// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class FileItem
    {
        internal static FileItem DeserializeFileItem(XElement element)
        {
            string name = default;
            FileProperty properties = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("Properties") is XElement propertiesElement)
            {
                properties = FileProperty.DeserializeFileProperty(propertiesElement);
            }
            return new FileItem(name, properties);
        }
    }
}

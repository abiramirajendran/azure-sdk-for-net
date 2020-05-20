// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class Location
    {
        internal static Location DeserializeLocation(JsonElement element)
        {
            string id = default;
            string subscriptionId = default;
            string name = default;
            string displayName = default;
            string regionalDisplayName = default;
            LocationMetadata metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionalDisplayName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    regionalDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = LocationMetadata.DeserializeLocationMetadata(property.Value);
                    continue;
                }
            }
            return new Location(id, subscriptionId, name, displayName, regionalDisplayName, metadata);
        }
    }
}
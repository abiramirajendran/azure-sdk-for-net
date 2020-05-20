// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class DiffDiskSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Option != null)
            {
                writer.WritePropertyName("option");
                writer.WriteStringValue(Option);
            }
            if (Placement != null)
            {
                writer.WritePropertyName("placement");
                writer.WriteStringValue(Placement.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DiffDiskSettings DeserializeDiffDiskSettings(JsonElement element)
        {
            string option = default;
            DiffDiskPlacement? placement = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("option"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    option = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("placement"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    placement = new DiffDiskPlacement(property.Value.GetString());
                    continue;
                }
            }
            return new DiffDiskSettings(option, placement);
        }
    }
}
﻿// <auto-generated />

using System;
using System.Reflection;
using System.Resources;
using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Cosmos.Internal
{
    /// <summary>
    ///		This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public static class CosmosStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Cosmos.Properties.CosmosStrings", typeof(CosmosStrings).GetTypeInfo().Assembly);

        /// <summary>
        ///     The entity of type '{entityType}' is mapped as a part of the document mapped to '{missingEntityType}', but there is no tracked entity of this type with the corresponding key value. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the key values.
        /// </summary>
        public static string OrphanedNestedDocument([CanBeNull] object entityType, [CanBeNull] object missingEntityType)
            => string.Format(
                GetString("OrphanedNestedDocument", nameof(entityType), nameof(missingEntityType)),
                entityType, missingEntityType);

        /// <summary>
        ///     The entity of type '{entityType}' is mapped as a part of the document mapped to '{missingEntityType}', but there is no tracked entity of this type with the key value '{keyValue}'.
        /// </summary>
        public static string OrphanedNestedDocumentSensitive([CanBeNull] object entityType, [CanBeNull] object missingEntityType, [CanBeNull] object keyValue)
            => string.Format(
                GetString("OrphanedNestedDocumentSensitive", nameof(entityType), nameof(missingEntityType), nameof(keyValue)),
                entityType, missingEntityType, keyValue);

        /// <summary>
        ///     No matching discriminator values where found for this instance of '{entityType}'.
        /// </summary>
        public static string UnableToDiscriminate([CanBeNull] object entityType)
            => string.Format(
                GetString("UnableToDiscriminate", nameof(entityType)),
                entityType);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

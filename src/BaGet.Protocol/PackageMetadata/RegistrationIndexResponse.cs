using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BaGet.Protocol
{
    /// <summary>
    /// The metadata for a package and all of its versions.
    /// See: https://docs.microsoft.com/en-us/nuget/api/registration-base-url-resource#registration-index
    /// </summary>
    public class RegistrationIndexResponse
    {
        public static readonly IReadOnlyList<string> DefaultType = new List<string>
        {
            "catalog:CatalogRoot",
            "PackageRegistration",
            "catalog:Permalink"
        };

        [JsonProperty("@type")]
        public IReadOnlyList<string> Type { get; set; }

        /// <summary>
        /// The number of registration pages. See <see cref="Pages"/>. 
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The pages that contain all of the versions of the package, ordered
        /// by the package's version.
        /// </summary>
        [JsonProperty("items")]
        public IReadOnlyList<RegistrationIndexPage> Pages { get; set; }
    }
}
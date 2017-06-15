using System;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace VaultSharp.Backends.Secret.Models.Transit
{
    /// <summary>
    /// Represents the transit encryption key data.
    /// </summary>
    public class TransitEncryptionKeyData
    {
        /// <summary>
        /// Gets or sets the keytype name.
        /// </summary>
        /// <value>
        /// The keytype name.
        /// </value>
        [JsonProperty("name")]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the public key as string.
        /// </summary>
        /// <value>
        /// The public key string.
        /// </value>
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        /// <value>
        /// The creation time.
        /// </value>
        [JsonProperty("creation_time")]
        public DateTime CreationTime { get; set; }
    }
}
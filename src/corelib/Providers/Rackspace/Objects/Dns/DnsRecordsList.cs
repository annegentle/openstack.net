﻿namespace net.openstack.Providers.Rackspace.Objects.Dns
{
    using System.Collections.ObjectModel;
    using Newtonsoft.Json;

    /// <summary>
    /// This class models the object associated with the <c>"recordsList"</c> property in
    /// the JSON model for a DNS domain.
    /// </summary>
    /// <threadsafety static="true" instance="false"/>
    /// <preliminary/>
    [JsonObject(MemberSerialization.OptIn)]
    public class DnsRecordsList
    {
#pragma warning disable 649 // Field 'fieldName' is never assigned to, and will always have its default value
        /// <summary>
        /// This is the backing field for the <see cref="Records"/> property.
        /// </summary>
        [JsonProperty("records")]
        private DnsRecord[] _records;
#pragma warning restore 649

        /// <summary>
        /// Gets a collection of <see cref="DnsRecord"/> objects describing the DNS records
        /// associated with a <see cref="DnsDomain"/>.
        /// </summary>
        /// <value>
        /// A collection of <see cref="DnsRecord"/> objects, or <c>null</c> if the JSON response
        /// from the server did not include the associated property.
        /// </value>
        public ReadOnlyCollection<DnsRecord> Records
        {
            get
            {
                if (_records == null)
                    return null;

                return new ReadOnlyCollection<DnsRecord>(_records);
            }
        }
    }
}

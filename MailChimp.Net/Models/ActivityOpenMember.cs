using System;
using System.Linq;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    /// <summary>
    /// Open activity
    /// </summary>
    public class ActivityOpenMember
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOpenMember"/> class.
        /// </summary>
        public ActivityOpenMember()
        {
            Opens = new ActivityOpens[0];
        }

        /// <summary>
        /// Campaign id
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CmapaignId { get; set; }

        /// <summary>
        /// List id
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }

        /// <summary>
        /// Email id
        /// </summary>
        [JsonProperty("email_id")]
        public string EmailId { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Opens count
        /// </summary>
        [JsonProperty("opens_count")]
        public int OpensCount { get; set; }

        /// <summary>
        /// Opens timestamps
        /// </summary>
        [JsonProperty("opens")]
        public ActivityOpens[] Opens { get; set; }
    }

    public class ActivityOpens
    {
        [JsonProperty("timestamp")]
        public DateTime DateTime { get; set; }
    }
}
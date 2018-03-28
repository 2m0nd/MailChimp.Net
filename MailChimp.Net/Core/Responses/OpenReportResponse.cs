using System.Collections.Generic;
using MailChimp.Net.Models;
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The open report response.
    /// </summary>
    public class OpenReportResponse : BaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenReportResponse"/> class.
        /// </summary>
        public OpenReportResponse()
        {
            Memebers = new ActivityOpenMember[0];
            Links = new HashSet<Link>();
        }

        /// <summary>
        /// Gets or sets the members open.
        /// </summary>
        [JsonProperty("members")]
        public ActivityOpenMember[] Memebers { get; set; }

        /// <summary>
        /// Gets or sets the campaign id.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Total opens this campaign.
        /// </summary>
        [JsonProperty("total_opens")]
        public int TotalOpens { get; set; }
    }
}
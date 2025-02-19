#nullable disable

using System.Text.Json.Serialization;

namespace Emby.Server.Implementations.LiveTv.Listings.SchedulesDirectDtos
{
    /// <summary>
    /// Metadata schedule dto.
    /// </summary>
    public class MetadataScheduleDto
    {
        /// <summary>
        /// Gets or sets the modified timestamp.
        /// </summary>
        [JsonPropertyName("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// Gets or sets the md5.
        /// </summary>
        [JsonPropertyName("md5")]
        public string Md5 { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets the days count.
        /// </summary>
        [JsonPropertyName("days")]
        public int Days { get; set; }
    }
}

using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Episode
    {
        /// <summary>
        /// Gets or sets the episode number.
        /// </summary>
        /// <value>
        /// The episode number.
        /// </value>
        [J("episodeNumber")] public long EpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the air date.
        /// </summary>
        /// <value>
        /// The air date.
        /// </value>
        [J("airDate")] public DateTimeOffset AirDate { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [J("url")] public string Url { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Episode"/> is available.
        /// </summary>
        /// <value>
        ///   <c>true</c> if available; otherwise, <c>false</c>.
        /// </value>
        [J("available")] public bool Available { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Episode"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        [J("approved")] public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Episode"/> is requested.
        /// </summary>
        /// <value>
        ///   <c>true</c> if requested; otherwise, <c>false</c>.
        /// </value>
        [J("requested")] public bool Requested { get; set; }

        /// <summary>
        /// Gets or sets the season identifier.
        /// </summary>
        /// <value>
        /// The season identifier.
        /// </value>
        [J("seasonId")] public long SeasonId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}

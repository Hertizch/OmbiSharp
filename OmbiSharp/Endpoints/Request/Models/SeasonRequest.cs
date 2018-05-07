using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SeasonRequest
    {
        /// <summary>
        /// Gets or sets the season number.
        /// </summary>
        /// <value>
        /// The season number.
        /// </value>
        [J("seasonNumber")] public long SeasonNumber { get; set; }

        /// <summary>
        /// Gets or sets the episodes.
        /// </summary>
        /// <value>
        /// The episodes.
        /// </value>
        [J("episodes")] public List<Episode> Episodes { get; set; }

        /// <summary>
        /// Gets or sets the child request identifier.
        /// </summary>
        /// <value>
        /// The child request identifier.
        /// </value>
        [J("childRequestId")] public long ChildRequestId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}

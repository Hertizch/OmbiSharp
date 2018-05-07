using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class NotificationUserId
    {
        /// <summary>
        /// Gets or sets the player identifier.
        /// </summary>
        /// <value>
        /// The player identifier.
        /// </value>
        [J("playerId")] public string PlayerId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [J("userId")] public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the added at.
        /// </summary>
        /// <value>
        /// The added at.
        /// </value>
        [J("addedAt")] public DateTimeOffset AddedAt { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}

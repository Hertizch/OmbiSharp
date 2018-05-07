using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Comment
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [J("userId")] public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the comment comment.
        /// </summary>
        /// <value>
        /// The comment comment.
        /// </value>
        [J("comment")] public string CommentComment { get; set; }

        /// <summary>
        /// Gets or sets the issues identifier.
        /// </summary>
        /// <value>
        /// The issues identifier.
        /// </value>
        [J("issuesId")] public long IssuesId { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [J("date")] public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        [J("user")] public RequestedUser User { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}

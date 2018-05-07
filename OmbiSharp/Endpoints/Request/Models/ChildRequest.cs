using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ChildRequest
    {
        /// <summary>
        /// Gets or sets the parent request identifier.
        /// </summary>
        /// <value>
        /// The parent request identifier.
        /// </value>
        [J("parentRequestId")] public long ParentRequestId { get; set; }

        /// <summary>
        /// Gets or sets the issue identifier.
        /// </summary>
        /// <value>
        /// The issue identifier.
        /// </value>
        [J("issueId")] public long IssueId { get; set; }

        /// <summary>
        /// Gets or sets the type of the series.
        /// </summary>
        /// <value>
        /// The type of the series.
        /// </value>
        [J("seriesType")] public string SeriesType { get; set; }

        /// <summary>
        /// Gets or sets the issues.
        /// </summary>
        /// <value>
        /// The issues.
        /// </value>
        [J("issues")] public List<Issue> Issues { get; set; }

        /// <summary>
        /// Gets or sets the season requests.
        /// </summary>
        /// <value>
        /// The season requests.
        /// </value>
        [J("seasonRequests")] public List<SeasonRequest> SeasonRequests { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ChildRequest"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        [J("approved")] public bool Approved { get; set; }

        /// <summary>
        /// Gets or sets the requested date.
        /// </summary>
        /// <value>
        /// The requested date.
        /// </value>
        [J("requestedDate")] public DateTimeOffset RequestedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ChildRequest"/> is available.
        /// </summary>
        /// <value>
        ///   <c>true</c> if available; otherwise, <c>false</c>.
        /// </value>
        [J("available")] public bool Available { get; set; }

        /// <summary>
        /// Gets or sets the requested user identifier.
        /// </summary>
        /// <value>
        /// The requested user identifier.
        /// </value>
        [J("requestedUserId")] public string RequestedUserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ChildRequest"/> is denied.
        /// </summary>
        /// <value>
        ///   <c>true</c> if denied; otherwise, <c>false</c>.
        /// </value>
        [J("denied")] public bool Denied { get; set; }

        /// <summary>
        /// Gets or sets the denied reason.
        /// </summary>
        /// <value>
        /// The denied reason.
        /// </value>
        [J("deniedReason")] public string DeniedReason { get; set; }

        /// <summary>
        /// Gets or sets the type of the request.
        /// </summary>
        /// <value>
        /// The type of the request.
        /// </value>
        [J("requestType")] public string RequestType { get; set; }

        /// <summary>
        /// Gets or sets the requested user.
        /// </summary>
        /// <value>
        /// The requested user.
        /// </value>
        [J("requestedUser")] public RequestedUser RequestedUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance can approve.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance can approve; otherwise, <c>false</c>.
        /// </value>
        [J("canApprove")] public bool CanApprove { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}

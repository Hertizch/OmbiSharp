using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Issue
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the type of the request.
        /// </summary>
        /// <value>
        /// The type of the request.
        /// </value>
        [J("requestType")] public string RequestType { get; set; }

        /// <summary>
        /// Gets or sets the provider identifier.
        /// </summary>
        /// <value>
        /// The provider identifier.
        /// </value>
        [J("providerId")] public string ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the request identifier.
        /// </summary>
        /// <value>
        /// The request identifier.
        /// </value>
        [J("requestId")] public long RequestId { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        [J("subject")] public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [J("description")] public string Description { get; set; }

        /// <summary>
        /// Gets or sets the issue category identifier.
        /// </summary>
        /// <value>
        /// The issue category identifier.
        /// </value>
        [J("issueCategoryId")] public long IssueCategoryId { get; set; }

        /// <summary>
        /// Gets or sets the issue category.
        /// </summary>
        /// <value>
        /// The issue category.
        /// </value>
        [J("issueCategory")] public IssueCategory IssueCategory { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// Gets or sets the resovled date.
        /// </summary>
        /// <value>
        /// The resovled date.
        /// </value>
        [J("resovledDate")] public DateTimeOffset ResovledDate { get; set; }

        /// <summary>
        /// Gets or sets the user reported identifier.
        /// </summary>
        /// <value>
        /// The user reported identifier.
        /// </value>
        [J("userReportedId")] public string UserReportedId { get; set; }

        /// <summary>
        /// Gets or sets the user reported.
        /// </summary>
        /// <value>
        /// The user reported.
        /// </value>
        [J("userReported")] public RequestedUser UserReported { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        [J("comments")] public List<Comment> Comments { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}

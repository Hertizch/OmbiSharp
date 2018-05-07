using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Movie
    {
        /// <summary>
        /// Gets or sets the movie database identifier.
        /// </summary>
        /// <value>
        /// The movie database identifier.
        /// </value>
        [J("theMovieDbId")] public long TheMovieDbId { get; set; }

        /// <summary>
        /// Gets or sets the issue identifier.
        /// </summary>
        /// <value>
        /// The issue identifier.
        /// </value>
        [J("issueId")] public object IssueId { get; set; }

        /// <summary>
        /// Gets or sets the issues.
        /// </summary>
        /// <value>
        /// The issues.
        /// </value>
        [J("issues")] public object Issues { get; set; }

        /// <summary>
        /// Gets or sets the root path override.
        /// </summary>
        /// <value>
        /// The root path override.
        /// </value>
        [J("rootPathOverride")] public long RootPathOverride { get; set; }

        /// <summary>
        /// Gets or sets the quality override.
        /// </summary>
        /// <value>
        /// The quality override.
        /// </value>
        [J("qualityOverride")] public long QualityOverride { get; set; }

        /// <summary>
        /// Gets or sets the imdb identifier.
        /// </summary>
        /// <value>
        /// The imdb identifier.
        /// </value>
        [J("imdbId")] public string ImdbId { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [J("overview")] public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the poster path.
        /// </summary>
        /// <value>
        /// The poster path.
        /// </value>
        [J("posterPath")] public string PosterPath { get; set; }

        /// <summary>
        /// Gets or sets the release date.
        /// </summary>
        /// <value>
        /// The release date.
        /// </value>
        [J("releaseDate")] public DateTimeOffset ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the digital release date.
        /// </summary>
        /// <value>
        /// The digital release date.
        /// </value>
        [J("digitalReleaseDate")] public DateTimeOffset? DigitalReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// Gets or sets the background.
        /// </summary>
        /// <value>
        /// The background.
        /// </value>
        [J("background")] public string Background { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Movie"/> is released.
        /// </summary>
        /// <value>
        ///   <c>true</c> if released; otherwise, <c>false</c>.
        /// </value>
        [J("released")] public bool Released { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [digital release].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [digital release]; otherwise, <c>false</c>.
        /// </value>
        [J("digitalRelease")] public bool DigitalRelease { get; set; }
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Movie"/> is approved.
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
        /// Gets or sets a value indicating whether this <see cref="Movie"/> is available.
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
        /// Gets or sets a value indicating whether this <see cref="Movie"/> is denied.
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
        [J("deniedReason")] public object DeniedReason { get; set; }

        /// <summary>
        /// Gets or sets the type of the request.
        /// </summary>
        /// <value>
        /// The type of the request.
        /// </value>
        [J("requestType")] public long RequestType { get; set; }

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

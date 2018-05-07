using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Tv
    {
        /// <summary>
        /// Gets or sets the tv database identifier.
        /// </summary>
        /// <value>
        /// The tv database identifier.
        /// </value>
        [J("tvDbId")] public long TvDbId { get; set; }

        /// <summary>
        /// Gets or sets the imdb identifier.
        /// </summary>
        /// <value>
        /// The imdb identifier.
        /// </value>
        [J("imdbId")] public string ImdbId { get; set; }

        /// <summary>
        /// Gets or sets the quality override.
        /// </summary>
        /// <value>
        /// The quality override.
        /// </value>
        [J("qualityOverride")] public long QualityOverride { get; set; }

        /// <summary>
        /// Gets or sets the root folder.
        /// </summary>
        /// <value>
        /// The root folder.
        /// </value>
        [J("rootFolder")] public long RootFolder { get; set; }

        /// <summary>
        /// Gets or sets the overview.
        /// </summary>
        /// <value>
        /// The overview.
        /// </value>
        [J("overview")] public string Overview { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [J("title")] public string Title { get; set; }

        /// <summary>
        /// Gets or sets the poster path.
        /// </summary>
        /// <value>
        /// The poster path.
        /// </value>
        [J("posterPath")] public string PosterPath { get; set; }

        /// <summary>
        /// Gets or sets the background.
        /// </summary>
        /// <value>
        /// The background.
        /// </value>
        [J("background")] public string Background { get; set; }

        /// <summary>
        /// Gets or sets the release date.
        /// </summary>
        /// <value>
        /// The release date.
        /// </value>
        [J("releaseDate")] public DateTimeOffset ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [J("status")] public string Status { get; set; }

        /// <summary>
        /// Gets or sets the total seasons.
        /// </summary>
        /// <value>
        /// The total seasons.
        /// </value>
        [J("totalSeasons")] public long TotalSeasons { get; set; }

        /// <summary>
        /// Gets or sets the child requests.
        /// </summary>
        /// <value>
        /// The child requests.
        /// </value>
        [J("childRequests")] public List<ChildRequest> ChildRequests { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public long Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TvTree
    {
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        [J("label")] public string Label { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [J("data")] public Data Data { get; set; }

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>
        /// The children.
        /// </value>
        [J("children")] public List<Child> Children { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TvTree"/> is leaf.
        /// </summary>
        /// <value>
        ///   <c>true</c> if leaf; otherwise, <c>false</c>.
        /// </value>
        [J("leaf")] public bool Leaf { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TvTree"/> is expanded.
        /// </summary>
        /// <value>
        ///   <c>true</c> if expanded; otherwise, <c>false</c>.
        /// </value>
        [J("expanded")] public bool Expanded { get; set; }
    }
}

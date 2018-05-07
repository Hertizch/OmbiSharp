using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RequestResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="RequestResult"/> is result.
        /// </summary>
        /// <value>
        ///   <c>true</c> if result; otherwise, <c>false</c>.
        /// </value>
        [J("result")] public bool Result { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [J("message")] public string Message { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is error; otherwise, <c>false</c>.
        /// </value>
        [J("isError")] public bool IsError { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        [J("errorMessage")] public string ErrorMessage { get; set; }
    }
}

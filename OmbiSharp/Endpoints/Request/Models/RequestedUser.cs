using System;
using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace OmbiSharp.Endpoints.Request.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RequestedUser
    {
        /// <summary>
        /// Gets or sets the alias.
        /// </summary>
        /// <value>
        /// The alias.
        /// </value>
        [J("alias")] public string Alias { get; set; }

        /// <summary>
        /// Gets or sets the type of the user.
        /// </summary>
        /// <value>
        /// The type of the user.
        /// </value>
        [J("userType")] public string UserType { get; set; }

        /// <summary>
        /// Gets or sets the provider user identifier.
        /// </summary>
        /// <value>
        /// The provider user identifier.
        /// </value>
        [J("providerUserId")] public string ProviderUserId { get; set; }

        /// <summary>
        /// Gets or sets the last logged in.
        /// </summary>
        /// <value>
        /// The last logged in.
        /// </value>
        [J("lastLoggedIn")] public DateTimeOffset LastLoggedIn { get; set; }

        /// <summary>
        /// Gets or sets the emby connect user identifier.
        /// </summary>
        /// <value>
        /// The emby connect user identifier.
        /// </value>
        [J("embyConnectUserId")] public string EmbyConnectUserId { get; set; }

        /// <summary>
        /// Gets or sets the movie request limit.
        /// </summary>
        /// <value>
        /// The movie request limit.
        /// </value>
        [J("movieRequestLimit")] public long MovieRequestLimit { get; set; }

        /// <summary>
        /// Gets or sets the episode request limit.
        /// </summary>
        /// <value>
        /// The episode request limit.
        /// </value>
        [J("episodeRequestLimit")] public long EpisodeRequestLimit { get; set; }

        /// <summary>
        /// Gets or sets the user access token.
        /// </summary>
        /// <value>
        /// The user access token.
        /// </value>
        [J("userAccessToken")] public string UserAccessToken { get; set; }

        /// <summary>
        /// Gets or sets the notification user ids.
        /// </summary>
        /// <value>
        /// The notification user ids.
        /// </value>
        [J("notificationUserIds")] public List<NotificationUserId> NotificationUserIds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is emby connect.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is emby connect; otherwise, <c>false</c>.
        /// </value>
        [J("isEmbyConnect")] public bool IsEmbyConnect { get; set; }

        /// <summary>
        /// Gets or sets the user alias.
        /// </summary>
        /// <value>
        /// The user alias.
        /// </value>
        [J("userAlias")] public string UserAlias { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [email login].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [email login]; otherwise, <c>false</c>.
        /// </value>
        [J("emailLogin")] public bool EmailLogin { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        [J("userName")] public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the name of the normalized user.
        /// </summary>
        /// <value>
        /// The name of the normalized user.
        /// </value>
        [J("normalizedUserName")] public string NormalizedUserName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [J("email")] public string Email { get; set; }

        /// <summary>
        /// Gets or sets the normalized email.
        /// </summary>
        /// <value>
        /// The normalized email.
        /// </value>
        [J("normalizedEmail")] public string NormalizedEmail { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [email confirmed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [email confirmed]; otherwise, <c>false</c>.
        /// </value>
        [J("emailConfirmed")] public bool EmailConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [J("phoneNumber")] public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [phone number confirmed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [phone number confirmed]; otherwise, <c>false</c>.
        /// </value>
        [J("phoneNumberConfirmed")] public bool PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [two factor enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [two factor enabled]; otherwise, <c>false</c>.
        /// </value>
        [J("twoFactorEnabled")] public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Gets or sets the lockout end.
        /// </summary>
        /// <value>
        /// The lockout end.
        /// </value>
        [J("lockoutEnd")] public DateTimeOffset LockoutEnd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [lockout enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [lockout enabled]; otherwise, <c>false</c>.
        /// </value>
        [J("lockoutEnabled")] public bool LockoutEnabled { get; set; }

        /// <summary>
        /// Gets or sets the access failed count.
        /// </summary>
        /// <value>
        /// The access failed count.
        /// </value>
        [J("accessFailedCount")] public long AccessFailedCount { get; set; }
    }
}

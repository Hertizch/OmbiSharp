using System;
using System.Collections.Generic;
using System.Text;

namespace OmbiSharp.Endpoints.Emby
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="OmbiSharp.Endpoints.Emby.IEmbyClient" />
    public class EmbyClient : IEmbyClient
    {
        private OmbiClient _ombiClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbyClient"/> class.
        /// </summary>
        /// <param name="ombiClient">The ombi client.</param>
        public EmbyClient(OmbiClient ombiClient)
        {
            _ombiClient = ombiClient;
        }
    }
}

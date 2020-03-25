using JetBrains.Annotations;
using Lykke.Service.CustomerProfile.Client.Models.Enums;

namespace Lykke.Service.CustomerProfile.Client.Models.Responses
{
    /// <summary>
    /// Represents response of admin profile request.
    /// </summary>
    [PublicAPI]
    public class AdminProfileResponse
    {
        /// <summary>
        /// Contains admin profile.
        /// </summary>
        public AdminProfile Data { get; set; }

        /// <summary>
        /// The error code of operation with admin profile.
        /// </summary>
        public AdminProfileErrorCodes ErrorCode { get; set; }
    }
}

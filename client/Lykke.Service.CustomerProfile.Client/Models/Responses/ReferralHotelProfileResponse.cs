using JetBrains.Annotations;
using Lykke.Service.CustomerProfile.Client.Models.Enums;

namespace Lykke.Service.CustomerProfile.Client.Models.Responses
{
    /// <summary>
    /// Represents response of referral hotel request.
    /// </summary>
    [PublicAPI]
    public class ReferralHotelProfileResponse
    {
        /// <summary>
        /// Contains referral hotel profile.
        /// </summary>
        public ReferralHotelProfile Data { get; set; }

        /// <summary>
        /// The error code of operation with referral lead contract.
        /// </summary>
        public ReferralHotelProfileErrorCodes ErrorCode { get; set; }
    }
}

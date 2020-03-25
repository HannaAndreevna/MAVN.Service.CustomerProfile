using JetBrains.Annotations;
using Lykke.Service.CustomerProfile.Client.Models.Enums;

namespace Lykke.Service.CustomerProfile.Client.Models.Responses
{
    /// <summary>
    /// Represents response of referral lead request.
    /// </summary>
    [PublicAPI]
    public class ReferralLeadProfileResponse
    {
        /// <summary>
        /// Contains referral lead profile.
        /// </summary>
        public ReferralLeadProfile Data { get; set; }

        /// <summary>
        /// The error code of operation with referral lead contract.
        /// </summary>
        public ReferralLeadProfileErrorCodes ErrorCode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MAVN.Service.CustomerProfile.Domain.Enums;
using MAVN.Service.CustomerProfile.Domain.Models;

namespace MAVN.Service.CustomerProfile.Domain.Services
{
    public interface IReferralFriendProfileService
    {
        Task<IReadOnlyList<ReferralFriendProfile>> GetAllAsync();

        Task<ReferralFriendProfile> GetByIdAsync(Guid referralFriendId);

        Task<ReferralFriendProfile> GetByEmailAndReferrerAsync(string email, Guid referrerId);

        Task<ReferralFriendProfileErrorCodes> AddAsync(ReferralFriendProfile referralFriendProfile);

        Task<ReferralFriendProfileErrorCodes> UpdateAsync(ReferralFriendProfile referralFriendProfile);

        Task DeleteAsync(Guid referralFriendId);
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MAVN.Service.CustomerProfile.Domain.Enums;
using MAVN.Service.CustomerProfile.Domain.Models;

namespace MAVN.Service.CustomerProfile.Domain.Services
{
    public interface IReferralHotelProfileService
    {
        Task<IReadOnlyList<ReferralHotelProfile>> GetAllAsync();

        Task<ReferralHotelProfile> GetByIdAsync(Guid referralHotelId);

        Task<ReferralHotelProfileErrorCodes> AddAsync(ReferralHotelProfile referralHotelProfile);

        Task<ReferralHotelProfileErrorCodes> UpdateAsync(ReferralHotelProfile referralHotelProfile);
        
        Task DeleteAsync(Guid referralHotelId);
    }
}

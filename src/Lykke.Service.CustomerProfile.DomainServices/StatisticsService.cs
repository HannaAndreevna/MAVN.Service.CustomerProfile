﻿using System;
using System.Threading.Tasks;
using Lykke.Service.CustomerProfile.Domain.Models;
using Lykke.Service.CustomerProfile.Domain.Repositories;
using Lykke.Service.CustomerProfile.Domain.Services;

namespace Lykke.Service.CustomerProfile.DomainServices
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ICustomerProfileRepository _customerProfileRepository;

        public StatisticsService(ICustomerProfileRepository customerProfileRepository)
        {
            _customerProfileRepository = customerProfileRepository;
        }

        public async Task<StatisticsResult> GetByPeriodAsync(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate)
                throw new InvalidOperationException($"{nameof(startDate)} must be earlier than {nameof(endDate)}");

            var periodCountTask = _customerProfileRepository.GetByPeriodAsync(startDate, endDate);
            var totalCountTask = _customerProfileRepository.GetTotalByDateAsync(endDate);
            await Task.WhenAll(periodCountTask, totalCountTask);

            return new StatisticsResult
            {
                RegistrationsCount = periodCountTask.Result,
                TotalCount = totalCountTask.Result,
            };
        }
    }
}

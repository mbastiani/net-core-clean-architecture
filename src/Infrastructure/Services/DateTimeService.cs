using NetCoreCleanArchitecture.Application.Common.Interfaces;
using System;

namespace NetCoreCleanArchitecture.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}

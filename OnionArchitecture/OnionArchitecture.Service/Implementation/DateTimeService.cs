using OnionArchitecture.Service.Contract;
using System;

namespace OnionArchitecture.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
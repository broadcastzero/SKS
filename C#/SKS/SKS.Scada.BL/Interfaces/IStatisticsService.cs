﻿using System;
namespace SKS.Scada.BL
{
    interface IStatisticsService
    {
        System.Collections.Generic.List<SKS.Scada.DAL.Measurement> GetCustomerStatistics(SKS.Scada.DAL.Customer customer, DateTime StartDate, DateTime EndDate);
    }
}

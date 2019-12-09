using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealers.DataManager.Interfaces
{
    public interface IReportRepository
    {
        ICollection<Report> GetReport();
        Report GetReport(int ReportId);
        bool ReportExists(int ReportId);
        bool CreateReport(Report report);
        bool UpdateReport(Report report);
        bool DeleteReport(Report report);
        bool Save();
    }
}

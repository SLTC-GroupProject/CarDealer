using CarDealers.DataManager.Context;
using CarDealers.DataManager.Interfaces;
using CarDealers.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealers.DataManager.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private CarDealersDbContext _DbContext;

        public ReportRepository(CarDealersDbContext DbContext)
        {
            this._DbContext = DbContext;
        }

        public bool CreateReport(Report report)
        {
            _DbContext.Add(report);
            return Save();
        }

        public bool DeleteReport(Report report)
        {
            _DbContext.Remove(report);
            return Save();
        }

        public ICollection<Report> GetReport()
        {
            return _DbContext.Reports.OrderBy(a => a.Id).ToList();
        }

        public Report GetReport(int ReportId)
        {
            return _DbContext.Reports.Where(a => a.Id == ReportId).FirstOrDefault();
        }

        public bool ReportExists(int ReportId)
        {
            return _DbContext.Reports.Any(a => a.Id == ReportId);
        }

        public bool Save()
        {
            var saved = _DbContext.SaveChanges();
            return saved >= 0 ? true : false;
        }

        public bool UpdateReport(Report report)
        {
            _DbContext.Update(report);
            return Save();
        }
    }
}

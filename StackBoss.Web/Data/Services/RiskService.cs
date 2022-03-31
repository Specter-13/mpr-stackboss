using Microsoft.EntityFrameworkCore;
using StackBoss.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackBoss.Web.Data.Services
{
    public class RiskService
    {
          #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        #region Constructor
        public RiskService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Employees
        public async Task<List<RiskEntity>> GetAllRisksAsync()
        {
            return await _appDBContext.RiskTable.ToListAsync();
        }
        #endregion

        #region Insert Employee
        public async Task<bool> InsertRiskAsync(RiskEntity risk)
        {
            await _appDBContext.RiskTable.AddAsync(risk);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Employee by Id
        public async Task<RiskEntity> GetRiskAsync(int Id)
        {
            RiskEntity employee = await _appDBContext.RiskTable.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return employee;
        }
        #endregion

        #region Update Employee
        public async Task<bool> UpdateRiskAsync(RiskEntity risk)
        {
             _appDBContext.RiskTable.Update(risk);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteEmployee
        public async Task<bool> DeleteRiskAsync(RiskEntity risk)
        {
            _appDBContext.Remove(risk);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
 }


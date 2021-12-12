using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tm.Model;
using TM.Service.Declare;

namespace TM.Service.Implement
{
   public class ProcessMRChange : IProcessMRChange
    {
        readonly IUpdateMRLogService _updateMRLogService;
        readonly IMaintenanceService _maintenanceService;

        public ProcessMRChange(IMaintenanceService maintenanceService, IUpdateMRLogService updateMRLogService)
        {
            _maintenanceService = maintenanceService;
            _updateMRLogService = updateMRLogService;
        }
        public void ProcessMrPayload(MRChangePayload data)
        {
            _updateMRLogService.UpdateMrLog(data);
            _maintenanceService.UpdateCorporate(data);
            if (data.ChangeType == Enums.MRChangeType.ReAssign)
            {
                _maintenanceService.ReAssign(data.UserId, data.AssignToTechnician);
            }

            if (data.ChangeType == Enums.MRChangeType.StatusChange)
            {
                _maintenanceService.StatusChange(data.UserId, data.StatusUpdate);
            }
        }
    }
}

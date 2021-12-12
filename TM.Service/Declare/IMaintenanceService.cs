using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tm.Model;

namespace TM.Service.Declare
{
    public interface IMaintenanceService
    {
        void ReAssign(Guid technicianId, Guid newTechnicianId);
        void StatusChange(Guid technicianId, Guid statusId);
        void UpdateCorporate(MRChangePayload data);
    }
}

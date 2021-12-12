using System;
using static Tm.Model.Enums;

namespace Tm.Model
{
    public class MRChangePayload
    {
        public MRChangeType ChangeType { get; set; }
        public Guid UserId { get; set; }
        public Guid AssignToTechnician { get; set; }
        public Guid StatusUpdate { get; set; }
    }
}

using System;

namespace EMS.DTOs
{
    public class UserLeaveApplicationDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ApplicationTile { get; set; }
        public string ApplicationDetails { get; set; }
        public DateTime LeaveAppliedFrom { get; set; }
        public DateTime LeaveAppliedTo { get; set; }
        public bool LeaveApprovalStatus { get; set; }
        public int LeaveApprovedBy { get; set; }
    }
}
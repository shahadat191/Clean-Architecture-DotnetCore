using System;
namespace HR.LeaveManagement.Application.DTOs
{
    public class LeaveTypeDto
    {
        public LeaveTypeDto()
        {
        }
        public string Name { get; set; }

        public int DefaultDays { get; set; }
    }
}

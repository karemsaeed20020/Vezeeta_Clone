

using System.ComponentModel.DataAnnotations.Schema;
using Vezeeta.Data.Entities.Enums;

namespace Vezeeta.Data.Entities
{
    public class DoctorAvailability : BaseEntity
    {
        public DayOfWeek? DayOfWeek { get; set; }// for weekly recurring schedule
        public DateOnly? Date { get; set; } // for one-time special open days


        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public ScheduleFrequency frequency { get; set; } = ScheduleFrequency.Weekly;
        public int Duration { get; set; }
        public AvailabilityMethod type { get; set; }

        [ForeignKey("Doctor")]
        public string DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public ICollection<DoctorAvailabilitySlot>? AvailableSlots { get; set; } = new HashSet<DoctorAvailabilitySlot>();
    }
}

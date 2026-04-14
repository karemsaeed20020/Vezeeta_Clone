
using System.ComponentModel.DataAnnotations.Schema;
using Vezeeta.Data.Entities.Enums;

namespace Vezeeta.Data.Entities
{
    public class DoctorAvailabilitySlot : BaseEntity
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateOnly Date { get; set; }
        public SlotStatus Status { get; set; } = SlotStatus.Available;
        public bool IsBooked { get; set; } = false;
        public string? LockedReason { get; set; }

        [ForeignKey("Availability")]
        public int DoctorAvailabilityId { get; set; }
        public DoctorAvailability? Availability { get; set; }

        //because there would be free solt without apointment(may =be)
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}

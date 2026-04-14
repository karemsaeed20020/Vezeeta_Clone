

using System.ComponentModel.DataAnnotations.Schema;

namespace Vezeeta.Data.Entities
{
    public class Diagnosis
    {
        public string Description { get; set; }
        public DateTime DiagnosedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(MedicalRecord))]
        public int MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace SyncNotesAppTest_Windows.Models
{

    public class SyncChanges
    {

        [Key]
        public Guid ChangeID { get; set; }

        public string ChangeData { get; set; }

        public Guid DeviceID { get; set; }

        public Guid EntityID { get; set; }

        public int EntityType { get; set; }

        public bool IsSynced { get; set; }

        public int Operation { get; set; }

        public DateTime TimeStamp { get; set; }

        public int Version { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SyncNotesAppTest_Windows.Models
{

    public class SyncChanges
    {

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

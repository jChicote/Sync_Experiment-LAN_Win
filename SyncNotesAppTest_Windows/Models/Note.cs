using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncNotesAppTest_Windows.Models
{

    public class Note
    {

        public Guid ID { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CreationUser { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime LastUpdatedAt { get; set; }

        public string Title { get; set; }

        public string TextContent { get; set; }

        public int Version { get; set; }

    }

}

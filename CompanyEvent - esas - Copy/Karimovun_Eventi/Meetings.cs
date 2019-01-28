using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karimovun_Eventi
{
    class Meetings
    {
        public int MeetingId { get; set; }
        public string MeetingInfo { get; set; }
        public DateTime MeetingDate { get; set; }
        public DateTime MeetingStartTime { get; set; }
        public DateTime MeetingEndTime { get; set; }
        public int MeetingOrganiserId { get; set; }
        
    }
}

using System.Collections.Generic;

namespace KGViewer
{
    class ResponseString
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<EventShort> Results { get; set; }
    }
}

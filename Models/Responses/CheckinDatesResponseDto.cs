using System;
using BackendSan.Models;
using BackendSan.Models.Common;

namespace BackendSan.Models.Responses
{
    public class CheckinDatesResponseDto
    {
        public CheckinDatesBody Body { get; set; }
        public HeaderDto Header { get; set; }
    }   

    public class CheckinDatesBody
    {
       public List<string> dates { get; set; }
    }
}

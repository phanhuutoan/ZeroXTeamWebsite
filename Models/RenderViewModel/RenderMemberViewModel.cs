using System;
using System.Collections.Generic;

namespace ZeroXTeam.Models.RenderViewModel
{
    public class RenderMemberViewModel : RenderBase
    {
        public string Bio { get; set; }        
        public string Facebook { get; set; }        
        public string Email { get; set; }        
        public string TeamTitles { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoinedAt { get; set; }
    }
}
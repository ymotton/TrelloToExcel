using System.Collections.Generic;

namespace TrelloToExcel.Trello
{
    public class Member
    {
        public string id { get; set; }
        public string avatarHash { get; set; }
        public string bio { get; set; }
        public BioData bioData { get; set; }
        public bool confirmed { get; set; }
        public string fullName { get; set; }
        public List<object> idPremOrgsAdmin { get; set; }
        public string initials { get; set; }
        public string memberType { get; set; }
        public List<object> products { get; set; }
        public string status { get; set; }
        public string url { get; set; }
        public string username { get; set; }
    }
}
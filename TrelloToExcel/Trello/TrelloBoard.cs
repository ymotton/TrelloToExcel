using System.Collections.Generic;

namespace TrelloToExcel.Trello
{
    public class TrelloBoard
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public object descData { get; set; }
        public bool closed { get; set; }
        public string idOrganization { get; set; }
        public bool invited { get; set; }
        public bool pinned { get; set; }
        public bool starred { get; set; }
        public string url { get; set; }
        public Prefs prefs { get; set; }
        public List<object> invitations { get; set; }
        public List<Membership> memberships { get; set; }
        public string shortLink { get; set; }
        public bool subscribed { get; set; }
        public LabelNames labelNames { get; set; }
        public List<string> powerUps { get; set; }
        public string dateLastActivity { get; set; }
        public string dateLastView { get; set; }
        public string shortUrl { get; set; }
        public List<Card> cards { get; set; }
        public List<List> lists { get; set; }
        public List<Member> members { get; set; }
        public List<Checklist> checklists { get; set; }
        public List<Action> actions { get; set; }
    }
}
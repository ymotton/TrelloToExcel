using System.Collections.Generic;

namespace TrelloToExcel.Trello
{
    public class Card
    {
        public string id { get; set; }
        public List<object> checkItemStates { get; set; }
        public bool closed { get; set; }
        public string dateLastActivity { get; set; }
        public string desc { get; set; }
        public DescData descData { get; set; }
        public string idBoard { get; set; }
        public string idList { get; set; }
        public List<object> idMembersVoted { get; set; }
        public int idShort { get; set; }
        public string idAttachmentCover { get; set; }
        public bool manualCoverAttachment { get; set; }
        public string name { get; set; }
        public double pos { get; set; }
        public string shortLink { get; set; }
        public Badges badges { get; set; }
        public string due { get; set; }
        public List<object> idChecklists { get; set; }
        public List<object> idMembers { get; set; }
        public List<object> labels { get; set; }
        public string shortUrl { get; set; }
        public bool subscribed { get; set; }
        public string url { get; set; }
        public List<object> attachments { get; set; }
    }
}
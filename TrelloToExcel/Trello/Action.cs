namespace TrelloToExcel.Trello
{
    public class Action
    {
        public string id { get; set; }
        public string idMemberCreator { get; set; }
        public Data data { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public MemberCreator memberCreator { get; set; }
        public Member2 member { get; set; }
    }
}
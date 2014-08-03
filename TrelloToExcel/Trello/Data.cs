namespace TrelloToExcel.Trello
{
    public class Data
    {
        public Board board { get; set; }
        public List2 list { get; set; }
        public Card2 card { get; set; }
        public Old old { get; set; }
        public string text { get; set; }
        public Attachment attachment { get; set; }
        public string idMember { get; set; }
        public ListAfter listAfter { get; set; }
        public ListBefore listBefore { get; set; }
        public CheckItem checkItem { get; set; }
        public Checklist2 checklist { get; set; }
        public string idMemberAdded { get; set; }
        public string memberType { get; set; }
        public string dateLastEdited { get; set; }
        public TextData textData { get; set; }
        public CardSource cardSource { get; set; }
        public bool? deactivated { get; set; }
    }
}
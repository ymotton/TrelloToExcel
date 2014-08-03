namespace TrelloToExcel.Trello
{
    public class List
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool closed { get; set; }
        public string idBoard { get; set; }
        public int pos { get; set; }
        public bool subscribed { get; set; }
    }
}
namespace TrelloToExcel.Trello
{
    public class Card2
    {
        public string shortLink { get; set; }
        public int idShort { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public double? pos { get; set; }
        public string desc { get; set; }
        public string idAttachmentCover { get; set; }
        public string idList { get; set; }
        public bool? closed { get; set; }
        public string due { get; set; }
    }
}
using System.Collections.Generic;

namespace TrelloToExcel.Trello
{
    public class Checklist
    {
        public string id { get; set; }
        public string name { get; set; }
        public string idBoard { get; set; }
        public string idCard { get; set; }
        public int pos { get; set; }
        public List<object> checkItems { get; set; }
    }
}
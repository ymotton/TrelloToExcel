namespace TrelloToExcel.Trello
{
    public class Prefs
    {
        public string permissionLevel { get; set; }
        public string voting { get; set; }
        public string comments { get; set; }
        public string invitations { get; set; }
        public bool selfJoin { get; set; }
        public bool cardCovers { get; set; }
        public string cardAging { get; set; }
        public bool calendarFeedEnabled { get; set; }
        public string background { get; set; }
        public string backgroundColor { get; set; }
        public object backgroundImage { get; set; }
        public object backgroundImageScaled { get; set; }
        public bool backgroundTile { get; set; }
        public string backgroundBrightness { get; set; }
        public bool canBePublic { get; set; }
        public bool canBeOrg { get; set; }
        public bool canBePrivate { get; set; }
        public bool canInvite { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using RestSharp;
using SpreadsheetLight;
using TrelloToExcel.Client;
using TrelloToExcel.Trello;

namespace TrelloToExcel
{
    public class BoardExporter
    {
        public static string Export(string applicationKey, string memberToken, string boardId, string fileName = null)
        {
            Ensure.IsNotNullOrEmpty(applicationKey, "The applicationKey cannot be null");
            Ensure.IsNotNullOrEmpty(memberToken, "The memberToken cannot be null");
            Ensure.IsNotNullOrEmpty(boardId, "The boardId cannot be null");
            Ensure.IsNotNullOrEmpty(fileName, "The fileName cannot be null");
            
            var client = new TrelloRestClient(applicationKey);
            client.Authenticate(memberToken);

            var restRequest = new RestRequest(string.Format("board/{0}", boardId));
            restRequest.AddParameter("cards", "all");
            restRequest.AddParameter("lists", "all");

            var board = client.Request<TrelloBoard>(restRequest);
            Ensure.IsNotNull(board, "Unexpected response.");

            var lists = (board.lists ?? new List<List>()).ToDictionary(l => l.id, l => l.name);
            
            var sheet = new SLDocument();
            board.cards.ForEach((c, i) => ExportLine(c, i + 1, sheet, lists));

            fileName = fileName ?? string.Format("{0}-{1}.xlsx", board.name, DateTime.Now.ToString("yyyyMMddhhmmss"));
            sheet.SaveAs(fileName);

            return fileName;
        }

        static void ExportLine(Card card, int rowIndex, SLDocument sheet, Dictionary<string, string> lists)
        {
            var cardName = card.name;
            var cardNameMatch = new Regex(@"\((\d+)\)[ ]+(.*)").Match(card.name);
            if (cardNameMatch.Success)
            {
                sheet.SetCellValue(rowIndex, 1, cardNameMatch.Groups[2].Value);
            }
            else
            {
                sheet.SetCellValue(rowIndex, 1, cardName);
            }

            var listName = lists[card.idList];
            sheet.SetCellValue(rowIndex, 2, listName);

            sheet.SetCellValue(rowIndex, 3, card.desc.Replace("\n", ""));

            if (cardNameMatch.Success)
            {
                sheet.SetCellValue(rowIndex, 4, cardNameMatch.Groups[1].Value);
            }
            else
            {
                sheet.SetCellValue(rowIndex, 4, 0);
            }

            sheet.SetCellValue(rowIndex, 5, card.url);
        }
    }

    public static class Ensure
    {
        public static string IsNotNullOrEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new AggregateException(message);
            }
            return value;
        }
        public static object IsNotNull(object value, string message)
        {
            if (ReferenceEquals(null, value))
            {
                throw new ArgumentException(message);
            }
            return value;
        }
        public static T? IsNotNull<T>(T? value, string message) where T : struct
        {
            if (!value.HasValue)
            {
                throw new ArgumentException(message);
            }
            return value;
        }
        public static List<T> IsNotNullOrEmpty<T>(IEnumerable<T> sequence, string message)
        {
            if (ReferenceEquals(null, sequence))
            {
                throw new ArgumentException(message);
            }
            if (!sequence.Any())
            {
                throw new ArgumentException(message);
            }
            return sequence.ToList();
        }
    }

    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T, int> handler)
        {
            int row = 0;
            foreach (var item in items)
            {
                handler(item, row++);
            }
        }
    }
}
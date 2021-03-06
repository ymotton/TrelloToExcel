﻿using System;

namespace TrelloToExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0].Equals("-h", StringComparison.InvariantCultureIgnoreCase)
                 || args[0].Equals("--help", StringComparison.InvariantCultureIgnoreCase))

                {
                    Console.WriteLine(@"
In order to use the Trello Board Exporter you need 3 things:
1. The Board Id
2. An Application Key
3. An Access Token

To get them do the following:
1. Log into Trello with the user that has access to the board you want to export.
   The boardId can be found in the board's URL.
2. Generate an Application Key by visiting https://trello.com/1/appKey/generate
3. Requesting a token granting read-only access to the boards the user has access to, forever:
   by visiting https://trello.com/1/authorize?key=substitutewithyourapplicationkey&name=My+Application&expiration=never&response_type=token
   Note that you need to substitute your Application Key and specify a meaningful name.
");
                    return;
                }

                if (args.Length != 3)
                {
                    Console.WriteLine(@"
Usage: {0} [-h|--help] boardId applicationKey accessToken
", Environment.GetCommandLineArgs()[0]);
                    return;
                }
            }

            string boardId = args[0];
            string applicationKey = args[1];
            string memberToken = args[2];
            
            string fileName = BoardExporter.Export(applicationKey, memberToken, boardId);

            Console.WriteLine("Exported to {0}.", fileName);
        }
    }
}

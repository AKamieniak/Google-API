using System.Collections.Generic;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;

namespace GoogleSheetAPI
{
    public static class Service
    {
        private static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        private static SheetsService _service;

        public static void GetConnection()
        {
            GoogleCredential credential;

            using (var stream = new FileStream(Constants.ResourceName, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            // Create Google Service API service.
            _service = new SheetsService(new BaseClientService.Initializer
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = Constants.ApplicationName,
                    });
        }

        public static IList<IList<object>> ReadEntries()
        {
            var range = $"{Constants.Sheet}!A:F";
            var request = _service.Spreadsheets.Values.Get(Constants.SpreadsheetId, range);
            
            var response = request.Execute();
            var values = response.Values;

            return values;
        }

        public static void CreateEntry()
        {
            var range = $"{Constants.Sheet}!A:F";
            var valueRange = new ValueRange();

            var line = new List<object>() { "NewName", "NewSurname", "NewAge" };
            valueRange.Values = new List<IList<object>> { line };

            var appendRequest = _service.Spreadsheets.Values.Append(valueRange, Constants.SpreadsheetId, range);

            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            appendRequest.Execute();
        }

        public static void UpdateEntry()
        {
            var range = $"{Constants.Sheet}!C7";
            var valueRange = new ValueRange();

            var change = new List<object>() { "updated" };
            valueRange.Values = new List<IList<object>> { change };

            var updateRequest = _service.Spreadsheets.Values.Update(valueRange, Constants.SpreadsheetId, range);

            updateRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
            updateRequest.Execute();
        }

        public static void DeleteEntry()
        {
            var range = $"{Constants.Sheet}!A7:C";
            var requestBody = new ClearValuesRequest();

            var deleteRequest = _service.Spreadsheets.Values.Clear(requestBody, Constants.SpreadsheetId, range);
            deleteRequest.Execute();
        }
    }
}

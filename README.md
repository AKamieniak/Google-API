# GoogleAPI
Step by step

## 1. Go to https://console.developers.google.com
## 2. Create a new project

![Capture](https://user-images.githubusercontent.com/30668073/57762576-09d26700-7700-11e9-8eb3-38a3d3436b40.PNG)

## 3. Click Enable API. Search for and enable the Google Drive API and the Google Sheets API.

![Capture](https://user-images.githubusercontent.com/30668073/57763030-e78d1900-7700-11e9-8fc8-ad94bf047f17.PNG)

![222](https://user-images.githubusercontent.com/30668073/57762825-79485680-7700-11e9-98d1-1036803c45a3.PNG)

## 4. Create credentials:

![Capture](https://user-images.githubusercontent.com/30668073/57763403-992c4a00-7701-11e9-9ac1-d0f4ae970ffc.PNG)

![22](https://user-images.githubusercontent.com/30668073/57763408-9b8ea400-7701-11e9-8b6b-205f43212577.PNG)

## 5. Rename downloaded file to "client_secret.json".

![3](https://user-images.githubusercontent.com/30668073/57763413-9df0fe00-7701-11e9-9842-f2bf2150144f.PNG)

## 6. Go to your GoogleSpreadsheet on GoogleDisk, and Share your document to client_email written in client_secret.json.

## 7. In Constants.cs file change:   
        
   ### - ApplicationName: type "Curent " + "your_application_name"
        
   ### - SpreadsheetId:

![Capture](https://user-images.githubusercontent.com/30668073/57763826-8403eb00-7702-11e9-968e-68d9cbad038e.PNG)
        
   ### - Sheet:

![1](https://user-images.githubusercontent.com/30668073/57763824-836b5480-7702-11e9-8a64-6ce26f0452ea.PNG)

# Done!

# Methods: Read, Write, Update, Delete

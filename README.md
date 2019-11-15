
# Email Sender
## Installation

1. Clone the repo                                                                    
   ```> git clone https://github.com/sliziky/EmailSenderWebApp.git```

2. Navigate into the project directory   
   ```> cd EmailSenderWebApp```

3. Run the command   
   ```> dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true```

4. Navigate into the directory  
```> cd EmailSender\bin\Release\netcoreapp3.0\win-x64\publish```
5. Run ```EmailSender.exe```

6. You should see             
          ```info: Microsoft.Hosting.Lifetime[0]```  
```Now listening on: https://localhost:5001```
7. Paste that URL into browser


## Requirements
- ```.NET CORE 3.0```
- Check ```Default app settings -> Email``` is set to ```Outlook```

## Known issues
- App should open Outlook app, not default Email client
- If >20 mails are chosen, App should open ```amountOfChosenEmails // 20 + 1 ``` windows
- Database of people should be updated
- Column ```Address``` should be more specific


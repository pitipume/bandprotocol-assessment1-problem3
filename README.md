# bandprotocol-assessment1-problem3

Steps To Reproduce

Step1
- install .NET SDK (.NET7)
- https://dotnet.microsoft.com/en-us/download/dotnet/7.0
- cd to project
- open project with VsCode or Visual Studio 2022 (But I prefer using Visual Studio 2022 for runing the project with Swagger UI)

Step2
- Open project with Visual Studio 2022
- open ```TransactionBroadcastAPI.sln``` in the path ```\bandprotocol-assessment1-problem3\TransactionBroadcastAPI```
- Click run the project at the green button (or type command ```dotnet run```)
- The Swagger UI will open up

Step3
- POST /broadcast
- Type in the input Payload as you want
- Here is the example of default input Payload
```
{
  "symbol": "LINK", //string
  "price": 18, //uint
  "timestamp": 1678912345 //uint
}
```
- And here will be the example output Response
```
{
  "tx_hash": "ff93c6b4eedf719a74447f527f70844983188a17359a40df9fe32fec6cf327cc"
}
```

Step4
- GET /check/{tx_hash}
- Put the "tx_hash" that you get in the input body
- You will get the Response body, below is the example
```
{
  "tx_status": "PENDING"
}
```
- No worries if you get "PENDING" -> after about approx 30sec ~ 1min you will get the "COMFIRMED" status if everything is correct, example below...
```
{
  "tx_status": "CONFIRMED"
}
```
- Or any other status related to the assessment1 from BandProtocol
```
- `CONFIRMED`: Transaction has been processed and confirmed 
- `FAILED`: Transaction failed to process 
- `PENDING`: Transaction is awaiting processing 
- `DNE`: Transaction does not exist 
```

Step4
- You can use any other tools to run the project and test api as you want
- If you prefer to use Postman, here are the list of URLs for the Http Method
- POST: "https://localhost:7026/broadcast"
- GET: "https://localhost:7026/check/<tx_hash>"

Step5
- I really enjoy when writing this code for the assessment
- Please review and suggest if you have anything. Every comments will be very beneficial for me in term of developing my skills, in order to become a good developer in the future
- Thank you for you time:)
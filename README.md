# MessageMedia REST API C# SDK

Australia's Leading Messaging Solutions for Business and Enterprise.


- API version: 1.0.0
- SDK version: 1.0.0
- Build date: 2016-12-15T03:15:46.430Z
    For more information, please visit [https://www.messagemedia.com/contact-us](https://www.messagemedia.com/contact-us)

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using Model;
```

## Getting Started

```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeliveryReportsApi();

            try
            {
                // Check delivery reports
                Reports result = apiInstance.CheckReports();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryReportsApi.CheckReports: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.messagemedia.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DeliveryReportsApi* | [**CheckReports**](docs/DeliveryReportsApi.md#checkreports) | **GET** /delivery_reports | Check delivery reports
*DeliveryReportsApi* | [**ConfirmReports**](docs/DeliveryReportsApi.md#confirmreports) | **POST** /delivery_reports/confirmed | Confirm delivery reports as received
*MessagingApi* | [**GetMessageStatus**](docs/MessagingApi.md#getmessagestatus) | **GET** /messages/{messageId} | Get the status of a submitted message
*MessagingApi* | [**SendMessages**](docs/MessagingApi.md#sendmessages) | **POST** /messages | Send one or more messages
*MessagingApi* | [**UpdateMessageStatus**](docs/MessagingApi.md#updatemessagestatus) | **PUT** /messages/{messageId} | Cancel a scheduled message
*MessagingReportsApi* | [**GetDeliveryReportsDetail**](docs/MessagingReportsApi.md#getdeliveryreportsdetail) | **GET** /reporting/delivery_reports/detail | Returns a list of delivery reports
*MessagingReportsApi* | [**GetDeliveryReportsSummary**](docs/MessagingReportsApi.md#getdeliveryreportssummary) | **GET** /reporting/delivery_reports/summary | Returns a summarised report of delivery reports
*MessagingReportsApi* | [**GetReceivedMessagesDetail**](docs/MessagingReportsApi.md#getreceivedmessagesdetail) | **GET** /reporting/received_messages/detail | Returns a list message received
*MessagingReportsApi* | [**GetReceivedMessagesSummary**](docs/MessagingReportsApi.md#getreceivedmessagessummary) | **GET** /reporting/received_messages/summary | Returns a summarised report of messages received
*MessagingReportsApi* | [**GetSentMessagesDetail**](docs/MessagingReportsApi.md#getsentmessagesdetail) | **GET** /reporting/sent_messages/detail | Returns a list of message sent
*MessagingReportsApi* | [**GetSentMessagesSummary**](docs/MessagingReportsApi.md#getsentmessagessummary) | **GET** /reporting/sent_messages/summary | Returns a summarised report of messages sent
*RepliesApi* | [**CheckReplies**](docs/RepliesApi.md#checkreplies) | **GET** /replies | Check replies
*RepliesApi* | [**ConfirmReplies**](docs/RepliesApi.md#confirmreplies) | **POST** /replies/confirmed | Confirm replies as received


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.DeliveryReport](docs/DeliveryReport.md)
 - [Model.DeliveryReportId](docs/DeliveryReportId.md)
 - [Model.DeliveryReports](docs/DeliveryReports.md)
 - [Model.InlineResponse400](docs/InlineResponse400.md)
 - [Model.MessageStatusCode](docs/MessageStatusCode.md)
 - [Model.Messages](docs/Messages.md)
 - [Model.NewMessage](docs/NewMessage.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.ReceivedMessage](docs/ReceivedMessage.md)
 - [Model.ReceivedMessages](docs/ReceivedMessages.md)
 - [Model.Replies](docs/Replies.md)
 - [Model.Reply](docs/Reply.md)
 - [Model.ReplyId](docs/ReplyId.md)
 - [Model.ReplyVendorAccountId](docs/ReplyVendorAccountId.md)
 - [Model.Report](docs/Report.md)
 - [Model.ReportingDetailProperties](docs/ReportingDetailProperties.md)
 - [Model.ReportingDetailPropertiesFilters](docs/ReportingDetailPropertiesFilters.md)
 - [Model.ReportingDetailPropertiesSorting](docs/ReportingDetailPropertiesSorting.md)
 - [Model.Reports](docs/Reports.md)
 - [Model.SentMessage](docs/SentMessage.md)
 - [Model.SentMessages](docs/SentMessages.md)
 - [Model.Status](docs/Status.md)
 - [Model.SubmittedMessage](docs/SubmittedMessage.md)
 - [Model.SubmittedMessages](docs/SubmittedMessages.md)
 - [Model.SummaryReport](docs/SummaryReport.md)
 - [Model.SummaryReportData](docs/SummaryReportData.md)
 - [Model.SummaryReportProperties](docs/SummaryReportProperties.md)


## Documentation for Authorization

### basic

- **Type**: HTTP basic authentication


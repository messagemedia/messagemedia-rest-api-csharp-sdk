# MessageMedia REST API C# SDK

Australia's Leading Messaging Solutions for Business and Enterprise.


- API version: 1.0.0
- SDK version: 1.0.0
- Build date: 2017-03-02T02:40:43.226Z
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
*MessagingReportsApi* | [**GetAsyncReportById**](docs/MessagingReportsApi.md#getasyncreportbyid) | **GET** /reporting/async_reports/{report_id} | Gets a single asynchronous report.
*MessagingReportsApi* | [**GetAsyncReportDataById**](docs/MessagingReportsApi.md#getasyncreportdatabyid) | **GET** /reporting/async_reports/{report_id}/data | Gets the data of an asynchronous report.
*MessagingReportsApi* | [**GetAsyncReports**](docs/MessagingReportsApi.md#getasyncreports) | **GET** /reporting/async_reports | Lists asynchronous reports.
*MessagingReportsApi* | [**GetDeliveryReportsDetail**](docs/MessagingReportsApi.md#getdeliveryreportsdetail) | **GET** /reporting/delivery_reports/detail | Returns a list of delivery reports
*MessagingReportsApi* | [**GetDeliveryReportsSummary**](docs/MessagingReportsApi.md#getdeliveryreportssummary) | **GET** /reporting/delivery_reports/summary | Returns a summarised report of delivery reports
*MessagingReportsApi* | [**GetMetadataKeys**](docs/MessagingReportsApi.md#getmetadatakeys) | **GET** /reporting/{messageType}/metadata/keys | Returns a list of metadata keys
*MessagingReportsApi* | [**GetReceivedMessagesDetail**](docs/MessagingReportsApi.md#getreceivedmessagesdetail) | **GET** /reporting/received_messages/detail | Returns a list message received
*MessagingReportsApi* | [**GetReceivedMessagesSummary**](docs/MessagingReportsApi.md#getreceivedmessagessummary) | **GET** /reporting/received_messages/summary | Returns a summarised report of messages received
*MessagingReportsApi* | [**GetSentMessagesDetail**](docs/MessagingReportsApi.md#getsentmessagesdetail) | **GET** /reporting/sent_messages/detail | Returns a list of message sent
*MessagingReportsApi* | [**GetSentMessagesSummary**](docs/MessagingReportsApi.md#getsentmessagessummary) | **GET** /reporting/sent_messages/summary | Returns a summarised report of messages sent
*MessagingReportsApi* | [**SubmitAsyncDeliveryReportsDetail**](docs/MessagingReportsApi.md#submitasyncdeliveryreportsdetail) | **POST** /reporting/delivery_reports/detail/async | Submits a request to generate an async detail report
*MessagingReportsApi* | [**SubmitDeliveryReportsSummary**](docs/MessagingReportsApi.md#submitdeliveryreportssummary) | **POST** /reporting/delivery_reports/summary/async | Submits a summarised report of delivery reports
*MessagingReportsApi* | [**SubmitReceivedMessagesDetail**](docs/MessagingReportsApi.md#submitreceivedmessagesdetail) | **POST** /reporting/received_messages/detail/async | Submits a request to generate an async detail report
*MessagingReportsApi* | [**SubmitReceivedMessagesSummary**](docs/MessagingReportsApi.md#submitreceivedmessagessummary) | **POST** /reporting/received_messages/summary/async | Submits a summarised report of received messages
*MessagingReportsApi* | [**SubmitSentMessagesDetail**](docs/MessagingReportsApi.md#submitsentmessagesdetail) | **POST** /reporting/sent_messages/detail/async | Submits a request to generate an async detail report
*MessagingReportsApi* | [**SubmitSentMessagesSummary**](docs/MessagingReportsApi.md#submitsentmessagessummary) | **POST** /reporting/sent_messages/summary/async | Submits a summarised report of sent messages
*RepliesApi* | [**CheckReplies**](docs/RepliesApi.md#checkreplies) | **GET** /replies | Check replies
*RepliesApi* | [**ConfirmReplies**](docs/RepliesApi.md#confirmreplies) | **POST** /replies/confirmed | Confirm replies as received


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountsBody](docs/AccountsBody.md)
 - [Model.ActionBody](docs/ActionBody.md)
 - [Model.AsyncDeliveryReportDetailRequest](docs/AsyncDeliveryReportDetailRequest.md)
 - [Model.AsyncDeliveryReportsSummaryRequest](docs/AsyncDeliveryReportsSummaryRequest.md)
 - [Model.AsyncDeliverySentMessagesRequest](docs/AsyncDeliverySentMessagesRequest.md)
 - [Model.AsyncReceivedMessagesDetailRequest](docs/AsyncReceivedMessagesDetailRequest.md)
 - [Model.AsyncReceivedMessagesSummaryRequest](docs/AsyncReceivedMessagesSummaryRequest.md)
 - [Model.AsyncReport](docs/AsyncReport.md)
 - [Model.AsyncReportResponse](docs/AsyncReportResponse.md)
 - [Model.AsyncSentMessagesDetailRequest](docs/AsyncSentMessagesDetailRequest.md)
 - [Model.DeliveryOptionsBody](docs/DeliveryOptionsBody.md)
 - [Model.DeliveryOptionsBodyInner](docs/DeliveryOptionsBodyInner.md)
 - [Model.DeliveryReport](docs/DeliveryReport.md)
 - [Model.DeliveryReportBody](docs/DeliveryReportBody.md)
 - [Model.DeliveryReportId](docs/DeliveryReportId.md)
 - [Model.DeliveryReports](docs/DeliveryReports.md)
 - [Model.DestinationAddressBody](docs/DestinationAddressBody.md)
 - [Model.DestinationAddressCountryBody](docs/DestinationAddressCountryBody.md)
 - [Model.EndDateBody](docs/EndDateBody.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse400](docs/InlineResponse400.md)
 - [Model.MessageFormatBody](docs/MessageFormatBody.md)
 - [Model.MessageStatusCode](docs/MessageStatusCode.md)
 - [Model.Messages](docs/Messages.md)
 - [Model.MetadataKeyBody](docs/MetadataKeyBody.md)
 - [Model.MetadataKeysResponse](docs/MetadataKeysResponse.md)
 - [Model.MetadataKeysResponseProperties](docs/MetadataKeysResponseProperties.md)
 - [Model.MetadataValueBody](docs/MetadataValueBody.md)
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
 - [Model.SortDirectionBody](docs/SortDirectionBody.md)
 - [Model.SourceAddressBody](docs/SourceAddressBody.md)
 - [Model.SourceAddressCountryBody](docs/SourceAddressCountryBody.md)
 - [Model.StartDateBody](docs/StartDateBody.md)
 - [Model.Status](docs/Status.md)
 - [Model.StatusBody](docs/StatusBody.md)
 - [Model.StatusCodeBody](docs/StatusCodeBody.md)
 - [Model.SubmittedMessage](docs/SubmittedMessage.md)
 - [Model.SubmittedMessages](docs/SubmittedMessages.md)
 - [Model.SummaryByBody](docs/SummaryByBody.md)
 - [Model.SummaryFieldBody](docs/SummaryFieldBody.md)
 - [Model.SummaryReport](docs/SummaryReport.md)
 - [Model.SummaryReportData](docs/SummaryReportData.md)
 - [Model.SummaryReportProperties](docs/SummaryReportProperties.md)
 - [Model.TimezoneBody](docs/TimezoneBody.md)


## Documentation for Authorization

### basic

- **Type**: HTTP basic authentication


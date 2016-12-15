# MessageMedia.REST.API.Api.MessagingApi

All URIs are relative to *https://api.messagemedia.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMessageStatus**](MessagingApi.md#getmessagestatus) | **GET** /messages/{messageId} | Get the status of a submitted message
[**SendMessages**](MessagingApi.md#sendmessages) | **POST** /messages | Send one or more messages
[**UpdateMessageStatus**](MessagingApi.md#updatemessagestatus) | **PUT** /messages/{messageId} | Cancel a scheduled message


<a name="getmessagestatus"></a>
# **GetMessageStatus**
> SubmittedMessage GetMessageStatus (Guid? messageId)

Get the status of a submitted message

Get the status and details of a previously submitted message

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class GetMessageStatusExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagingApi();
            var messageId = messageId_example;  // Guid? | Unique ID representing message that has been submitted

            try
            {
                // Get the status of a submitted message
                SubmittedMessage result = apiInstance.GetMessageStatus(messageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMessageStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **Guid?**| Unique ID representing message that has been submitted | 

### Return type

[**SubmittedMessage**](SubmittedMessage.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmessages"></a>
# **SendMessages**
> SubmittedMessages SendMessages (Messages messages)

Send one or more messages

Submit one or more (up to 100 per request) SMS or text to voice messages to be sent to the destination address. - A callback URL can be included with each message to which MO and DR notifications will be pushed to via a HTTP POST request. - The content of the message can be a Unicode string, up to 5000 characters long - A delivery report can be be requested with the message which will be pushed to a HTTP endpoint if specified, or available via the Check Reports endpoint. - The destination number should be specified in E.164 international format. For information on E.164, please refer to http://en.wikipedia.org/wiki/E.164 - The format specifies which format the message will be sent as, SMS or VOICE - If specified the source number included in the request will be shown as the source number for the message, this feature is not enabled by default, please contact MessageMedia for more information. - If a source number is specified, the type of source number may also be specified. This is recommended when using a source address type that is not an internationally formatted number, available options are INTERNATIONAL, ALPHANUMERIC or SHORTCODE - The message will be scheduled to be delivered in the future if the scheduled parameter is specified. - A message expiry timestamp can be provided, if the message is not delivered by this time, it will be discarded. - Metadata can be included with the message. Up to 10 key value pair strings can be included with each message. This metadata will be available in delivery reports and replies.

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class SendMessagesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagingApi();
            var messages = new Messages(); // Messages | A list of messages to be sent

            try
            {
                // Send one or more messages
                SubmittedMessages result = apiInstance.SendMessages(messages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.SendMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messages** | [**Messages**](Messages.md)| A list of messages to be sent | 

### Return type

[**SubmittedMessages**](SubmittedMessages.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemessagestatus"></a>
# **UpdateMessageStatus**
> void UpdateMessageStatus (Guid? messageId, Status status)

Cancel a scheduled message

Cancel a scheduled message

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class UpdateMessageStatusExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagingApi();
            var messageId = messageId_example;  // Guid? | Unique ID representing message to be updated
            var status = new Status(); // Status | New status for the message

            try
            {
                // Cancel a scheduled message
                apiInstance.UpdateMessageStatus(messageId, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.UpdateMessageStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **Guid?**| Unique ID representing message to be updated | 
 **status** | [**Status**](Status.md)| New status for the message | 

### Return type

void (empty response body)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


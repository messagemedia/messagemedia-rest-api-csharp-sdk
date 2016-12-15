# MessageMedia.REST.API.Api.RepliesApi

All URIs are relative to *https://api.messagemedia.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckReplies**](RepliesApi.md#checkreplies) | **GET** /replies | Check replies
[**ConfirmReplies**](RepliesApi.md#confirmreplies) | **POST** /replies/confirmed | Confirm replies as received


<a name="checkreplies"></a>
# **CheckReplies**
> Replies CheckReplies ()

Check replies

Return up to 100 reply messages that have been received and haven't  been confirmed using the confirm replies endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class CheckRepliesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RepliesApi();

            try
            {
                // Check replies
                Replies result = apiInstance.CheckReplies();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepliesApi.CheckReplies: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Replies**](Replies.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmreplies"></a>
# **ConfirmReplies**
> void ConfirmReplies (ReplyId replyId)

Confirm replies as received

Confirm the specified replies as being received so they will no longer be returned in check replies requests

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class ConfirmRepliesExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new RepliesApi();
            var replyId = new ReplyId(); // ReplyId | A list of reply IDs to mark as confirmed

            try
            {
                // Confirm replies as received
                apiInstance.ConfirmReplies(replyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepliesApi.ConfirmReplies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replyId** | [**ReplyId**](ReplyId.md)| A list of reply IDs to mark as confirmed | 

### Return type

void (empty response body)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# MessageMedia.REST.API.Api.MessagingReportsApi

All URIs are relative to *https://api.messagemedia.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDeliveryReportsDetail**](MessagingReportsApi.md#getdeliveryreportsdetail) | **GET** /reporting/delivery_reports/detail | Returns a list of delivery reports
[**GetDeliveryReportsSummary**](MessagingReportsApi.md#getdeliveryreportssummary) | **GET** /reporting/delivery_reports/summary | Returns a summarised report of delivery reports
[**GetReceivedMessagesDetail**](MessagingReportsApi.md#getreceivedmessagesdetail) | **GET** /reporting/received_messages/detail | Returns a list message received
[**GetReceivedMessagesSummary**](MessagingReportsApi.md#getreceivedmessagessummary) | **GET** /reporting/received_messages/summary | Returns a summarised report of messages received
[**GetSentMessagesDetail**](MessagingReportsApi.md#getsentmessagesdetail) | **GET** /reporting/sent_messages/detail | Returns a list of message sent
[**GetSentMessagesSummary**](MessagingReportsApi.md#getsentmessagessummary) | **GET** /reporting/sent_messages/summary | Returns a summarised report of messages sent


<a name="getdeliveryreportsdetail"></a>
# **GetDeliveryReportsDetail**
> DeliveryReports GetDeliveryReportsDetail (DateTime? endDate, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)

Returns a list of delivery reports

Returns a detailed list of all delivery reports received during the specified time

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class GetDeliveryReportsDetailExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagingReportsApi();
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var accounts = accounts_example;  // string | Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional) 
            var destinationAddressCountry = destinationAddressCountry_example;  // string | Filter results by destination address country. (optional) 
            var destinationAddress = destinationAddress_example;  // string | Filter results by destination address. (optional) 
            var messageFormat = messageFormat_example;  // string | Filter results by message format. (optional) 
            var metadataKey = metadataKey_example;  // string | Filter results for messages that include a metadata key. (optional) 
            var metadataValue = metadataValue_example;  // string | Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional) 
            var statusCode = statusCode_example;  // string | Filter results by message status code. (optional) 
            var status = status_example;  // string | Filter results by message status. (optional) 
            var page = 56;  // int? | Page number for paging through paginated result sets. (optional) 
            var pageSize = 56;  // int? | Number of results to return in a page for paginated result sets. (optional) 
            var sortBy = sortBy_example;  // string | Field to sort results set by (optional) 
            var sortDirection = sortDirection_example;  // string | Order to sort results by. (optional) 
            var sourceAddressCountry = sourceAddressCountry_example;  // string | Filter results by source address country. (optional) 
            var sourceAddress = sourceAddress_example;  // string | Filter results by source address. (optional) 
            var timezone = timezone_example;  // string | The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. 'Australia/Melbourne'. (optional) 

            try
            {
                // Returns a list of delivery reports
                DeliveryReports result = apiInstance.GetDeliveryReportsDetail(endDate, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingReportsApi.GetDeliveryReportsDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endDate** | **DateTime?**| End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **startDate** | **DateTime?**| Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **accounts** | **string**| Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. | [optional] 
 **destinationAddressCountry** | **string**| Filter results by destination address country. | [optional] 
 **destinationAddress** | **string**| Filter results by destination address. | [optional] 
 **messageFormat** | **string**| Filter results by message format. | [optional] 
 **metadataKey** | **string**| Filter results for messages that include a metadata key. | [optional] 
 **metadataValue** | **string**| Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. | [optional] 
 **statusCode** | **string**| Filter results by message status code. | [optional] 
 **status** | **string**| Filter results by message status. | [optional] 
 **page** | **int?**| Page number for paging through paginated result sets. | [optional] 
 **pageSize** | **int?**| Number of results to return in a page for paginated result sets. | [optional] 
 **sortBy** | **string**| Field to sort results set by | [optional] 
 **sortDirection** | **string**| Order to sort results by. | [optional] 
 **sourceAddressCountry** | **string**| Filter results by source address country. | [optional] 
 **sourceAddress** | **string**| Filter results by source address. | [optional] 
 **timezone** | **string**| The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. | [optional] 

### Return type

[**DeliveryReports**](DeliveryReports.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdeliveryreportssummary"></a>
# **GetDeliveryReportsSummary**
> SummaryReport GetDeliveryReportsSummary (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)

Returns a summarised report of delivery reports

Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class GetDeliveryReportsSummaryExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagingReportsApi();
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var groupBy = groupBy_example;  // string | Field to group results set by
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var accounts = accounts_example;  // string | Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional) 
            var destinationAddressCountry = destinationAddressCountry_example;  // string | Filter results by destination address country. (optional) 
            var destinationAddress = destinationAddress_example;  // string | Filter results by destination address. (optional) 
            var messageFormat = messageFormat_example;  // string | Filter results by message format. (optional) 
            var metadataKey = metadataKey_example;  // string | Filter results for messages that include a metadata key. (optional) 
            var metadataValue = metadataValue_example;  // string | Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional) 
            var statusCode = statusCode_example;  // string | Filter results by message status code. (optional) 
            var status = status_example;  // string | Filter results by message status. (optional) 
            var summaryBy = summaryBy_example;  // string | Function to apply when summarising results (optional) 
            var summaryField = summaryField_example;  // string | Field to summarise results by (optional) 
            var sourceAddressCountry = sourceAddressCountry_example;  // string | Filter results by source address country. (optional) 
            var sourceAddress = sourceAddress_example;  // string | Filter results by source address. (optional) 
            var timezone = timezone_example;  // string | The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. 'Australia/Melbourne'. (optional) 

            try
            {
                // Returns a summarised report of delivery reports
                SummaryReport result = apiInstance.GetDeliveryReportsSummary(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingReportsApi.GetDeliveryReportsSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endDate** | **DateTime?**| End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **groupBy** | **string**| Field to group results set by | 
 **startDate** | **DateTime?**| Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **accounts** | **string**| Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. | [optional] 
 **destinationAddressCountry** | **string**| Filter results by destination address country. | [optional] 
 **destinationAddress** | **string**| Filter results by destination address. | [optional] 
 **messageFormat** | **string**| Filter results by message format. | [optional] 
 **metadataKey** | **string**| Filter results for messages that include a metadata key. | [optional] 
 **metadataValue** | **string**| Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. | [optional] 
 **statusCode** | **string**| Filter results by message status code. | [optional] 
 **status** | **string**| Filter results by message status. | [optional] 
 **summaryBy** | **string**| Function to apply when summarising results | [optional] 
 **summaryField** | **string**| Field to summarise results by | [optional] 
 **sourceAddressCountry** | **string**| Filter results by source address country. | [optional] 
 **sourceAddress** | **string**| Filter results by source address. | [optional] 
 **timezone** | **string**| The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. | [optional] 

### Return type

[**SummaryReport**](SummaryReport.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceivedmessagesdetail"></a>
# **GetReceivedMessagesDetail**
> ReceivedMessages GetReceivedMessagesDetail (DateTime? endDate, DateTime? startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)

Returns a list message received

Returns a detailed list of all message received during the specified time

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class GetReceivedMessagesDetailExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagingReportsApi();
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var accounts = accounts_example;  // string | Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional) 
            var action = action_example;  // string | Filter results by the action that was invoked for this message. (optional) 
            var destinationAddressCountry = destinationAddressCountry_example;  // string | Filter results by destination address country. (optional) 
            var destinationAddress = destinationAddress_example;  // string | Filter results by destination address. (optional) 
            var messageFormat = messageFormat_example;  // string | Filter results by message format. (optional) 
            var metadataKey = metadataKey_example;  // string | Filter results for messages that include a metadata key. (optional) 
            var metadataValue = metadataValue_example;  // string | Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional) 
            var page = 56;  // int? | Page number for paging through paginated result sets. (optional) 
            var pageSize = 56;  // int? | Number of results to return in a page for paginated result sets. (optional) 
            var sortBy = sortBy_example;  // string | Field to sort results set by (optional) 
            var sortDirection = sortDirection_example;  // string | Order to sort results by. (optional) 
            var sourceAddressCountry = sourceAddressCountry_example;  // string | Filter results by source address country. (optional) 
            var sourceAddress = sourceAddress_example;  // string | Filter results by source address. (optional) 
            var timezone = timezone_example;  // string | The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. 'Australia/Melbourne'. (optional) 

            try
            {
                // Returns a list message received
                ReceivedMessages result = apiInstance.GetReceivedMessagesDetail(endDate, startDate, accounts, action, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingReportsApi.GetReceivedMessagesDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endDate** | **DateTime?**| End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **startDate** | **DateTime?**| Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **accounts** | **string**| Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. | [optional] 
 **action** | **string**| Filter results by the action that was invoked for this message. | [optional] 
 **destinationAddressCountry** | **string**| Filter results by destination address country. | [optional] 
 **destinationAddress** | **string**| Filter results by destination address. | [optional] 
 **messageFormat** | **string**| Filter results by message format. | [optional] 
 **metadataKey** | **string**| Filter results for messages that include a metadata key. | [optional] 
 **metadataValue** | **string**| Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. | [optional] 
 **page** | **int?**| Page number for paging through paginated result sets. | [optional] 
 **pageSize** | **int?**| Number of results to return in a page for paginated result sets. | [optional] 
 **sortBy** | **string**| Field to sort results set by | [optional] 
 **sortDirection** | **string**| Order to sort results by. | [optional] 
 **sourceAddressCountry** | **string**| Filter results by source address country. | [optional] 
 **sourceAddress** | **string**| Filter results by source address. | [optional] 
 **timezone** | **string**| The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. | [optional] 

### Return type

[**ReceivedMessages**](ReceivedMessages.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceivedmessagessummary"></a>
# **GetReceivedMessagesSummary**
> SummaryReport GetReceivedMessagesSummary (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)

Returns a summarised report of messages received

Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class GetReceivedMessagesSummaryExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagingReportsApi();
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var groupBy = groupBy_example;  // string | Field to group results set by
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var accounts = accounts_example;  // string | Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional) 
            var destinationAddressCountry = destinationAddressCountry_example;  // string | Filter results by destination address country. (optional) 
            var destinationAddress = destinationAddress_example;  // string | Filter results by destination address. (optional) 
            var messageFormat = messageFormat_example;  // string | Filter results by message format. (optional) 
            var metadataKey = metadataKey_example;  // string | Filter results for messages that include a metadata key. (optional) 
            var metadataValue = metadataValue_example;  // string | Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional) 
            var summaryBy = summaryBy_example;  // string | Function to apply when summarising results (optional) 
            var summaryField = summaryField_example;  // string | Field to summarise results by (optional) 
            var sourceAddressCountry = sourceAddressCountry_example;  // string | Filter results by source address country. (optional) 
            var sourceAddress = sourceAddress_example;  // string | Filter results by source address. (optional) 
            var timezone = timezone_example;  // string | The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. 'Australia/Melbourne'. (optional) 

            try
            {
                // Returns a summarised report of messages received
                SummaryReport result = apiInstance.GetReceivedMessagesSummary(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingReportsApi.GetReceivedMessagesSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endDate** | **DateTime?**| End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **groupBy** | **string**| Field to group results set by | 
 **startDate** | **DateTime?**| Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **accounts** | **string**| Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. | [optional] 
 **destinationAddressCountry** | **string**| Filter results by destination address country. | [optional] 
 **destinationAddress** | **string**| Filter results by destination address. | [optional] 
 **messageFormat** | **string**| Filter results by message format. | [optional] 
 **metadataKey** | **string**| Filter results for messages that include a metadata key. | [optional] 
 **metadataValue** | **string**| Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. | [optional] 
 **summaryBy** | **string**| Function to apply when summarising results | [optional] 
 **summaryField** | **string**| Field to summarise results by | [optional] 
 **sourceAddressCountry** | **string**| Filter results by source address country. | [optional] 
 **sourceAddress** | **string**| Filter results by source address. | [optional] 
 **timezone** | **string**| The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. | [optional] 

### Return type

[**SummaryReport**](SummaryReport.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsentmessagesdetail"></a>
# **GetSentMessagesDetail**
> SentMessages GetSentMessagesDetail (DateTime? endDate, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)

Returns a list of message sent

Returns a detailed list of all message sent during the specified time

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class GetSentMessagesDetailExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagingReportsApi();
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var accounts = accounts_example;  // string | Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional) 
            var deliveryReport = true;  // bool? | Filter results by delivery report. (optional) 
            var destinationAddressCountry = destinationAddressCountry_example;  // string | Filter results by destination address country. (optional) 
            var destinationAddress = destinationAddress_example;  // string | Filter results by destination address. (optional) 
            var messageFormat = messageFormat_example;  // string | Filter results by message format. (optional) 
            var metadataKey = metadataKey_example;  // string | Filter results for messages that include a metadata key. (optional) 
            var metadataValue = metadataValue_example;  // string | Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional) 
            var statusCode = statusCode_example;  // string | Filter results by message status code. (optional) 
            var status = status_example;  // string | Filter results by message status. (optional) 
            var page = 56;  // int? | Page number for paging through paginated result sets. (optional) 
            var pageSize = 56;  // int? | Number of results to return in a page for paginated result sets. (optional) 
            var sortBy = sortBy_example;  // string | Field to sort results set by (optional) 
            var sortDirection = sortDirection_example;  // string | Order to sort results by. (optional) 
            var sourceAddressCountry = sourceAddressCountry_example;  // string | Filter results by source address country. (optional) 
            var sourceAddress = sourceAddress_example;  // string | Filter results by source address. (optional) 
            var timezone = timezone_example;  // string | The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. 'Australia/Melbourne'. (optional) 

            try
            {
                // Returns a list of message sent
                SentMessages result = apiInstance.GetSentMessagesDetail(endDate, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingReportsApi.GetSentMessagesDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endDate** | **DateTime?**| End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **startDate** | **DateTime?**| Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **accounts** | **string**| Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. | [optional] 
 **deliveryReport** | **bool?**| Filter results by delivery report. | [optional] 
 **destinationAddressCountry** | **string**| Filter results by destination address country. | [optional] 
 **destinationAddress** | **string**| Filter results by destination address. | [optional] 
 **messageFormat** | **string**| Filter results by message format. | [optional] 
 **metadataKey** | **string**| Filter results for messages that include a metadata key. | [optional] 
 **metadataValue** | **string**| Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. | [optional] 
 **statusCode** | **string**| Filter results by message status code. | [optional] 
 **status** | **string**| Filter results by message status. | [optional] 
 **page** | **int?**| Page number for paging through paginated result sets. | [optional] 
 **pageSize** | **int?**| Number of results to return in a page for paginated result sets. | [optional] 
 **sortBy** | **string**| Field to sort results set by | [optional] 
 **sortDirection** | **string**| Order to sort results by. | [optional] 
 **sourceAddressCountry** | **string**| Filter results by source address country. | [optional] 
 **sourceAddress** | **string**| Filter results by source address. | [optional] 
 **timezone** | **string**| The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. | [optional] 

### Return type

[**SentMessages**](SentMessages.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsentmessagessummary"></a>
# **GetSentMessagesSummary**
> SummaryReport GetSentMessagesSummary (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)

Returns a summarised report of messages sent

Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class GetSentMessagesSummaryExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new MessagingReportsApi();
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var groupBy = groupBy_example;  // string | Field to group results set by
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.
            var accounts = accounts_example;  // string | Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional) 
            var deliveryReport = true;  // bool? | Filter results by delivery report. (optional) 
            var destinationAddressCountry = destinationAddressCountry_example;  // string | Filter results by destination address country. (optional) 
            var destinationAddress = destinationAddress_example;  // string | Filter results by destination address. (optional) 
            var summaryBy = summaryBy_example;  // string | Function to apply when summarising results (optional) 
            var summaryField = summaryField_example;  // string | Field to summarise results by (optional) 
            var messageFormat = messageFormat_example;  // string | Filter results by message format. (optional) 
            var metadataKey = metadataKey_example;  // string | Filter results for messages that include a metadata key. (optional) 
            var metadataValue = metadataValue_example;  // string | Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional) 
            var statusCode = statusCode_example;  // string | Filter results by message status code. (optional) 
            var sourceAddressCountry = sourceAddressCountry_example;  // string | Filter results by source address country. (optional) 
            var sourceAddress = sourceAddress_example;  // string | Filter results by source address. (optional) 
            var timezone = timezone_example;  // string | The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. 'Australia/Melbourne'. (optional) 

            try
            {
                // Returns a summarised report of messages sent
                SummaryReport result = apiInstance.GetSentMessagesSummary(endDate, groupBy, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, summaryBy, summaryField, messageFormat, metadataKey, metadataValue, statusCode, sourceAddressCountry, sourceAddress, timezone);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingReportsApi.GetSentMessagesSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **endDate** | **DateTime?**| End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **groupBy** | **string**| Field to group results set by | 
 **startDate** | **DateTime?**| Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. | 
 **accounts** | **string**| Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. | [optional] 
 **deliveryReport** | **bool?**| Filter results by delivery report. | [optional] 
 **destinationAddressCountry** | **string**| Filter results by destination address country. | [optional] 
 **destinationAddress** | **string**| Filter results by destination address. | [optional] 
 **summaryBy** | **string**| Function to apply when summarising results | [optional] 
 **summaryField** | **string**| Field to summarise results by | [optional] 
 **messageFormat** | **string**| Filter results by message format. | [optional] 
 **metadataKey** | **string**| Filter results for messages that include a metadata key. | [optional] 
 **metadataValue** | **string**| Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. | [optional] 
 **statusCode** | **string**| Filter results by message status code. | [optional] 
 **sourceAddressCountry** | **string**| Filter results by source address country. | [optional] 
 **sourceAddress** | **string**| Filter results by source address. | [optional] 
 **timezone** | **string**| The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. | [optional] 

### Return type

[**SummaryReport**](SummaryReport.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


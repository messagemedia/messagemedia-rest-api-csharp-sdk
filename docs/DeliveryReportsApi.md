# MessageMedia.REST.API.Api.DeliveryReportsApi

All URIs are relative to *https://api.messagemedia.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckReports**](DeliveryReportsApi.md#checkreports) | **GET** /delivery_reports | Check delivery reports
[**ConfirmReports**](DeliveryReportsApi.md#confirmreports) | **POST** /delivery_reports/confirmed | Confirm delivery reports as received


<a name="checkreports"></a>
# **CheckReports**
> Reports CheckReports ()

Check delivery reports

Return up to 100 delivery reports that have been received and haven't  been confirmed using the confirm reports endpoint

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class CheckReportsExample
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

### Parameters
This endpoint does not need any parameter.

### Return type

[**Reports**](Reports.md)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmreports"></a>
# **ConfirmReports**
> void ConfirmReports (DeliveryReportId deliveryReportId)

Confirm delivery reports as received

Confirm the specified delivery reports as being received so they will no longer be returned in check delivery reports requests

### Example
```csharp
using System;
using System.Diagnostics;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace Example
{
    public class ConfirmReportsExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basic
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DeliveryReportsApi();
            var deliveryReportId = new DeliveryReportId(); // DeliveryReportId | A list of delivery report IDs to mark as confirmed

            try
            {
                // Confirm delivery reports as received
                apiInstance.ConfirmReports(deliveryReportId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryReportsApi.ConfirmReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryReportId** | [**DeliveryReportId**](DeliveryReportId.md)| A list of delivery report IDs to mark as confirmed | 

### Return type

void (empty response body)

### Authorization

[basic](../README.md#basic)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


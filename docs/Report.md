# MessageMedia.REST.API.Model.Report
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallbackUrl** | **string** | The URL specified as the callback URL in the original submit message request | [optional] 
**DateReceived** | **DateTime?** | The date and time at which this delivery report was generated in UTC. | [optional] 
**Delay** | **int?** | Deprecated, no longer in use | [optional] 
**DeliveryReportId** | **Guid?** | Unique ID for this delivery report | [optional] 
**MessageId** | **Guid?** | Unique ID of the original message | [optional] 
**Metadata** | **Object** | Any metadata that was included in the original submit message request | [optional] 
**OriginalText** | **string** | Text of the original message. | [optional] 
**SourceNumber** | **string** | Address from which this delivery report was received | [optional] 
**Status** | **string** | The status of the message as per the delivery report | [optional] 
**SubmittedDate** | **DateTime?** | The date and time when the message status changed in UTC. For a delivered DR this may indicate the time at which the message was received on the handset. | [optional] 
**VendorAccountId** | [**ReplyVendorAccountId**](ReplyVendorAccountId.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


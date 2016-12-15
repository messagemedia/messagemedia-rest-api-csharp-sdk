# MessageMedia.REST.API.Model.Reply
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallbackUrl** | **string** | The URL specified as the callback URL in the original submit message request | [optional] 
**Content** | **string** | Content of the reply | [optional] 
**DateReceived** | **DateTime?** | Date time when the reply was received | [optional] 
**DestinationNumber** | **string** | Address from which this reply was sent to | [optional] 
**MessageId** | **Guid?** | Unique ID of the original message | [optional] 
**Metadata** | **Object** | Any metadata that was included in the original submit message request | [optional] 
**ReplyId** | **Guid?** | Unique ID of this reply | [optional] 
**SourceNumber** | **string** | Address from which this reply was received from | [optional] 
**VendorAccountId** | [**ReplyVendorAccountId**](ReplyVendorAccountId.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


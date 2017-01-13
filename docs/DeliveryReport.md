# MessageMedia.REST.API.Model.DeliveryReport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Account associated with this delivery report | [optional] 
**DestinationAddress** | **string** | Address this delivery report was delivered to. This is the source address of the sent message that this delivery report is in response to | [optional] 
**DestinationAddressCountry** | **string** | Country associated with the destination address | [optional] 
**Format** | **string** | Format of message, SMS or TTS (Text To Speech) | [optional] 
**Id** | **Guid?** | Unique ID for this delivery report | [optional] 
**InResponseTo** | **Guid?** | Unique ID of the sent message that this delivery report is in response to | [optional] 
**Metadata** | **Object** | Metadata associated with the sent message | [optional] 
**SourceAddress** | **string** | Address this delivery report was received from, the destination address of the sent message that this delivery report is in response to | [optional] 
**SourceAddressCountry** | **string** | Country associated with the source address | [optional] 
**Status** | **string** | Status of the message | [optional] 
**StatusCode** | [**MessageStatusCode**](MessageStatusCode.md) |  | [optional] 
**Timestamp** | **DateTime?** | Date time at which this delivery report was received | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


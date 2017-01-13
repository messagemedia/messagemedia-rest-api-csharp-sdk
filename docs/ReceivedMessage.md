# MessageMedia.REST.API.Model.ReceivedMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Account associated with this message | [optional] 
**Action** | **string** | Action that was invoked for this message if any, OPTOUT, OPTIN, GLOBALOPTOUT | [optional] 
**Content** | **string** | Content of the message | [optional] 
**DestinationAddress** | **string** | Address this message was delivered to. If this message was received in response to a sent message, this is the source address of the sent message | [optional] 
**DestinationAddressCountry** | **string** | Country associated with the destination address | [optional] 
**Format** | **string** | Format of message, SMS or TTS (Text To Speech) | [optional] 
**Id** | **Guid?** | Unique ID for this reply | [optional] 
**InResponseTo** | **Guid?** | If this message was received in response to a sent message, this is the ID of the sent message | [optional] 
**Metadata** | **Object** | If this message was received in response to a sent message, this is the metadata associated with the sent message | [optional] 
**SourceAddress** | **string** | Address this message was received from. If this message was received in response to a sent message, this is the destination address of the sent message. | [optional] 
**SourceAddressCountry** | **string** | Country associated with the source address | [optional] 
**Timestamp** | **DateTime?** | Date time at which this message was received | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


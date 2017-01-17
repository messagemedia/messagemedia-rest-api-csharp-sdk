# MessageMedia.REST.API.Model.SentMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Account associated with this message | [optional] 
**Content** | **string** | Content of the message | [optional] 
**DeliveredTimestamp** | **DateTime?** | If a delivery report was requested for this message, this is the time at which the message was delivered (or failed to be delivered) to the destination address. | [optional] 
**DeliveryReport** | **bool?** | Indicates if a delivery report was requested for this message | [optional] 
**DestinationAddress** | **string** | Address this message was delivered to | [optional] 
**DestinationAddressCountry** | **string** | Country associated with the destination address | [optional] 
**Format** | **string** | Format of message, SMS or TTS (Text To Speech) | [optional] 
**Id** | **Guid?** | Unique ID for this message | [optional] 
**InResponseTo** | **Guid?** | If this message was sent in response to a received message (an auto response message for example) this is the ID of the received message. | [optional] 
**Metadata** | **Object** | Metadata associated with this message | [optional] 
**SourceAddress** | **string** | Address this message was sent from | [optional] 
**SourceAddressCountry** | **string** | Country associated with the source address | [optional] 
**Units** | **int?** | The total number of calculated SMS units this message cost. 1 SMS unit is defined as 160 GSM characters, or 153 GSM characters for multi-part messages as some characters are used to concatenate the message on the receiving handset. Messages with one or more non-GSM characters will be submitted using UCS-2 encoding. UCS-2 encoding means the message has a maximum of 70 characters per SMS, or 67 characters for multi-part messages. | [optional] 
**Timestamp** | **DateTime?** | Date time at which this message was submitted to the API, refer to the delivered timestamp for the time at which the message was delivered (or failed to be delivered) to the destination address. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# MessageMedia.REST.API.Model.NewMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallbackUrl** | **string** | URL replies and delivery reports to this message will be pushed to | [optional] 
**Content** | **string** | Content of the message | [optional] 
**DestinationNumber** | **string** | Destination number of the message | [optional] 
**DeliveryReport** | **bool?** | Request a delivery report for this message | [optional] [default to false]
**Format** | **string** | Format of message, SMS or VOICE. | [optional] 
**MessageExpiryTimestamp** | **DateTime?** | Date time after which the message expires and will not be sent | [optional] 
**Metadata** | **Object** | Metadata for the message specified as a set of key value pairs, each key can be up to 100 characters long and each value can be up to 256 characters long &#x60;&#x60;&#x60; {    \&quot;myKey\&quot;: \&quot;myValue\&quot;,    \&quot;anotherKey\&quot;: \&quot;anotherValue\&quot; } &#x60;&#x60;&#x60;  | [optional] 
**Scheduled** | **DateTime?** | Scheduled delivery date time of the message | [optional] 
**SourceNumber** | **string** |  | [optional] 
**SourceNumberType** | **string** | Type of source address specified, this can be INTERNATIONAL, ALPHANUMERIC or SHORTCODE | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


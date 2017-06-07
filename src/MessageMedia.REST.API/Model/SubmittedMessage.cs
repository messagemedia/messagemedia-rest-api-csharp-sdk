/* 
 * MessageMedia REST API
 *
 * Australia's Leading Messaging Solutions for Business and Enterprise.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@messagemedia.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MessageMedia.REST.API.Model
{
    /// <summary>
    /// SubmittedMessage
    /// </summary>
    [DataContract]
    public partial class SubmittedMessage :  IEquatable<SubmittedMessage>
    {
        /// <summary>
        /// Format of message, SMS or TTS (Text To Speech).
        /// </summary>
        /// <value>Format of message, SMS or TTS (Text To Speech).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum SMS for "SMS"
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMS,
            
            /// <summary>
            /// Enum TTS for "TTS"
            /// </summary>
            [EnumMember(Value = "TTS")]
            TTS
        }

        /// <summary>
        /// Type of source address specified, this can be INTERNATIONAL, ALPHANUMERIC or SHORTCODE
        /// </summary>
        /// <value>Type of source address specified, this can be INTERNATIONAL, ALPHANUMERIC or SHORTCODE</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceNumberTypeEnum
        {
            
            /// <summary>
            /// Enum INTERNATIONAL for "INTERNATIONAL"
            /// </summary>
            [EnumMember(Value = "INTERNATIONAL")]
            INTERNATIONAL,
            
            /// <summary>
            /// Enum ALPHANUMERIC for "ALPHANUMERIC"
            /// </summary>
            [EnumMember(Value = "ALPHANUMERIC")]
            ALPHANUMERIC,
            
            /// <summary>
            /// Enum SHORTCODE for "SHORTCODE"
            /// </summary>
            [EnumMember(Value = "SHORTCODE")]
            SHORTCODE
        }

        /// <summary>
        /// The status of the message
        /// </summary>
        /// <value>The status of the message</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Enroute for "enroute"
            /// </summary>
            [EnumMember(Value = "enroute")]
            Enroute,
            
            /// <summary>
            /// Enum Submitted for "submitted"
            /// </summary>
            [EnumMember(Value = "submitted")]
            Submitted,
            
            /// <summary>
            /// Enum Delivered for "delivered"
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered,
            
            /// <summary>
            /// Enum Expired for "expired"
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired,
            
            /// <summary>
            /// Enum Rejected for "rejected"
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Undeliverable for "undeliverable"
            /// </summary>
            [EnumMember(Value = "undeliverable")]
            Undeliverable,
            
            /// <summary>
            /// Enum Queued for "queued"
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued,
            
            /// <summary>
            /// Enum Processed for "processed"
            /// </summary>
            [EnumMember(Value = "processed")]
            Processed,
            
            /// <summary>
            /// Enum Cancelled for "cancelled"
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled,
            
            /// <summary>
            /// Enum Scheduled for "scheduled"
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed
        }

        /// <summary>
        /// Format of message, SMS or TTS (Text To Speech).
        /// </summary>
        /// <value>Format of message, SMS or TTS (Text To Speech).</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Type of source address specified, this can be INTERNATIONAL, ALPHANUMERIC or SHORTCODE
        /// </summary>
        /// <value>Type of source address specified, this can be INTERNATIONAL, ALPHANUMERIC or SHORTCODE</value>
        [DataMember(Name="source_number_type", EmitDefaultValue=false)]
        public SourceNumberTypeEnum? SourceNumberType { get; set; }
        /// <summary>
        /// The status of the message
        /// </summary>
        /// <value>The status of the message</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmittedMessage" /> class.
        /// </summary>
        /// <param name="CallbackUrl">URL replies and delivery reports to this message will be pushed to.</param>
        /// <param name="Content">Content of the message.</param>
        /// <param name="DestinationNumber">Destination number of the message.</param>
        /// <param name="DeliveryReport">Request a delivery report for this message (default to false).</param>
        /// <param name="Format">Format of message, SMS or TTS (Text To Speech)..</param>
        /// <param name="MessageExpiryTimestamp">Date time after which the message expires and will not be sent.</param>
        /// <param name="Metadata">Metadata for the message specified as a set of key value pairs, each key can be up to 100 characters long and each value can be up to 256 characters long &#x60;&#x60;&#x60; {    \&quot;myKey\&quot;: \&quot;myValue\&quot;,    \&quot;anotherKey\&quot;: \&quot;anotherValue\&quot; } &#x60;&#x60;&#x60; .</param>
        /// <param name="Scheduled">Scheduled delivery date time of the message.</param>
        /// <param name="SourceNumber">SourceNumber.</param>
        /// <param name="SourceNumberType">Type of source address specified, this can be INTERNATIONAL, ALPHANUMERIC or SHORTCODE.</param>
        /// <param name="MessageId">Unique ID of this message.</param>
        /// <param name="Status">The status of the message.</param>
        public SubmittedMessage(string CallbackUrl = null, string Content = null, string DestinationNumber = null, bool? DeliveryReport = null, FormatEnum? Format = null, DateTime? MessageExpiryTimestamp = null, Object Metadata = null, DateTime? Scheduled = null, string SourceNumber = null, SourceNumberTypeEnum? SourceNumberType = null, Guid? MessageId = null, StatusEnum? Status = null)
        {
            this.CallbackUrl = CallbackUrl;
            this.Content = Content;
            this.DestinationNumber = DestinationNumber;
            // use default value if no "DeliveryReport" provided
            if (DeliveryReport == null)
            {
                this.DeliveryReport = false;
            }
            else
            {
                this.DeliveryReport = DeliveryReport;
            }
            this.Format = Format;
            this.MessageExpiryTimestamp = MessageExpiryTimestamp;
            this.Metadata = Metadata;
            this.Scheduled = Scheduled;
            this.SourceNumber = SourceNumber;
            this.SourceNumberType = SourceNumberType;
            this.MessageId = MessageId;
            this.Status = Status;
        }
        
        /// <summary>
        /// URL replies and delivery reports to this message will be pushed to
        /// </summary>
        /// <value>URL replies and delivery reports to this message will be pushed to</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }
        /// <summary>
        /// Content of the message
        /// </summary>
        /// <value>Content of the message</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
        /// <summary>
        /// Destination number of the message
        /// </summary>
        /// <value>Destination number of the message</value>
        [DataMember(Name="destination_number", EmitDefaultValue=false)]
        public string DestinationNumber { get; set; }
        /// <summary>
        /// Request a delivery report for this message
        /// </summary>
        /// <value>Request a delivery report for this message</value>
        [DataMember(Name="delivery_report", EmitDefaultValue=false)]
        public bool? DeliveryReport { get; set; }
        /// <summary>
        /// Date time after which the message expires and will not be sent
        /// </summary>
        /// <value>Date time after which the message expires and will not be sent</value>
        [DataMember(Name="message_expiry_timestamp", EmitDefaultValue=false)]
        public DateTime? MessageExpiryTimestamp { get; set; }
        /// <summary>
        /// Metadata for the message specified as a set of key value pairs, each key can be up to 100 characters long and each value can be up to 256 characters long &#x60;&#x60;&#x60; {    \&quot;myKey\&quot;: \&quot;myValue\&quot;,    \&quot;anotherKey\&quot;: \&quot;anotherValue\&quot; } &#x60;&#x60;&#x60; 
        /// </summary>
        /// <value>Metadata for the message specified as a set of key value pairs, each key can be up to 100 characters long and each value can be up to 256 characters long &#x60;&#x60;&#x60; {    \&quot;myKey\&quot;: \&quot;myValue\&quot;,    \&quot;anotherKey\&quot;: \&quot;anotherValue\&quot; } &#x60;&#x60;&#x60; </value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }
        /// <summary>
        /// Scheduled delivery date time of the message
        /// </summary>
        /// <value>Scheduled delivery date time of the message</value>
        [DataMember(Name="scheduled", EmitDefaultValue=false)]
        public DateTime? Scheduled { get; set; }
        /// <summary>
        /// Gets or Sets SourceNumber
        /// </summary>
        [DataMember(Name="source_number", EmitDefaultValue=false)]
        public string SourceNumber { get; set; }
        /// <summary>
        /// Unique ID of this message
        /// </summary>
        /// <value>Unique ID of this message</value>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public Guid? MessageId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmittedMessage {\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  DestinationNumber: ").Append(DestinationNumber).Append("\n");
            sb.Append("  DeliveryReport: ").Append(DeliveryReport).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  MessageExpiryTimestamp: ").Append(MessageExpiryTimestamp).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Scheduled: ").Append(Scheduled).Append("\n");
            sb.Append("  SourceNumber: ").Append(SourceNumber).Append("\n");
            sb.Append("  SourceNumberType: ").Append(SourceNumberType).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SubmittedMessage);
        }

        /// <summary>
        /// Returns true if SubmittedMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of SubmittedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmittedMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CallbackUrl == other.CallbackUrl ||
                    this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(other.CallbackUrl)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.DestinationNumber == other.DestinationNumber ||
                    this.DestinationNumber != null &&
                    this.DestinationNumber.Equals(other.DestinationNumber)
                ) && 
                (
                    this.DeliveryReport == other.DeliveryReport ||
                    this.DeliveryReport != null &&
                    this.DeliveryReport.Equals(other.DeliveryReport)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.MessageExpiryTimestamp == other.MessageExpiryTimestamp ||
                    this.MessageExpiryTimestamp != null &&
                    this.MessageExpiryTimestamp.Equals(other.MessageExpiryTimestamp)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.Scheduled == other.Scheduled ||
                    this.Scheduled != null &&
                    this.Scheduled.Equals(other.Scheduled)
                ) && 
                (
                    this.SourceNumber == other.SourceNumber ||
                    this.SourceNumber != null &&
                    this.SourceNumber.Equals(other.SourceNumber)
                ) && 
                (
                    this.SourceNumberType == other.SourceNumberType ||
                    this.SourceNumberType != null &&
                    this.SourceNumberType.Equals(other.SourceNumberType)
                ) && 
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CallbackUrl != null)
                    hash = hash * 59 + this.CallbackUrl.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.DestinationNumber != null)
                    hash = hash * 59 + this.DestinationNumber.GetHashCode();
                if (this.DeliveryReport != null)
                    hash = hash * 59 + this.DeliveryReport.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.MessageExpiryTimestamp != null)
                    hash = hash * 59 + this.MessageExpiryTimestamp.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.Scheduled != null)
                    hash = hash * 59 + this.Scheduled.GetHashCode();
                if (this.SourceNumber != null)
                    hash = hash * 59 + this.SourceNumber.GetHashCode();
                if (this.SourceNumberType != null)
                    hash = hash * 59 + this.SourceNumberType.GetHashCode();
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }
    }

}

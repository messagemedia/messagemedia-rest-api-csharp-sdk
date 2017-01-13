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
    /// SentMessage
    /// </summary>
    [DataContract]
    public partial class SentMessage :  IEquatable<SentMessage>
    {
        /// <summary>
        /// Format of message, SMS or TTS (Text To Speech)
        /// </summary>
        /// <value>Format of message, SMS or TTS (Text To Speech)</value>
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
        /// Format of message, SMS or TTS (Text To Speech)
        /// </summary>
        /// <value>Format of message, SMS or TTS (Text To Speech)</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SentMessage" /> class.
        /// </summary>
        /// <param name="Account">Account associated with this message.</param>
        /// <param name="Content">Content of the message.</param>
        /// <param name="DeliveredTimestamp">If a delivery report was requested for this message, this is the time at which the message was delivered (or failed to be delivered) to the destination address..</param>
        /// <param name="DeliveryReport">Indicates if a delivery report was requested for this message.</param>
        /// <param name="DestinationAddress">Address this message was delivered to.</param>
        /// <param name="DestinationAddressCountry">Country associated with the destination address.</param>
        /// <param name="Format">Format of message, SMS or TTS (Text To Speech).</param>
        /// <param name="Id">Unique ID for this message.</param>
        /// <param name="InResponseTo">If this message was sent in response to a received message (an auto response message for example) this is the ID of the received message..</param>
        /// <param name="Metadata">Metadata associated with this message.</param>
        /// <param name="SourceAddress">Address this message was sent from.</param>
        /// <param name="SourceAddressCountry">Country associated with the source address.</param>
        /// <param name="Timestamp">Date time at which this message was submitted to the API, refer to the delivered timestamp for the time at which the message was delivered (or failed to be delivered) to the destination address..</param>
        public SentMessage(string Account = null, string Content = null, DateTime? DeliveredTimestamp = null, bool? DeliveryReport = null, string DestinationAddress = null, string DestinationAddressCountry = null, FormatEnum? Format = null, Guid? Id = null, Guid? InResponseTo = null, Object Metadata = null, string SourceAddress = null, string SourceAddressCountry = null, DateTime? Timestamp = null)
        {
            this.Account = Account;
            this.Content = Content;
            this.DeliveredTimestamp = DeliveredTimestamp;
            this.DeliveryReport = DeliveryReport;
            this.DestinationAddress = DestinationAddress;
            this.DestinationAddressCountry = DestinationAddressCountry;
            this.Format = Format;
            this.Id = Id;
            this.InResponseTo = InResponseTo;
            this.Metadata = Metadata;
            this.SourceAddress = SourceAddress;
            this.SourceAddressCountry = SourceAddressCountry;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// Account associated with this message
        /// </summary>
        /// <value>Account associated with this message</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }
        /// <summary>
        /// Content of the message
        /// </summary>
        /// <value>Content of the message</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
        /// <summary>
        /// If a delivery report was requested for this message, this is the time at which the message was delivered (or failed to be delivered) to the destination address.
        /// </summary>
        /// <value>If a delivery report was requested for this message, this is the time at which the message was delivered (or failed to be delivered) to the destination address.</value>
        [DataMember(Name="delivered_timestamp", EmitDefaultValue=false)]
        public DateTime? DeliveredTimestamp { get; set; }
        /// <summary>
        /// Indicates if a delivery report was requested for this message
        /// </summary>
        /// <value>Indicates if a delivery report was requested for this message</value>
        [DataMember(Name="delivery_report", EmitDefaultValue=false)]
        public bool? DeliveryReport { get; set; }
        /// <summary>
        /// Address this message was delivered to
        /// </summary>
        /// <value>Address this message was delivered to</value>
        [DataMember(Name="destination_address", EmitDefaultValue=false)]
        public string DestinationAddress { get; set; }
        /// <summary>
        /// Country associated with the destination address
        /// </summary>
        /// <value>Country associated with the destination address</value>
        [DataMember(Name="destination_address_country", EmitDefaultValue=false)]
        public string DestinationAddressCountry { get; set; }
        /// <summary>
        /// Unique ID for this message
        /// </summary>
        /// <value>Unique ID for this message</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// If this message was sent in response to a received message (an auto response message for example) this is the ID of the received message.
        /// </summary>
        /// <value>If this message was sent in response to a received message (an auto response message for example) this is the ID of the received message.</value>
        [DataMember(Name="in_response_to", EmitDefaultValue=false)]
        public Guid? InResponseTo { get; set; }
        /// <summary>
        /// Metadata associated with this message
        /// </summary>
        /// <value>Metadata associated with this message</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }
        /// <summary>
        /// Address this message was sent from
        /// </summary>
        /// <value>Address this message was sent from</value>
        [DataMember(Name="source_address", EmitDefaultValue=false)]
        public string SourceAddress { get; set; }
        /// <summary>
        /// Country associated with the source address
        /// </summary>
        /// <value>Country associated with the source address</value>
        [DataMember(Name="source_address_country", EmitDefaultValue=false)]
        public string SourceAddressCountry { get; set; }
        /// <summary>
        /// Date time at which this message was submitted to the API, refer to the delivered timestamp for the time at which the message was delivered (or failed to be delivered) to the destination address.
        /// </summary>
        /// <value>Date time at which this message was submitted to the API, refer to the delivered timestamp for the time at which the message was delivered (or failed to be delivered) to the destination address.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SentMessage {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  DeliveredTimestamp: ").Append(DeliveredTimestamp).Append("\n");
            sb.Append("  DeliveryReport: ").Append(DeliveryReport).Append("\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("  DestinationAddressCountry: ").Append(DestinationAddressCountry).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InResponseTo: ").Append(InResponseTo).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SourceAddress: ").Append(SourceAddress).Append("\n");
            sb.Append("  SourceAddressCountry: ").Append(SourceAddressCountry).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(obj as SentMessage);
        }

        /// <summary>
        /// Returns true if SentMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of SentMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.DeliveredTimestamp == other.DeliveredTimestamp ||
                    this.DeliveredTimestamp != null &&
                    this.DeliveredTimestamp.Equals(other.DeliveredTimestamp)
                ) && 
                (
                    this.DeliveryReport == other.DeliveryReport ||
                    this.DeliveryReport != null &&
                    this.DeliveryReport.Equals(other.DeliveryReport)
                ) && 
                (
                    this.DestinationAddress == other.DestinationAddress ||
                    this.DestinationAddress != null &&
                    this.DestinationAddress.Equals(other.DestinationAddress)
                ) && 
                (
                    this.DestinationAddressCountry == other.DestinationAddressCountry ||
                    this.DestinationAddressCountry != null &&
                    this.DestinationAddressCountry.Equals(other.DestinationAddressCountry)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InResponseTo == other.InResponseTo ||
                    this.InResponseTo != null &&
                    this.InResponseTo.Equals(other.InResponseTo)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.SourceAddress == other.SourceAddress ||
                    this.SourceAddress != null &&
                    this.SourceAddress.Equals(other.SourceAddress)
                ) && 
                (
                    this.SourceAddressCountry == other.SourceAddressCountry ||
                    this.SourceAddressCountry != null &&
                    this.SourceAddressCountry.Equals(other.SourceAddressCountry)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.DeliveredTimestamp != null)
                    hash = hash * 59 + this.DeliveredTimestamp.GetHashCode();
                if (this.DeliveryReport != null)
                    hash = hash * 59 + this.DeliveryReport.GetHashCode();
                if (this.DestinationAddress != null)
                    hash = hash * 59 + this.DestinationAddress.GetHashCode();
                if (this.DestinationAddressCountry != null)
                    hash = hash * 59 + this.DestinationAddressCountry.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InResponseTo != null)
                    hash = hash * 59 + this.InResponseTo.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.SourceAddress != null)
                    hash = hash * 59 + this.SourceAddress.GetHashCode();
                if (this.SourceAddressCountry != null)
                    hash = hash * 59 + this.SourceAddressCountry.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                return hash;
            }
        }
    }

}

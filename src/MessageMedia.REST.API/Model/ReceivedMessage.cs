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
    /// A message received for the account specified. This message may be in response to a sent message, or it may be an unsolicited message, matched to the account by the destination address.
    /// </summary>
    [DataContract]
    public partial class ReceivedMessage :  IEquatable<ReceivedMessage>
    {
        /// <summary>
        /// Action that was invoked for this message if any, OPTOUT, OPTIN, GLOBALOPTOUT
        /// </summary>
        /// <value>Action that was invoked for this message if any, OPTOUT, OPTIN, GLOBALOPTOUT</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum OPTOUT for "OPTOUT"
            /// </summary>
            [EnumMember(Value = "OPTOUT")]
            OPTOUT,
            
            /// <summary>
            /// Enum OPTIN for "OPTIN"
            /// </summary>
            [EnumMember(Value = "OPTIN")]
            OPTIN,
            
            /// <summary>
            /// Enum GLOBALOPTOUT for "GLOBALOPTOUT"
            /// </summary>
            [EnumMember(Value = "GLOBALOPTOUT")]
            GLOBALOPTOUT
        }

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
        /// Action that was invoked for this message if any, OPTOUT, OPTIN, GLOBALOPTOUT
        /// </summary>
        /// <value>Action that was invoked for this message if any, OPTOUT, OPTIN, GLOBALOPTOUT</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Format of message, SMS or TTS (Text To Speech)
        /// </summary>
        /// <value>Format of message, SMS or TTS (Text To Speech)</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivedMessage" /> class.
        /// </summary>
        /// <param name="Account">Account associated with this message.</param>
        /// <param name="Action">Action that was invoked for this message if any, OPTOUT, OPTIN, GLOBALOPTOUT.</param>
        /// <param name="Content">Content of the message.</param>
        /// <param name="DestinationAddress">Address this message was delivered to. If this message was received in response to a sent message, this is the source address of the sent message.</param>
        /// <param name="DestinationAddressCountry">Country associated with the destination address.</param>
        /// <param name="Format">Format of message, SMS or TTS (Text To Speech).</param>
        /// <param name="Id">Unique ID for this reply.</param>
        /// <param name="InResponseTo">If this message was received in response to a sent message, this is the ID of the sent message.</param>
        /// <param name="Metadata">If this message was received in response to a sent message, this is the metadata associated with the sent message.</param>
        /// <param name="SourceAddress">Address this message was received from. If this message was received in response to a sent message, this is the destination address of the sent message..</param>
        /// <param name="SourceAddressCountry">Country associated with the source address.</param>
        /// <param name="Timestamp">Date time at which this message was received.</param>
        public ReceivedMessage(string Account = null, ActionEnum? Action = null, string Content = null, string DestinationAddress = null, string DestinationAddressCountry = null, FormatEnum? Format = null, Guid? Id = null, Guid? InResponseTo = null, Object Metadata = null, string SourceAddress = null, string SourceAddressCountry = null, DateTime? Timestamp = null)
        {
            this.Account = Account;
            this.Action = Action;
            this.Content = Content;
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
        /// Address this message was delivered to. If this message was received in response to a sent message, this is the source address of the sent message
        /// </summary>
        /// <value>Address this message was delivered to. If this message was received in response to a sent message, this is the source address of the sent message</value>
        [DataMember(Name="destination_address", EmitDefaultValue=false)]
        public string DestinationAddress { get; set; }
        /// <summary>
        /// Country associated with the destination address
        /// </summary>
        /// <value>Country associated with the destination address</value>
        [DataMember(Name="destination_address_country", EmitDefaultValue=false)]
        public string DestinationAddressCountry { get; set; }
        /// <summary>
        /// Unique ID for this reply
        /// </summary>
        /// <value>Unique ID for this reply</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// If this message was received in response to a sent message, this is the ID of the sent message
        /// </summary>
        /// <value>If this message was received in response to a sent message, this is the ID of the sent message</value>
        [DataMember(Name="in_response_to", EmitDefaultValue=false)]
        public Guid? InResponseTo { get; set; }
        /// <summary>
        /// If this message was received in response to a sent message, this is the metadata associated with the sent message
        /// </summary>
        /// <value>If this message was received in response to a sent message, this is the metadata associated with the sent message</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }
        /// <summary>
        /// Address this message was received from. If this message was received in response to a sent message, this is the destination address of the sent message.
        /// </summary>
        /// <value>Address this message was received from. If this message was received in response to a sent message, this is the destination address of the sent message.</value>
        [DataMember(Name="source_address", EmitDefaultValue=false)]
        public string SourceAddress { get; set; }
        /// <summary>
        /// Country associated with the source address
        /// </summary>
        /// <value>Country associated with the source address</value>
        [DataMember(Name="source_address_country", EmitDefaultValue=false)]
        public string SourceAddressCountry { get; set; }
        /// <summary>
        /// Date time at which this message was received
        /// </summary>
        /// <value>Date time at which this message was received</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReceivedMessage {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(obj as ReceivedMessage);
        }

        /// <summary>
        /// Returns true if ReceivedMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of ReceivedMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivedMessage other)
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
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
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

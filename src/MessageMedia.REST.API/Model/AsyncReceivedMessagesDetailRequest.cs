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
    /// AsyncReceivedMessagesDetailRequest
    /// </summary>
    [DataContract]
    public partial class AsyncReceivedMessagesDetailRequest :  IEquatable<AsyncReceivedMessagesDetailRequest>
    {
        /// <summary>
        /// Field to sort results set by
        /// </summary>
        /// <value>Field to sort results set by</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortByEnum
        {
            
            /// <summary>
            /// Enum ACCOUNT for "ACCOUNT"
            /// </summary>
            [EnumMember(Value = "ACCOUNT")]
            ACCOUNT,
            
            /// <summary>
            /// Enum ACTION for "ACTION"
            /// </summary>
            [EnumMember(Value = "ACTION")]
            ACTION,
            
            /// <summary>
            /// Enum DESTINATIONADDRESS for "DESTINATION_ADDRESS"
            /// </summary>
            [EnumMember(Value = "DESTINATION_ADDRESS")]
            DESTINATIONADDRESS,
            
            /// <summary>
            /// Enum DESTINATIONADDRESSCOUNTRY for "DESTINATION_ADDRESS_COUNTRY"
            /// </summary>
            [EnumMember(Value = "DESTINATION_ADDRESS_COUNTRY")]
            DESTINATIONADDRESSCOUNTRY,
            
            /// <summary>
            /// Enum FORMAT for "FORMAT"
            /// </summary>
            [EnumMember(Value = "FORMAT")]
            FORMAT,
            
            /// <summary>
            /// Enum SOURCEADDRESS for "SOURCE_ADDRESS"
            /// </summary>
            [EnumMember(Value = "SOURCE_ADDRESS")]
            SOURCEADDRESS,
            
            /// <summary>
            /// Enum SOURCEADDRESSCOUNTRY for "SOURCE_ADDRESS_COUNTRY"
            /// </summary>
            [EnumMember(Value = "SOURCE_ADDRESS_COUNTRY")]
            SOURCEADDRESSCOUNTRY,
            
            /// <summary>
            /// Enum TIMESTAMP for "TIMESTAMP"
            /// </summary>
            [EnumMember(Value = "TIMESTAMP")]
            TIMESTAMP
        }

        /// <summary>
        /// Field to sort results set by
        /// </summary>
        /// <value>Field to sort results set by</value>
        [DataMember(Name="sort_by", EmitDefaultValue=false)]
        public SortByEnum? SortBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncReceivedMessagesDetailRequest" /> class.
        /// </summary>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="SortBy">Field to sort results set by.</param>
        /// <param name="SortDirection">SortDirection.</param>
        /// <param name="Timezone">Timezone.</param>
        /// <param name="Accounts">Accounts.</param>
        /// <param name="DestinationAddressCountry">DestinationAddressCountry.</param>
        /// <param name="DestinationAddress">DestinationAddress.</param>
        /// <param name="MessageFormat">MessageFormat.</param>
        /// <param name="MetadataKey">MetadataKey.</param>
        /// <param name="MetadataValue">MetadataValue.</param>
        /// <param name="SourceAddressCountry">SourceAddressCountry.</param>
        /// <param name="SourceAddress">SourceAddress.</param>
        /// <param name="Action">Action.</param>
        public AsyncReceivedMessagesDetailRequest(StartDateBody StartDate = null, EndDateBody EndDate = null, SortByEnum? SortBy = null, SortDirectionBody SortDirection = null, TimezoneBody Timezone = null, AccountsBody Accounts = null, DestinationAddressCountryBody DestinationAddressCountry = null, DestinationAddressBody DestinationAddress = null, MessageFormatBody MessageFormat = null, MetadataKeyBody MetadataKey = null, MetadataValueBody MetadataValue = null, SourceAddressCountryBody SourceAddressCountry = null, SourceAddressBody SourceAddress = null, ActionBody Action = null)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.SortBy = SortBy;
            this.SortDirection = SortDirection;
            this.Timezone = Timezone;
            this.Accounts = Accounts;
            this.DestinationAddressCountry = DestinationAddressCountry;
            this.DestinationAddress = DestinationAddress;
            this.MessageFormat = MessageFormat;
            this.MetadataKey = MetadataKey;
            this.MetadataValue = MetadataValue;
            this.SourceAddressCountry = SourceAddressCountry;
            this.SourceAddress = SourceAddress;
            this.Action = Action;
        }
        
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public StartDateBody StartDate { get; set; }
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public EndDateBody EndDate { get; set; }
        /// <summary>
        /// Gets or Sets SortDirection
        /// </summary>
        [DataMember(Name="sort_direction", EmitDefaultValue=false)]
        public SortDirectionBody SortDirection { get; set; }
        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public TimezoneBody Timezone { get; set; }
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public AccountsBody Accounts { get; set; }
        /// <summary>
        /// Gets or Sets DestinationAddressCountry
        /// </summary>
        [DataMember(Name="destination_address_country", EmitDefaultValue=false)]
        public DestinationAddressCountryBody DestinationAddressCountry { get; set; }
        /// <summary>
        /// Gets or Sets DestinationAddress
        /// </summary>
        [DataMember(Name="destination_address", EmitDefaultValue=false)]
        public DestinationAddressBody DestinationAddress { get; set; }
        /// <summary>
        /// Gets or Sets MessageFormat
        /// </summary>
        [DataMember(Name="message_format", EmitDefaultValue=false)]
        public MessageFormatBody MessageFormat { get; set; }
        /// <summary>
        /// Gets or Sets MetadataKey
        /// </summary>
        [DataMember(Name="metadata_key", EmitDefaultValue=false)]
        public MetadataKeyBody MetadataKey { get; set; }
        /// <summary>
        /// Gets or Sets MetadataValue
        /// </summary>
        [DataMember(Name="metadata_value", EmitDefaultValue=false)]
        public MetadataValueBody MetadataValue { get; set; }
        /// <summary>
        /// Gets or Sets SourceAddressCountry
        /// </summary>
        [DataMember(Name="source_address_country", EmitDefaultValue=false)]
        public SourceAddressCountryBody SourceAddressCountry { get; set; }
        /// <summary>
        /// Gets or Sets SourceAddress
        /// </summary>
        [DataMember(Name="source_address", EmitDefaultValue=false)]
        public SourceAddressBody SourceAddress { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionBody Action { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncReceivedMessagesDetailRequest {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  DestinationAddressCountry: ").Append(DestinationAddressCountry).Append("\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("  MessageFormat: ").Append(MessageFormat).Append("\n");
            sb.Append("  MetadataKey: ").Append(MetadataKey).Append("\n");
            sb.Append("  MetadataValue: ").Append(MetadataValue).Append("\n");
            sb.Append("  SourceAddressCountry: ").Append(SourceAddressCountry).Append("\n");
            sb.Append("  SourceAddress: ").Append(SourceAddress).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(obj as AsyncReceivedMessagesDetailRequest);
        }

        /// <summary>
        /// Returns true if AsyncReceivedMessagesDetailRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncReceivedMessagesDetailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncReceivedMessagesDetailRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.SortBy == other.SortBy ||
                    this.SortBy != null &&
                    this.SortBy.Equals(other.SortBy)
                ) && 
                (
                    this.SortDirection == other.SortDirection ||
                    this.SortDirection != null &&
                    this.SortDirection.Equals(other.SortDirection)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.Accounts == other.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.Equals(other.Accounts)
                ) && 
                (
                    this.DestinationAddressCountry == other.DestinationAddressCountry ||
                    this.DestinationAddressCountry != null &&
                    this.DestinationAddressCountry.Equals(other.DestinationAddressCountry)
                ) && 
                (
                    this.DestinationAddress == other.DestinationAddress ||
                    this.DestinationAddress != null &&
                    this.DestinationAddress.Equals(other.DestinationAddress)
                ) && 
                (
                    this.MessageFormat == other.MessageFormat ||
                    this.MessageFormat != null &&
                    this.MessageFormat.Equals(other.MessageFormat)
                ) && 
                (
                    this.MetadataKey == other.MetadataKey ||
                    this.MetadataKey != null &&
                    this.MetadataKey.Equals(other.MetadataKey)
                ) && 
                (
                    this.MetadataValue == other.MetadataValue ||
                    this.MetadataValue != null &&
                    this.MetadataValue.Equals(other.MetadataValue)
                ) && 
                (
                    this.SourceAddressCountry == other.SourceAddressCountry ||
                    this.SourceAddressCountry != null &&
                    this.SourceAddressCountry.Equals(other.SourceAddressCountry)
                ) && 
                (
                    this.SourceAddress == other.SourceAddress ||
                    this.SourceAddress != null &&
                    this.SourceAddress.Equals(other.SourceAddress)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
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
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.SortBy != null)
                    hash = hash * 59 + this.SortBy.GetHashCode();
                if (this.SortDirection != null)
                    hash = hash * 59 + this.SortDirection.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.Accounts != null)
                    hash = hash * 59 + this.Accounts.GetHashCode();
                if (this.DestinationAddressCountry != null)
                    hash = hash * 59 + this.DestinationAddressCountry.GetHashCode();
                if (this.DestinationAddress != null)
                    hash = hash * 59 + this.DestinationAddress.GetHashCode();
                if (this.MessageFormat != null)
                    hash = hash * 59 + this.MessageFormat.GetHashCode();
                if (this.MetadataKey != null)
                    hash = hash * 59 + this.MetadataKey.GetHashCode();
                if (this.MetadataValue != null)
                    hash = hash * 59 + this.MetadataValue.GetHashCode();
                if (this.SourceAddressCountry != null)
                    hash = hash * 59 + this.SourceAddressCountry.GetHashCode();
                if (this.SourceAddress != null)
                    hash = hash * 59 + this.SourceAddress.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                return hash;
            }
        }
    }

}

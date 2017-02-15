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
    /// ReportingDetailPropertiesFilters
    /// </summary>
    [DataContract]
    public partial class ReportingDetailPropertiesFilters :  IEquatable<ReportingDetailPropertiesFilters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingDetailPropertiesFilters" /> class.
        /// </summary>
        /// <param name="DeliveryReport">DeliveryReport.</param>
        /// <param name="DestinationAddressCountry">DestinationAddressCountry.</param>
        /// <param name="DestinationAddress">DestinationAddress.</param>
        /// <param name="MessageFormat">MessageFormat.</param>
        /// <param name="MetadataKey">MetadataKey.</param>
        /// <param name="MetadataValue">MetadataValue.</param>
        /// <param name="SourceAddressCountry">SourceAddressCountry.</param>
        /// <param name="SourceAddress">SourceAddress.</param>
        /// <param name="StatusCode">StatusCode.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Action">Action.</param>
        public ReportingDetailPropertiesFilters(string DeliveryReport = null, string DestinationAddressCountry = null, string DestinationAddress = null, string MessageFormat = null, string MetadataKey = null, string MetadataValue = null, string SourceAddressCountry = null, string SourceAddress = null, string StatusCode = null, string Status = null, string Action = null)
        {
            this.DeliveryReport = DeliveryReport;
            this.DestinationAddressCountry = DestinationAddressCountry;
            this.DestinationAddress = DestinationAddress;
            this.MessageFormat = MessageFormat;
            this.MetadataKey = MetadataKey;
            this.MetadataValue = MetadataValue;
            this.SourceAddressCountry = SourceAddressCountry;
            this.SourceAddress = SourceAddress;
            this.StatusCode = StatusCode;
            this.Status = Status;
            this.Action = Action;
        }
        
        /// <summary>
        /// Gets or Sets DeliveryReport
        /// </summary>
        [DataMember(Name="delivery_report", EmitDefaultValue=false)]
        public string DeliveryReport { get; set; }
        /// <summary>
        /// Gets or Sets DestinationAddressCountry
        /// </summary>
        [DataMember(Name="destination_address_country", EmitDefaultValue=false)]
        public string DestinationAddressCountry { get; set; }
        /// <summary>
        /// Gets or Sets DestinationAddress
        /// </summary>
        [DataMember(Name="destination_address", EmitDefaultValue=false)]
        public string DestinationAddress { get; set; }
        /// <summary>
        /// Gets or Sets MessageFormat
        /// </summary>
        [DataMember(Name="message_format", EmitDefaultValue=false)]
        public string MessageFormat { get; set; }
        /// <summary>
        /// Gets or Sets MetadataKey
        /// </summary>
        [DataMember(Name="metadata_key", EmitDefaultValue=false)]
        public string MetadataKey { get; set; }
        /// <summary>
        /// Gets or Sets MetadataValue
        /// </summary>
        [DataMember(Name="metadata_value", EmitDefaultValue=false)]
        public string MetadataValue { get; set; }
        /// <summary>
        /// Gets or Sets SourceAddressCountry
        /// </summary>
        [DataMember(Name="source_address_country", EmitDefaultValue=false)]
        public string SourceAddressCountry { get; set; }
        /// <summary>
        /// Gets or Sets SourceAddress
        /// </summary>
        [DataMember(Name="source_address", EmitDefaultValue=false)]
        public string SourceAddress { get; set; }
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="status_code", EmitDefaultValue=false)]
        public string StatusCode { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingDetailPropertiesFilters {\n");
            sb.Append("  DeliveryReport: ").Append(DeliveryReport).Append("\n");
            sb.Append("  DestinationAddressCountry: ").Append(DestinationAddressCountry).Append("\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("  MessageFormat: ").Append(MessageFormat).Append("\n");
            sb.Append("  MetadataKey: ").Append(MetadataKey).Append("\n");
            sb.Append("  MetadataValue: ").Append(MetadataValue).Append("\n");
            sb.Append("  SourceAddressCountry: ").Append(SourceAddressCountry).Append("\n");
            sb.Append("  SourceAddress: ").Append(SourceAddress).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as ReportingDetailPropertiesFilters);
        }

        /// <summary>
        /// Returns true if ReportingDetailPropertiesFilters instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingDetailPropertiesFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingDetailPropertiesFilters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryReport == other.DeliveryReport ||
                    this.DeliveryReport != null &&
                    this.DeliveryReport.Equals(other.DeliveryReport)
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
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.DeliveryReport != null)
                    hash = hash * 59 + this.DeliveryReport.GetHashCode();
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
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                return hash;
            }
        }
    }

}

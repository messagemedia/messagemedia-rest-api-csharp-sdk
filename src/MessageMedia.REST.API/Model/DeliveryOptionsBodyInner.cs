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
    /// A delivery option
    /// </summary>
    [DataContract]
    public partial class DeliveryOptionsBodyInner :  IEquatable<DeliveryOptionsBodyInner>
    {
        /// <summary>
        /// How to deliver the report.
        /// </summary>
        /// <value>How to deliver the report.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryTypeEnum
        {
            
            /// <summary>
            /// Enum EMAIL for "EMAIL"
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            EMAIL
        }

        /// <summary>
        /// Format of the report.
        /// </summary>
        /// <value>Format of the report.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryFormatEnum
        {
            
            /// <summary>
            /// Enum CSV for "CSV"
            /// </summary>
            [EnumMember(Value = "CSV")]
            CSV
        }

        /// <summary>
        /// How to deliver the report.
        /// </summary>
        /// <value>How to deliver the report.</value>
        [DataMember(Name="delivery_type", EmitDefaultValue=false)]
        public DeliveryTypeEnum? DeliveryType { get; set; }
        /// <summary>
        /// Format of the report.
        /// </summary>
        /// <value>Format of the report.</value>
        [DataMember(Name="delivery_format", EmitDefaultValue=false)]
        public DeliveryFormatEnum? DeliveryFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryOptionsBodyInner" /> class.
        /// </summary>
        /// <param name="DeliveryType">How to deliver the report..</param>
        /// <param name="DeliveryAddresses">A list of email addresses to use as the recipient of the email. Only works for EMAIL delivery type.</param>
        /// <param name="DeliveryFormat">Format of the report..</param>
        public DeliveryOptionsBodyInner(DeliveryTypeEnum? DeliveryType = null, List<string> DeliveryAddresses = null, DeliveryFormatEnum? DeliveryFormat = null)
        {
            this.DeliveryType = DeliveryType;
            this.DeliveryAddresses = DeliveryAddresses;
            this.DeliveryFormat = DeliveryFormat;
        }
        
        /// <summary>
        /// A list of email addresses to use as the recipient of the email. Only works for EMAIL delivery type
        /// </summary>
        /// <value>A list of email addresses to use as the recipient of the email. Only works for EMAIL delivery type</value>
        [DataMember(Name="delivery_addresses", EmitDefaultValue=false)]
        public List<string> DeliveryAddresses { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeliveryOptionsBodyInner {\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  DeliveryAddresses: ").Append(DeliveryAddresses).Append("\n");
            sb.Append("  DeliveryFormat: ").Append(DeliveryFormat).Append("\n");
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
            return this.Equals(obj as DeliveryOptionsBodyInner);
        }

        /// <summary>
        /// Returns true if DeliveryOptionsBodyInner instances are equal
        /// </summary>
        /// <param name="other">Instance of DeliveryOptionsBodyInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryOptionsBodyInner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryType == other.DeliveryType ||
                    this.DeliveryType != null &&
                    this.DeliveryType.Equals(other.DeliveryType)
                ) && 
                (
                    this.DeliveryAddresses == other.DeliveryAddresses ||
                    this.DeliveryAddresses != null &&
                    this.DeliveryAddresses.SequenceEqual(other.DeliveryAddresses)
                ) && 
                (
                    this.DeliveryFormat == other.DeliveryFormat ||
                    this.DeliveryFormat != null &&
                    this.DeliveryFormat.Equals(other.DeliveryFormat)
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
                if (this.DeliveryType != null)
                    hash = hash * 59 + this.DeliveryType.GetHashCode();
                if (this.DeliveryAddresses != null)
                    hash = hash * 59 + this.DeliveryAddresses.GetHashCode();
                if (this.DeliveryFormat != null)
                    hash = hash * 59 + this.DeliveryFormat.GetHashCode();
                return hash;
            }
        }
    }

}

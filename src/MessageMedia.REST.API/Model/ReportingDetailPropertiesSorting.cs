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
    /// ReportingDetailPropertiesSorting
    /// </summary>
    [DataContract]
    public partial class ReportingDetailPropertiesSorting :  IEquatable<ReportingDetailPropertiesSorting>
    {
        /// <summary>
        /// The value of the sort_by field provided for this report
        /// </summary>
        /// <value>The value of the sort_by field provided for this report</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldEnum
        {
            
            /// <summary>
            /// Enum ACCOUNT for "ACCOUNT"
            /// </summary>
            [EnumMember(Value = "ACCOUNT")]
            ACCOUNT,
            
            /// <summary>
            /// Enum DELIVEREDTIMESTAMP for "DELIVERED_TIMESTAMP"
            /// </summary>
            [EnumMember(Value = "DELIVERED_TIMESTAMP")]
            DELIVEREDTIMESTAMP,
            
            /// <summary>
            /// Enum MESSAGEEXPIRYTIMESTAMP for "MESSAGE_EXPIRY_TIMESTAMP"
            /// </summary>
            [EnumMember(Value = "MESSAGE_EXPIRY_TIMESTAMP")]
            MESSAGEEXPIRYTIMESTAMP,
            
            /// <summary>
            /// Enum DELIVERYREPORT for "DELIVERY_REPORT"
            /// </summary>
            [EnumMember(Value = "DELIVERY_REPORT")]
            DELIVERYREPORT,
            
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
            /// Enum STATUS for "STATUS"
            /// </summary>
            [EnumMember(Value = "STATUS")]
            STATUS,
            
            /// <summary>
            /// Enum STATUSCODE for "STATUS_CODE"
            /// </summary>
            [EnumMember(Value = "STATUS_CODE")]
            STATUSCODE,
            
            /// <summary>
            /// Enum UNITS for "UNITS"
            /// </summary>
            [EnumMember(Value = "UNITS")]
            UNITS,
            
            /// <summary>
            /// Enum TIMESTAMP for "TIMESTAMP"
            /// </summary>
            [EnumMember(Value = "TIMESTAMP")]
            TIMESTAMP
        }

        /// <summary>
        /// The value of the sort_direction field provided for this report
        /// </summary>
        /// <value>The value of the sort_direction field provided for this report</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderEnum
        {
            
            /// <summary>
            /// Enum ASCENDING for "ASCENDING"
            /// </summary>
            [EnumMember(Value = "ASCENDING")]
            ASCENDING,
            
            /// <summary>
            /// Enum DESCENDING for "DESCENDING"
            /// </summary>
            [EnumMember(Value = "DESCENDING")]
            DESCENDING
        }

        /// <summary>
        /// The value of the sort_by field provided for this report
        /// </summary>
        /// <value>The value of the sort_by field provided for this report</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public FieldEnum? Field { get; set; }
        /// <summary>
        /// The value of the sort_direction field provided for this report
        /// </summary>
        /// <value>The value of the sort_direction field provided for this report</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public OrderEnum? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingDetailPropertiesSorting" /> class.
        /// </summary>
        /// <param name="Field">The value of the sort_by field provided for this report.</param>
        /// <param name="Order">The value of the sort_direction field provided for this report.</param>
        public ReportingDetailPropertiesSorting(FieldEnum? Field = null, OrderEnum? Order = null)
        {
            this.Field = Field;
            this.Order = Order;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingDetailPropertiesSorting {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(obj as ReportingDetailPropertiesSorting);
        }

        /// <summary>
        /// Returns true if ReportingDetailPropertiesSorting instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingDetailPropertiesSorting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingDetailPropertiesSorting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                return hash;
            }
        }
    }

}

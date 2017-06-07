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
    /// SummaryReportProperties
    /// </summary>
    [DataContract]
    public partial class SummaryReportProperties :  IEquatable<SummaryReportProperties>
    {
        /// <summary>
        /// The value of the group by parameter provided for this report
        /// </summary>
        /// <value>The value of the group by parameter provided for this report</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GroupingEnum
        {
            
            /// <summary>
            /// Enum DAY for "DAY"
            /// </summary>
            [EnumMember(Value = "DAY")]
            DAY,
            
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
            /// Enum HOUR for "HOUR"
            /// </summary>
            [EnumMember(Value = "HOUR")]
            HOUR,
            
            /// <summary>
            /// Enum METADATAKEY for "METADATA_KEY"
            /// </summary>
            [EnumMember(Value = "METADATA_KEY")]
            METADATAKEY,
            
            /// <summary>
            /// Enum METADATAVALUE for "METADATA_VALUE"
            /// </summary>
            [EnumMember(Value = "METADATA_VALUE")]
            METADATAVALUE,
            
            /// <summary>
            /// Enum MINUTE for "MINUTE"
            /// </summary>
            [EnumMember(Value = "MINUTE")]
            MINUTE,
            
            /// <summary>
            /// Enum MONTH for "MONTH"
            /// </summary>
            [EnumMember(Value = "MONTH")]
            MONTH,
            
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
            /// Enum YEAR for "YEAR"
            /// </summary>
            [EnumMember(Value = "YEAR")]
            YEAR,
            
            /// <summary>
            /// Enum ACCOUNT for "ACCOUNT"
            /// </summary>
            [EnumMember(Value = "ACCOUNT")]
            ACCOUNT
        }

        /// <summary>
        /// The value of the summary_by parameter provided for this report
        /// </summary>
        /// <value>The value of the summary_by parameter provided for this report</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SummaryEnum
        {
            
            /// <summary>
            /// Enum COUNT for "COUNT"
            /// </summary>
            [EnumMember(Value = "COUNT")]
            COUNT,
            
            /// <summary>
            /// Enum SUM for "SUM"
            /// </summary>
            [EnumMember(Value = "SUM")]
            SUM
        }

        /// <summary>
        /// The value of the summary_field parameter provided for this report
        /// </summary>
        /// <value>The value of the summary_field parameter provided for this report</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SummaryFieldEnum
        {
            
            /// <summary>
            /// Enum UNITS for "UNITS"
            /// </summary>
            [EnumMember(Value = "UNITS")]
            UNITS,
            
            /// <summary>
            /// Enum MESSAGEID for "MESSAGE_ID"
            /// </summary>
            [EnumMember(Value = "MESSAGE_ID")]
            MESSAGEID
        }

        /// <summary>
        /// The value of the group by parameter provided for this report
        /// </summary>
        /// <value>The value of the group by parameter provided for this report</value>
        [DataMember(Name="grouping", EmitDefaultValue=false)]
        public GroupingEnum? Grouping { get; set; }
        /// <summary>
        /// The value of the summary_by parameter provided for this report
        /// </summary>
        /// <value>The value of the summary_by parameter provided for this report</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public SummaryEnum? Summary { get; set; }
        /// <summary>
        /// The value of the summary_field parameter provided for this report
        /// </summary>
        /// <value>The value of the summary_field parameter provided for this report</value>
        [DataMember(Name="summary_field", EmitDefaultValue=false)]
        public SummaryFieldEnum? SummaryField { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryReportProperties" /> class.
        /// </summary>
        /// <param name="EndDate">The end date provided as a parameter for this report.</param>
        /// <param name="Filters">Any filters provided as parameters for this report.</param>
        /// <param name="Grouping">The value of the group by parameter provided for this report.</param>
        /// <param name="StartDate">The end date provided as a parameter for this report.</param>
        /// <param name="Summary">The value of the summary_by parameter provided for this report.</param>
        /// <param name="SummaryField">The value of the summary_field parameter provided for this report.</param>
        /// <param name="Timezone">Timezone.</param>
        public SummaryReportProperties(DateTime? EndDate = null, Object Filters = null, GroupingEnum? Grouping = null, DateTime? StartDate = null, SummaryEnum? Summary = null, SummaryFieldEnum? SummaryField = null, string Timezone = null)
        {
            this.EndDate = EndDate;
            this.Filters = Filters;
            this.Grouping = Grouping;
            this.StartDate = StartDate;
            this.Summary = Summary;
            this.SummaryField = SummaryField;
            this.Timezone = Timezone;
        }
        
        /// <summary>
        /// The end date provided as a parameter for this report
        /// </summary>
        /// <value>The end date provided as a parameter for this report</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Any filters provided as parameters for this report
        /// </summary>
        /// <value>Any filters provided as parameters for this report</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public Object Filters { get; set; }
        /// <summary>
        /// The end date provided as a parameter for this report
        /// </summary>
        /// <value>The end date provided as a parameter for this report</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryReportProperties {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Grouping: ").Append(Grouping).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  SummaryField: ").Append(SummaryField).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(obj as SummaryReportProperties);
        }

        /// <summary>
        /// Returns true if SummaryReportProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of SummaryReportProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryReportProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.Equals(other.Filters)
                ) && 
                (
                    this.Grouping == other.Grouping ||
                    this.Grouping != null &&
                    this.Grouping.Equals(other.Grouping)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) && 
                (
                    this.SummaryField == other.SummaryField ||
                    this.SummaryField != null &&
                    this.SummaryField.Equals(other.SummaryField)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
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
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                if (this.Grouping != null)
                    hash = hash * 59 + this.Grouping.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();
                if (this.SummaryField != null)
                    hash = hash * 59 + this.SummaryField.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                return hash;
            }
        }
    }

}

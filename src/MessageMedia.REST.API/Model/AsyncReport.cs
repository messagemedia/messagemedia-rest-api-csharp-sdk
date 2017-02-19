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
    /// AsyncReport
    /// </summary>
    [DataContract]
    public partial class AsyncReport :  IEquatable<AsyncReport>
    {
        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageTypeEnum
        {
            
            /// <summary>
            /// Enum SENTMESSAGES for "SENT_MESSAGES"
            /// </summary>
            [EnumMember(Value = "SENT_MESSAGES")]
            SENTMESSAGES,
            
            /// <summary>
            /// Enum RECEIVEDMESSAGES for "RECEIVED_MESSAGES"
            /// </summary>
            [EnumMember(Value = "RECEIVED_MESSAGES")]
            RECEIVEDMESSAGES,
            
            /// <summary>
            /// Enum DELIVERYREPORTS for "DELIVERY_REPORTS"
            /// </summary>
            [EnumMember(Value = "DELIVERY_REPORTS")]
            DELIVERYREPORTS
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum SUMMARY for "SUMMARY"
            /// </summary>
            [EnumMember(Value = "SUMMARY")]
            SUMMARY,
            
            /// <summary>
            /// Enum DETAIL for "DETAIL"
            /// </summary>
            [EnumMember(Value = "DETAIL")]
            DETAIL
        }

        /// <summary>
        /// Gets or Sets ReportStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportStatusEnum
        {
            
            /// <summary>
            /// Enum REQUESTED for "REQUESTED"
            /// </summary>
            [EnumMember(Value = "REQUESTED")]
            REQUESTED,
            
            /// <summary>
            /// Enum RUNNING for "RUNNING"
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING,
            
            /// <summary>
            /// Enum CANCELLED for "CANCELLED"
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED,
            
            /// <summary>
            /// Enum DONE for "DONE"
            /// </summary>
            [EnumMember(Value = "DONE")]
            DONE
        }

        /// <summary>
        /// Gets or Sets MessageType
        /// </summary>
        [DataMember(Name="message_type", EmitDefaultValue=false)]
        public MessageTypeEnum? MessageType { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets ReportStatus
        /// </summary>
        [DataMember(Name="report_status", EmitDefaultValue=false)]
        public ReportStatusEnum? ReportStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncReport" /> class.
        /// </summary>
        /// <param name="Id">Unique ID for this reply.</param>
        /// <param name="MessageType">MessageType.</param>
        /// <param name="Type">Type.</param>
        /// <param name="ReportStatus">ReportStatus.</param>
        /// <param name="CreatedDatetime">Date time at which this report was created..</param>
        /// <param name="LastModifiedDatetime">Date time at which this report was last modified..</param>
        public AsyncReport(Guid? Id = null, MessageTypeEnum? MessageType = null, TypeEnum? Type = null, ReportStatusEnum? ReportStatus = null, DateTime? CreatedDatetime = null, DateTime? LastModifiedDatetime = null)
        {
            this.Id = Id;
            this.MessageType = MessageType;
            this.Type = Type;
            this.ReportStatus = ReportStatus;
            this.CreatedDatetime = CreatedDatetime;
            this.LastModifiedDatetime = LastModifiedDatetime;
        }
        
        /// <summary>
        /// Unique ID for this reply
        /// </summary>
        /// <value>Unique ID for this reply</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Date time at which this report was created.
        /// </summary>
        /// <value>Date time at which this report was created.</value>
        [DataMember(Name="created_datetime", EmitDefaultValue=false)]
        public DateTime? CreatedDatetime { get; set; }
        /// <summary>
        /// Date time at which this report was last modified.
        /// </summary>
        /// <value>Date time at which this report was last modified.</value>
        [DataMember(Name="last_modified_datetime", EmitDefaultValue=false)]
        public DateTime? LastModifiedDatetime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncReport {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReportStatus: ").Append(ReportStatus).Append("\n");
            sb.Append("  CreatedDatetime: ").Append(CreatedDatetime).Append("\n");
            sb.Append("  LastModifiedDatetime: ").Append(LastModifiedDatetime).Append("\n");
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
            return this.Equals(obj as AsyncReport);
        }

        /// <summary>
        /// Returns true if AsyncReport instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ReportStatus == other.ReportStatus ||
                    this.ReportStatus != null &&
                    this.ReportStatus.Equals(other.ReportStatus)
                ) && 
                (
                    this.CreatedDatetime == other.CreatedDatetime ||
                    this.CreatedDatetime != null &&
                    this.CreatedDatetime.Equals(other.CreatedDatetime)
                ) && 
                (
                    this.LastModifiedDatetime == other.LastModifiedDatetime ||
                    this.LastModifiedDatetime != null &&
                    this.LastModifiedDatetime.Equals(other.LastModifiedDatetime)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.ReportStatus != null)
                    hash = hash * 59 + this.ReportStatus.GetHashCode();
                if (this.CreatedDatetime != null)
                    hash = hash * 59 + this.CreatedDatetime.GetHashCode();
                if (this.LastModifiedDatetime != null)
                    hash = hash * 59 + this.LastModifiedDatetime.GetHashCode();
                return hash;
            }
        }
    }

}

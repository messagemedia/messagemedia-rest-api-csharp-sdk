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
    /// Report
    /// </summary>
    [DataContract]
    public partial class Report :  IEquatable<Report>
    {
        /// <summary>
        /// The status of the message as per the delivery report
        /// </summary>
        /// <value>The status of the message as per the delivery report</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Enroute for "enroute"
            /// </summary>
            [EnumMember(Value = "enroute")]
            Enroute,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed,
            
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
            Undeliverable
        }

        /// <summary>
        /// The status of the message as per the delivery report
        /// </summary>
        /// <value>The status of the message as per the delivery report</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Report" /> class.
        /// </summary>
        /// <param name="CallbackUrl">The URL specified as the callback URL in the original submit message request.</param>
        /// <param name="DateReceived">The date and time at which this delivery report was generated in UTC..</param>
        /// <param name="Delay">Deprecated, no longer in use.</param>
        /// <param name="DeliveryReportId">Unique ID for this delivery report.</param>
        /// <param name="MessageId">Unique ID of the original message.</param>
        /// <param name="Metadata">Any metadata that was included in the original submit message request.</param>
        /// <param name="OriginalText">Text of the original message..</param>
        /// <param name="SourceNumber">Address from which this delivery report was received.</param>
        /// <param name="Status">The status of the message as per the delivery report.</param>
        /// <param name="SubmittedDate">The date and time when the message status changed in UTC. For a delivered DR this may indicate the time at which the message was received on the handset..</param>
        /// <param name="VendorAccountId">VendorAccountId.</param>
        public Report(string CallbackUrl = null, DateTime? DateReceived = null, int? Delay = null, Guid? DeliveryReportId = null, Guid? MessageId = null, Object Metadata = null, string OriginalText = null, string SourceNumber = null, StatusEnum? Status = null, DateTime? SubmittedDate = null, ReplyVendorAccountId VendorAccountId = null)
        {
            this.CallbackUrl = CallbackUrl;
            this.DateReceived = DateReceived;
            this.Delay = Delay;
            this.DeliveryReportId = DeliveryReportId;
            this.MessageId = MessageId;
            this.Metadata = Metadata;
            this.OriginalText = OriginalText;
            this.SourceNumber = SourceNumber;
            this.Status = Status;
            this.SubmittedDate = SubmittedDate;
            this.VendorAccountId = VendorAccountId;
        }
        
        /// <summary>
        /// The URL specified as the callback URL in the original submit message request
        /// </summary>
        /// <value>The URL specified as the callback URL in the original submit message request</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }
        /// <summary>
        /// The date and time at which this delivery report was generated in UTC.
        /// </summary>
        /// <value>The date and time at which this delivery report was generated in UTC.</value>
        [DataMember(Name="date_received", EmitDefaultValue=false)]
        public DateTime? DateReceived { get; set; }
        /// <summary>
        /// Deprecated, no longer in use
        /// </summary>
        /// <value>Deprecated, no longer in use</value>
        [DataMember(Name="delay", EmitDefaultValue=false)]
        public int? Delay { get; set; }
        /// <summary>
        /// Unique ID for this delivery report
        /// </summary>
        /// <value>Unique ID for this delivery report</value>
        [DataMember(Name="delivery_report_id", EmitDefaultValue=false)]
        public Guid? DeliveryReportId { get; set; }
        /// <summary>
        /// Unique ID of the original message
        /// </summary>
        /// <value>Unique ID of the original message</value>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public Guid? MessageId { get; set; }
        /// <summary>
        /// Any metadata that was included in the original submit message request
        /// </summary>
        /// <value>Any metadata that was included in the original submit message request</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }
        /// <summary>
        /// Text of the original message.
        /// </summary>
        /// <value>Text of the original message.</value>
        [DataMember(Name="original_text", EmitDefaultValue=false)]
        public string OriginalText { get; set; }
        /// <summary>
        /// Address from which this delivery report was received
        /// </summary>
        /// <value>Address from which this delivery report was received</value>
        [DataMember(Name="source_number", EmitDefaultValue=false)]
        public string SourceNumber { get; set; }
        /// <summary>
        /// The date and time when the message status changed in UTC. For a delivered DR this may indicate the time at which the message was received on the handset.
        /// </summary>
        /// <value>The date and time when the message status changed in UTC. For a delivered DR this may indicate the time at which the message was received on the handset.</value>
        [DataMember(Name="submitted_date", EmitDefaultValue=false)]
        public DateTime? SubmittedDate { get; set; }
        /// <summary>
        /// Gets or Sets VendorAccountId
        /// </summary>
        [DataMember(Name="vendor_account_id", EmitDefaultValue=false)]
        public ReplyVendorAccountId VendorAccountId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Report {\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  DateReceived: ").Append(DateReceived).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
            sb.Append("  DeliveryReportId: ").Append(DeliveryReportId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  OriginalText: ").Append(OriginalText).Append("\n");
            sb.Append("  SourceNumber: ").Append(SourceNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
            sb.Append("  VendorAccountId: ").Append(VendorAccountId).Append("\n");
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
            return this.Equals(obj as Report);
        }

        /// <summary>
        /// Returns true if Report instances are equal
        /// </summary>
        /// <param name="other">Instance of Report to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Report other)
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
                    this.DateReceived == other.DateReceived ||
                    this.DateReceived != null &&
                    this.DateReceived.Equals(other.DateReceived)
                ) && 
                (
                    this.Delay == other.Delay ||
                    this.Delay != null &&
                    this.Delay.Equals(other.Delay)
                ) && 
                (
                    this.DeliveryReportId == other.DeliveryReportId ||
                    this.DeliveryReportId != null &&
                    this.DeliveryReportId.Equals(other.DeliveryReportId)
                ) && 
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.OriginalText == other.OriginalText ||
                    this.OriginalText != null &&
                    this.OriginalText.Equals(other.OriginalText)
                ) && 
                (
                    this.SourceNumber == other.SourceNumber ||
                    this.SourceNumber != null &&
                    this.SourceNumber.Equals(other.SourceNumber)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SubmittedDate == other.SubmittedDate ||
                    this.SubmittedDate != null &&
                    this.SubmittedDate.Equals(other.SubmittedDate)
                ) && 
                (
                    this.VendorAccountId == other.VendorAccountId ||
                    this.VendorAccountId != null &&
                    this.VendorAccountId.Equals(other.VendorAccountId)
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
                if (this.DateReceived != null)
                    hash = hash * 59 + this.DateReceived.GetHashCode();
                if (this.Delay != null)
                    hash = hash * 59 + this.Delay.GetHashCode();
                if (this.DeliveryReportId != null)
                    hash = hash * 59 + this.DeliveryReportId.GetHashCode();
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.OriginalText != null)
                    hash = hash * 59 + this.OriginalText.GetHashCode();
                if (this.SourceNumber != null)
                    hash = hash * 59 + this.SourceNumber.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.SubmittedDate != null)
                    hash = hash * 59 + this.SubmittedDate.GetHashCode();
                if (this.VendorAccountId != null)
                    hash = hash * 59 + this.VendorAccountId.GetHashCode();
                return hash;
            }
        }
    }

}

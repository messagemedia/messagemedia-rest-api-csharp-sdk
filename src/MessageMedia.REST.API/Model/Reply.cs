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
    /// Reply
    /// </summary>
    [DataContract]
    public partial class Reply :  IEquatable<Reply>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reply" /> class.
        /// </summary>
        /// <param name="CallbackUrl">The URL specified as the callback URL in the original submit message request.</param>
        /// <param name="Content">Content of the reply.</param>
        /// <param name="DateReceived">Date time when the reply was received.</param>
        /// <param name="DestinationNumber">Address from which this reply was sent to.</param>
        /// <param name="MessageId">Unique ID of the original message.</param>
        /// <param name="Metadata">Any metadata that was included in the original submit message request.</param>
        /// <param name="ReplyId">Unique ID of this reply.</param>
        /// <param name="SourceNumber">Address from which this reply was received from.</param>
        /// <param name="VendorAccountId">VendorAccountId.</param>
        public Reply(string CallbackUrl = null, string Content = null, DateTime? DateReceived = null, string DestinationNumber = null, Guid? MessageId = null, Object Metadata = null, Guid? ReplyId = null, string SourceNumber = null, ReplyVendorAccountId VendorAccountId = null)
        {
            this.CallbackUrl = CallbackUrl;
            this.Content = Content;
            this.DateReceived = DateReceived;
            this.DestinationNumber = DestinationNumber;
            this.MessageId = MessageId;
            this.Metadata = Metadata;
            this.ReplyId = ReplyId;
            this.SourceNumber = SourceNumber;
            this.VendorAccountId = VendorAccountId;
        }
        
        /// <summary>
        /// The URL specified as the callback URL in the original submit message request
        /// </summary>
        /// <value>The URL specified as the callback URL in the original submit message request</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }
        /// <summary>
        /// Content of the reply
        /// </summary>
        /// <value>Content of the reply</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
        /// <summary>
        /// Date time when the reply was received
        /// </summary>
        /// <value>Date time when the reply was received</value>
        [DataMember(Name="date_received", EmitDefaultValue=false)]
        public DateTime? DateReceived { get; set; }
        /// <summary>
        /// Address from which this reply was sent to
        /// </summary>
        /// <value>Address from which this reply was sent to</value>
        [DataMember(Name="destination_number", EmitDefaultValue=false)]
        public string DestinationNumber { get; set; }
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
        /// Unique ID of this reply
        /// </summary>
        /// <value>Unique ID of this reply</value>
        [DataMember(Name="reply_id", EmitDefaultValue=false)]
        public Guid? ReplyId { get; set; }
        /// <summary>
        /// Address from which this reply was received from
        /// </summary>
        /// <value>Address from which this reply was received from</value>
        [DataMember(Name="source_number", EmitDefaultValue=false)]
        public string SourceNumber { get; set; }
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
            sb.Append("class Reply {\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  DateReceived: ").Append(DateReceived).Append("\n");
            sb.Append("  DestinationNumber: ").Append(DestinationNumber).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  ReplyId: ").Append(ReplyId).Append("\n");
            sb.Append("  SourceNumber: ").Append(SourceNumber).Append("\n");
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
            return this.Equals(obj as Reply);
        }

        /// <summary>
        /// Returns true if Reply instances are equal
        /// </summary>
        /// <param name="other">Instance of Reply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reply other)
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
                    this.DateReceived == other.DateReceived ||
                    this.DateReceived != null &&
                    this.DateReceived.Equals(other.DateReceived)
                ) && 
                (
                    this.DestinationNumber == other.DestinationNumber ||
                    this.DestinationNumber != null &&
                    this.DestinationNumber.Equals(other.DestinationNumber)
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
                    this.ReplyId == other.ReplyId ||
                    this.ReplyId != null &&
                    this.ReplyId.Equals(other.ReplyId)
                ) && 
                (
                    this.SourceNumber == other.SourceNumber ||
                    this.SourceNumber != null &&
                    this.SourceNumber.Equals(other.SourceNumber)
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
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.DateReceived != null)
                    hash = hash * 59 + this.DateReceived.GetHashCode();
                if (this.DestinationNumber != null)
                    hash = hash * 59 + this.DestinationNumber.GetHashCode();
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.ReplyId != null)
                    hash = hash * 59 + this.ReplyId.GetHashCode();
                if (this.SourceNumber != null)
                    hash = hash * 59 + this.SourceNumber.GetHashCode();
                if (this.VendorAccountId != null)
                    hash = hash * 59 + this.VendorAccountId.GetHashCode();
                return hash;
            }
        }
    }

}

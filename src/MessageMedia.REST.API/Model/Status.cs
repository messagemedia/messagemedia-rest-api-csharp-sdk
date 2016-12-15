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
    /// Status
    /// </summary>
    [DataContract]
    public partial class Status :  IEquatable<Status>
    {
        /// <summary>
        /// New status for the message
        /// </summary>
        /// <value>New status for the message</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Cancelled for "cancelled"
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled
        }

        /// <summary>
        /// New status for the message
        /// </summary>
        /// <value>New status for the message</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? _Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Status" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Status() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Status" /> class.
        /// </summary>
        /// <param name="_Status">New status for the message (required).</param>
        public Status(StatusEnum? _Status = null)
        {
            // to ensure "_Status" is required (not null)
            if (_Status == null)
            {
                throw new InvalidDataException("_Status is a required property for Status and cannot be null");
            }
            else
            {
                this._Status = _Status;
            }
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Status {\n");
            sb.Append("  _Status: ").Append(_Status).Append("\n");
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
            return this.Equals(obj as Status);
        }

        /// <summary>
        /// Returns true if Status instances are equal
        /// </summary>
        /// <param name="other">Instance of Status to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Status other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Status == other._Status ||
                    this._Status != null &&
                    this._Status.Equals(other._Status)
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
                if (this._Status != null)
                    hash = hash * 59 + this._Status.GetHashCode();
                return hash;
            }
        }
    }

}

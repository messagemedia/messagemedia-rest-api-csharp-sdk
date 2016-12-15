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
    /// Messages
    /// </summary>
    [DataContract]
    public partial class Messages :  IEquatable<Messages>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Messages" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Messages() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Messages" /> class.
        /// </summary>
        /// <param name="_Messages">_Messages (required).</param>
        public Messages(List<NewMessage> _Messages = null)
        {
            // to ensure "_Messages" is required (not null)
            if (_Messages == null)
            {
                throw new InvalidDataException("_Messages is a required property for Messages and cannot be null");
            }
            else
            {
                this._Messages = _Messages;
            }
        }
        
        /// <summary>
        /// Gets or Sets _Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<NewMessage> _Messages { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Messages {\n");
            sb.Append("  _Messages: ").Append(_Messages).Append("\n");
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
            return this.Equals(obj as Messages);
        }

        /// <summary>
        /// Returns true if Messages instances are equal
        /// </summary>
        /// <param name="other">Instance of Messages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Messages other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Messages == other._Messages ||
                    this._Messages != null &&
                    this._Messages.SequenceEqual(other._Messages)
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
                if (this._Messages != null)
                    hash = hash * 59 + this._Messages.GetHashCode();
                return hash;
            }
        }
    }

}

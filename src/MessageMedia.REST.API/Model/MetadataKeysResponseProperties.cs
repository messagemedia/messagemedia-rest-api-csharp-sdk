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
    /// MetadataKeysResponseProperties
    /// </summary>
    [DataContract]
    public partial class MetadataKeysResponseProperties :  IEquatable<MetadataKeysResponseProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataKeysResponseProperties" /> class.
        /// </summary>
        /// <param name="EndDate">The end date provided as a parameter for this report.</param>
        /// <param name="StartDate">The end date provided as a parameter for this report.</param>
        /// <param name="Accounts">List of accounts that were considered when fetching the metadata keys..</param>
        public MetadataKeysResponseProperties(DateTime? EndDate = null, DateTime? StartDate = null, List<string> Accounts = null)
        {
            this.EndDate = EndDate;
            this.StartDate = StartDate;
            this.Accounts = Accounts;
        }
        
        /// <summary>
        /// The end date provided as a parameter for this report
        /// </summary>
        /// <value>The end date provided as a parameter for this report</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The end date provided as a parameter for this report
        /// </summary>
        /// <value>The end date provided as a parameter for this report</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// List of accounts that were considered when fetching the metadata keys.
        /// </summary>
        /// <value>List of accounts that were considered when fetching the metadata keys.</value>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<string> Accounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataKeysResponseProperties {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
            return this.Equals(obj as MetadataKeysResponseProperties);
        }

        /// <summary>
        /// Returns true if MetadataKeysResponseProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of MetadataKeysResponseProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataKeysResponseProperties other)
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
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.Accounts == other.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(other.Accounts)
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
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.Accounts != null)
                    hash = hash * 59 + this.Accounts.GetHashCode();
                return hash;
            }
        }
    }

}

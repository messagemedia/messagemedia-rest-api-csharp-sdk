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
    /// Reports
    /// </summary>
    [DataContract]
    public partial class Reports :  IEquatable<Reports>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reports" /> class.
        /// </summary>
        /// <param name="DeliveryReports">The oldest 100 unconfirmed delivery reports.</param>
        public Reports(List<Report> DeliveryReports = null)
        {
            this.DeliveryReports = DeliveryReports;
        }
        
        /// <summary>
        /// The oldest 100 unconfirmed delivery reports
        /// </summary>
        /// <value>The oldest 100 unconfirmed delivery reports</value>
        [DataMember(Name="delivery_reports", EmitDefaultValue=false)]
        public List<Report> DeliveryReports { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reports {\n");
            sb.Append("  DeliveryReports: ").Append(DeliveryReports).Append("\n");
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
            return this.Equals(obj as Reports);
        }

        /// <summary>
        /// Returns true if Reports instances are equal
        /// </summary>
        /// <param name="other">Instance of Reports to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reports other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryReports == other.DeliveryReports ||
                    this.DeliveryReports != null &&
                    this.DeliveryReports.SequenceEqual(other.DeliveryReports)
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
                if (this.DeliveryReports != null)
                    hash = hash * 59 + this.DeliveryReports.GetHashCode();
                return hash;
            }
        }
    }

}

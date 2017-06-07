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
    /// SummaryReportItem
    /// </summary>
    [DataContract]
    public partial class SummaryReportItem :  IEquatable<SummaryReportItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryReportItem" /> class.
        /// </summary>
        /// <param name="Group">Group.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Subgroups">Subgroups.</param>
        public SummaryReportItem(string Group = null, int? Value = null, List<SummaryReportItem> Subgroups = null)
        {
            this.Group = Group;
            this.Value = Value;
            this.Subgroups = Subgroups;
        }
        
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }
        /// <summary>
        /// Gets or Sets Subgroups
        /// </summary>
        [DataMember(Name="subgroups", EmitDefaultValue=false)]
        public List<SummaryReportItem> Subgroups { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryReportItem {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Subgroups: ").Append(Subgroups).Append("\n");
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
            return this.Equals(obj as SummaryReportItem);
        }

        /// <summary>
        /// Returns true if SummaryReportItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SummaryReportItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryReportItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Subgroups == other.Subgroups ||
                    this.Subgroups != null &&
                    this.Subgroups.SequenceEqual(other.Subgroups)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Subgroups != null)
                    hash = hash * 59 + this.Subgroups.GetHashCode();
                return hash;
            }
        }
    }

}

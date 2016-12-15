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
    /// Pagination
    /// </summary>
    [DataContract]
    public partial class Pagination :  IEquatable<Pagination>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        /// <param name="Page">The current page of results.</param>
        /// <param name="PageSize">The amount of results returned per page.</param>
        /// <param name="TotalCount">The total number of results in the results set.</param>
        /// <param name="PageCount">The total number of pages in the results set.</param>
        /// <param name="NextUri">Link to the next page of results.</param>
        /// <param name="PreviousUri">Link to the previous page of results.</param>
        public Pagination(int? Page = null, int? PageSize = null, int? TotalCount = null, int? PageCount = null, string NextUri = null, string PreviousUri = null)
        {
            this.Page = Page;
            this.PageSize = PageSize;
            this.TotalCount = TotalCount;
            this.PageCount = PageCount;
            this.NextUri = NextUri;
            this.PreviousUri = PreviousUri;
        }
        
        /// <summary>
        /// The current page of results
        /// </summary>
        /// <value>The current page of results</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
        /// <summary>
        /// The amount of results returned per page
        /// </summary>
        /// <value>The amount of results returned per page</value>
        [DataMember(Name="page_size", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
        /// <summary>
        /// The total number of results in the results set
        /// </summary>
        /// <value>The total number of results in the results set</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }
        /// <summary>
        /// The total number of pages in the results set
        /// </summary>
        /// <value>The total number of pages in the results set</value>
        [DataMember(Name="page_count", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
        /// <summary>
        /// Link to the next page of results
        /// </summary>
        /// <value>Link to the next page of results</value>
        [DataMember(Name="next_uri", EmitDefaultValue=false)]
        public string NextUri { get; set; }
        /// <summary>
        /// Link to the previous page of results
        /// </summary>
        /// <value>Link to the previous page of results</value>
        [DataMember(Name="previous_uri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pagination {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
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
            return this.Equals(obj as Pagination);
        }

        /// <summary>
        /// Returns true if Pagination instances are equal
        /// </summary>
        /// <param name="other">Instance of Pagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pagination other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) && 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) && 
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) && 
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
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
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();
                if (this.PreviousUri != null)
                    hash = hash * 59 + this.PreviousUri.GetHashCode();
                return hash;
            }
        }
    }

}

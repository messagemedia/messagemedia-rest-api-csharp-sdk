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
    /// Order to sort results by.
    /// </summary>
    /// <value>Order to sort results by.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortDirectionBody
    {
        
        /// <summary>
        /// Enum ASCENDING for "ASCENDING"
        /// </summary>
        [EnumMember(Value = "ASCENDING")]
        ASCENDING,
        
        /// <summary>
        /// Enum DESCENDING for "DESCENDING"
        /// </summary>
        [EnumMember(Value = "DESCENDING")]
        DESCENDING
    }

}

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
    /// Filter results by message status.
    /// </summary>
    /// <value>Filter results by message status.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusBody
    {
        
        /// <summary>
        /// Enum CANCELLED for "CANCELLED"
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        CANCELLED,
        
        /// <summary>
        /// Enum DELIVERED for "DELIVERED"
        /// </summary>
        [EnumMember(Value = "DELIVERED")]
        DELIVERED,
        
        /// <summary>
        /// Enum ENROUTE for "ENROUTE"
        /// </summary>
        [EnumMember(Value = "ENROUTE")]
        ENROUTE,
        
        /// <summary>
        /// Enum EXPIRED for "EXPIRED"
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED,
        
        /// <summary>
        /// Enum HELD for "HELD"
        /// </summary>
        [EnumMember(Value = "HELD")]
        HELD,
        
        /// <summary>
        /// Enum PROCESSED for "PROCESSED"
        /// </summary>
        [EnumMember(Value = "PROCESSED")]
        PROCESSED,
        
        /// <summary>
        /// Enum PROCESSING for "PROCESSING"
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        PROCESSING,
        
        /// <summary>
        /// Enum QUEUED for "QUEUED"
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED,
        
        /// <summary>
        /// Enum REJECTED for "REJECTED"
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        REJECTED,
        
        /// <summary>
        /// Enum SCHEDULED for "SCHEDULED"
        /// </summary>
        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED,
        
        /// <summary>
        /// Enum SUBMITTED for "SUBMITTED"
        /// </summary>
        [EnumMember(Value = "SUBMITTED")]
        SUBMITTED
    }

}

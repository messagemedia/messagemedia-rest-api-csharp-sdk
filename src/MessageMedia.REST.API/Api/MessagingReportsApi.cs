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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Model;

namespace MessageMedia.REST.API.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagingReportsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns a list of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all delivery reports received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>DeliveryReports</returns>
        DeliveryReports GetDeliveryReportsDetail (DateTime? endDate, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all delivery reports received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of DeliveryReports</returns>
        ApiResponse<DeliveryReports> GetDeliveryReportsDetailWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SummaryReport</returns>
        SummaryReport GetDeliveryReportsSummary (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SummaryReport</returns>
        ApiResponse<SummaryReport> GetDeliveryReportsSummaryWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a list message received
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="action">Filter results by the action that was invoked for this message. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ReceivedMessages</returns>
        ReceivedMessages GetReceivedMessagesDetail (DateTime? endDate, DateTime? startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list message received
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="action">Filter results by the action that was invoked for this message. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of ReceivedMessages</returns>
        ApiResponse<ReceivedMessages> GetReceivedMessagesDetailWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of messages received
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SummaryReport</returns>
        SummaryReport GetReceivedMessagesSummary (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of messages received
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SummaryReport</returns>
        ApiResponse<SummaryReport> GetReceivedMessagesSummaryWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a list of message sent
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message sent during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SentMessages</returns>
        SentMessages GetSentMessagesDetail (DateTime? endDate, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list of message sent
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message sent during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SentMessages</returns>
        ApiResponse<SentMessages> GetSentMessagesDetailWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of messages sent
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SummaryReport</returns>
        SummaryReport GetSentMessagesSummary (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of messages sent
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SummaryReport</returns>
        ApiResponse<SummaryReport> GetSentMessagesSummaryWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns a list of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all delivery reports received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of DeliveryReports</returns>
        System.Threading.Tasks.Task<DeliveryReports> GetDeliveryReportsDetailAsync (DateTime? endDate, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all delivery reports received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (DeliveryReports)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeliveryReports>> GetDeliveryReportsDetailAsyncWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SummaryReport</returns>
        System.Threading.Tasks.Task<SummaryReport> GetDeliveryReportsSummaryAsync (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SummaryReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetDeliveryReportsSummaryAsyncWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a list message received
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="action">Filter results by the action that was invoked for this message. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ReceivedMessages</returns>
        System.Threading.Tasks.Task<ReceivedMessages> GetReceivedMessagesDetailAsync (DateTime? endDate, DateTime? startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list message received
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="action">Filter results by the action that was invoked for this message. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (ReceivedMessages)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReceivedMessages>> GetReceivedMessagesDetailAsyncWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of messages received
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SummaryReport</returns>
        System.Threading.Tasks.Task<SummaryReport> GetReceivedMessagesSummaryAsync (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of messages received
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SummaryReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetReceivedMessagesSummaryAsyncWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a list of message sent
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message sent during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SentMessages</returns>
        System.Threading.Tasks.Task<SentMessages> GetSentMessagesDetailAsync (DateTime? endDate, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list of message sent
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message sent during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SentMessages)</returns>
        System.Threading.Tasks.Task<ApiResponse<SentMessages>> GetSentMessagesDetailAsyncWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of messages sent
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SummaryReport</returns>
        System.Threading.Tasks.Task<SummaryReport> GetSentMessagesSummaryAsync (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of messages sent
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SummaryReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetSentMessagesSummaryAsyncWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MessagingReportsApi : IMessagingReportsApi
    {
        private MessageMedia.REST.API.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagingReportsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = MessageMedia.REST.API.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingReportsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessagingReportsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = MessageMedia.REST.API.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public MessageMedia.REST.API.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns a list of delivery reports Returns a detailed list of all delivery reports received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>DeliveryReports</returns>
        public DeliveryReports GetDeliveryReportsDetail (DateTime? endDate, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<DeliveryReports> localVarResponse = GetDeliveryReportsDetailWithHttpInfo(endDate, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of delivery reports Returns a detailed list of all delivery reports received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of DeliveryReports</returns>
        public ApiResponse< DeliveryReports > GetDeliveryReportsDetailWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetDeliveryReportsDetail");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetDeliveryReportsDetail");

            var localVarPath = "/reporting/delivery_reports/detail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (statusCode != null) localVarQueryParams.Add("status_code", Configuration.ApiClient.ParameterToString(statusCode)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page_size", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sort_by", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortDirection != null) localVarQueryParams.Add("sort_direction", Configuration.ApiClient.ParameterToString(sortDirection)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDeliveryReportsDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeliveryReports>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeliveryReports) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeliveryReports)));
            
        }

        /// <summary>
        /// Returns a list of delivery reports Returns a detailed list of all delivery reports received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of DeliveryReports</returns>
        public async System.Threading.Tasks.Task<DeliveryReports> GetDeliveryReportsDetailAsync (DateTime? endDate, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<DeliveryReports> localVarResponse = await GetDeliveryReportsDetailAsyncWithHttpInfo(endDate, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list of delivery reports Returns a detailed list of all delivery reports received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (DeliveryReports)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeliveryReports>> GetDeliveryReportsDetailAsyncWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetDeliveryReportsDetail");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetDeliveryReportsDetail");

            var localVarPath = "/reporting/delivery_reports/detail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (statusCode != null) localVarQueryParams.Add("status_code", Configuration.ApiClient.ParameterToString(statusCode)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page_size", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sort_by", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortDirection != null) localVarQueryParams.Add("sort_direction", Configuration.ApiClient.ParameterToString(sortDirection)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDeliveryReportsDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DeliveryReports>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeliveryReports) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeliveryReports)));
            
        }

        /// <summary>
        /// Returns a summarised report of delivery reports Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SummaryReport</returns>
        public SummaryReport GetDeliveryReportsSummary (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = GetDeliveryReportsSummaryWithHttpInfo(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a summarised report of delivery reports Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SummaryReport</returns>
        public ApiResponse< SummaryReport > GetDeliveryReportsSummaryWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetDeliveryReportsSummary");
            // verify the required parameter 'groupBy' is set
            if (groupBy == null)
                throw new ApiException(400, "Missing required parameter 'groupBy' when calling MessagingReportsApi->GetDeliveryReportsSummary");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetDeliveryReportsSummary");

            var localVarPath = "/reporting/delivery_reports/summary";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (statusCode != null) localVarQueryParams.Add("status_code", Configuration.ApiClient.ParameterToString(statusCode)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (summaryBy != null) localVarQueryParams.Add("summary_by", Configuration.ApiClient.ParameterToString(summaryBy)); // query parameter
            if (summaryField != null) localVarQueryParams.Add("summary_field", Configuration.ApiClient.ParameterToString(summaryField)); // query parameter
            if (groupBy != null) localVarQueryParams.Add("group_by", Configuration.ApiClient.ParameterToString(groupBy)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDeliveryReportsSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SummaryReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SummaryReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SummaryReport)));
            
        }

        /// <summary>
        /// Returns a summarised report of delivery reports Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SummaryReport</returns>
        public async System.Threading.Tasks.Task<SummaryReport> GetDeliveryReportsSummaryAsync (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = await GetDeliveryReportsSummaryAsyncWithHttpInfo(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a summarised report of delivery reports Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SummaryReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetDeliveryReportsSummaryAsyncWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetDeliveryReportsSummary");
            // verify the required parameter 'groupBy' is set
            if (groupBy == null)
                throw new ApiException(400, "Missing required parameter 'groupBy' when calling MessagingReportsApi->GetDeliveryReportsSummary");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetDeliveryReportsSummary");

            var localVarPath = "/reporting/delivery_reports/summary";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (statusCode != null) localVarQueryParams.Add("status_code", Configuration.ApiClient.ParameterToString(statusCode)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (summaryBy != null) localVarQueryParams.Add("summary_by", Configuration.ApiClient.ParameterToString(summaryBy)); // query parameter
            if (summaryField != null) localVarQueryParams.Add("summary_field", Configuration.ApiClient.ParameterToString(summaryField)); // query parameter
            if (groupBy != null) localVarQueryParams.Add("group_by", Configuration.ApiClient.ParameterToString(groupBy)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDeliveryReportsSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SummaryReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SummaryReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SummaryReport)));
            
        }

        /// <summary>
        /// Returns a list message received Returns a detailed list of all message received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="action">Filter results by the action that was invoked for this message. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ReceivedMessages</returns>
        public ReceivedMessages GetReceivedMessagesDetail (DateTime? endDate, DateTime? startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<ReceivedMessages> localVarResponse = GetReceivedMessagesDetailWithHttpInfo(endDate, startDate, accounts, action, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list message received Returns a detailed list of all message received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="action">Filter results by the action that was invoked for this message. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of ReceivedMessages</returns>
        public ApiResponse< ReceivedMessages > GetReceivedMessagesDetailWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetReceivedMessagesDetail");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetReceivedMessagesDetail");

            var localVarPath = "/reporting/received_messages/detail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page_size", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sort_by", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortDirection != null) localVarQueryParams.Add("sort_direction", Configuration.ApiClient.ParameterToString(sortDirection)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReceivedMessagesDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReceivedMessages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivedMessages) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivedMessages)));
            
        }

        /// <summary>
        /// Returns a list message received Returns a detailed list of all message received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="action">Filter results by the action that was invoked for this message. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ReceivedMessages</returns>
        public async System.Threading.Tasks.Task<ReceivedMessages> GetReceivedMessagesDetailAsync (DateTime? endDate, DateTime? startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<ReceivedMessages> localVarResponse = await GetReceivedMessagesDetailAsyncWithHttpInfo(endDate, startDate, accounts, action, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list message received Returns a detailed list of all message received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="action">Filter results by the action that was invoked for this message. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (ReceivedMessages)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReceivedMessages>> GetReceivedMessagesDetailAsyncWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetReceivedMessagesDetail");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetReceivedMessagesDetail");

            var localVarPath = "/reporting/received_messages/detail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page_size", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sort_by", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortDirection != null) localVarQueryParams.Add("sort_direction", Configuration.ApiClient.ParameterToString(sortDirection)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReceivedMessagesDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReceivedMessages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivedMessages) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivedMessages)));
            
        }

        /// <summary>
        /// Returns a summarised report of messages received Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SummaryReport</returns>
        public SummaryReport GetReceivedMessagesSummary (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = GetReceivedMessagesSummaryWithHttpInfo(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a summarised report of messages received Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SummaryReport</returns>
        public ApiResponse< SummaryReport > GetReceivedMessagesSummaryWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetReceivedMessagesSummary");
            // verify the required parameter 'groupBy' is set
            if (groupBy == null)
                throw new ApiException(400, "Missing required parameter 'groupBy' when calling MessagingReportsApi->GetReceivedMessagesSummary");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetReceivedMessagesSummary");

            var localVarPath = "/reporting/received_messages/summary";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (summaryBy != null) localVarQueryParams.Add("summary_by", Configuration.ApiClient.ParameterToString(summaryBy)); // query parameter
            if (summaryField != null) localVarQueryParams.Add("summary_field", Configuration.ApiClient.ParameterToString(summaryField)); // query parameter
            if (groupBy != null) localVarQueryParams.Add("group_by", Configuration.ApiClient.ParameterToString(groupBy)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReceivedMessagesSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SummaryReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SummaryReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SummaryReport)));
            
        }

        /// <summary>
        /// Returns a summarised report of messages received Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SummaryReport</returns>
        public async System.Threading.Tasks.Task<SummaryReport> GetReceivedMessagesSummaryAsync (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = await GetReceivedMessagesSummaryAsyncWithHttpInfo(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a summarised report of messages received Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SummaryReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetReceivedMessagesSummaryAsyncWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetReceivedMessagesSummary");
            // verify the required parameter 'groupBy' is set
            if (groupBy == null)
                throw new ApiException(400, "Missing required parameter 'groupBy' when calling MessagingReportsApi->GetReceivedMessagesSummary");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetReceivedMessagesSummary");

            var localVarPath = "/reporting/received_messages/summary";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (summaryBy != null) localVarQueryParams.Add("summary_by", Configuration.ApiClient.ParameterToString(summaryBy)); // query parameter
            if (summaryField != null) localVarQueryParams.Add("summary_field", Configuration.ApiClient.ParameterToString(summaryField)); // query parameter
            if (groupBy != null) localVarQueryParams.Add("group_by", Configuration.ApiClient.ParameterToString(groupBy)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReceivedMessagesSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SummaryReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SummaryReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SummaryReport)));
            
        }

        /// <summary>
        /// Returns a list of message sent Returns a detailed list of all message sent during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SentMessages</returns>
        public SentMessages GetSentMessagesDetail (DateTime? endDate, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SentMessages> localVarResponse = GetSentMessagesDetailWithHttpInfo(endDate, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of message sent Returns a detailed list of all message sent during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SentMessages</returns>
        public ApiResponse< SentMessages > GetSentMessagesDetailWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetSentMessagesDetail");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetSentMessagesDetail");

            var localVarPath = "/reporting/sent_messages/detail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (deliveryReport != null) localVarQueryParams.Add("delivery_report", Configuration.ApiClient.ParameterToString(deliveryReport)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (statusCode != null) localVarQueryParams.Add("status_code", Configuration.ApiClient.ParameterToString(statusCode)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page_size", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sort_by", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortDirection != null) localVarQueryParams.Add("sort_direction", Configuration.ApiClient.ParameterToString(sortDirection)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSentMessagesDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SentMessages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SentMessages) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SentMessages)));
            
        }

        /// <summary>
        /// Returns a list of message sent Returns a detailed list of all message sent during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SentMessages</returns>
        public async System.Threading.Tasks.Task<SentMessages> GetSentMessagesDetailAsync (DateTime? endDate, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SentMessages> localVarResponse = await GetSentMessagesDetailAsyncWithHttpInfo(endDate, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list of message sent Returns a detailed list of all message sent during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SentMessages)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SentMessages>> GetSentMessagesDetailAsyncWithHttpInfo (DateTime? endDate, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetSentMessagesDetail");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetSentMessagesDetail");

            var localVarPath = "/reporting/sent_messages/detail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (deliveryReport != null) localVarQueryParams.Add("delivery_report", Configuration.ApiClient.ParameterToString(deliveryReport)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (statusCode != null) localVarQueryParams.Add("status_code", Configuration.ApiClient.ParameterToString(statusCode)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page_size", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sort_by", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (sortDirection != null) localVarQueryParams.Add("sort_direction", Configuration.ApiClient.ParameterToString(sortDirection)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSentMessagesDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SentMessages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SentMessages) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SentMessages)));
            
        }

        /// <summary>
        /// Returns a summarised report of messages sent Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SummaryReport</returns>
        public SummaryReport GetSentMessagesSummary (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = GetSentMessagesSummaryWithHttpInfo(endDate, groupBy, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, summaryBy, summaryField, messageFormat, metadataKey, metadataValue, statusCode, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a summarised report of messages sent Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SummaryReport</returns>
        public ApiResponse< SummaryReport > GetSentMessagesSummaryWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetSentMessagesSummary");
            // verify the required parameter 'groupBy' is set
            if (groupBy == null)
                throw new ApiException(400, "Missing required parameter 'groupBy' when calling MessagingReportsApi->GetSentMessagesSummary");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetSentMessagesSummary");

            var localVarPath = "/reporting/sent_messages/summary";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (deliveryReport != null) localVarQueryParams.Add("delivery_report", Configuration.ApiClient.ParameterToString(deliveryReport)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (summaryBy != null) localVarQueryParams.Add("summary_by", Configuration.ApiClient.ParameterToString(summaryBy)); // query parameter
            if (summaryField != null) localVarQueryParams.Add("summary_field", Configuration.ApiClient.ParameterToString(summaryField)); // query parameter
            if (groupBy != null) localVarQueryParams.Add("group_by", Configuration.ApiClient.ParameterToString(groupBy)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (statusCode != null) localVarQueryParams.Add("status_code", Configuration.ApiClient.ParameterToString(statusCode)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSentMessagesSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SummaryReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SummaryReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SummaryReport)));
            
        }

        /// <summary>
        /// Returns a summarised report of messages sent Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SummaryReport</returns>
        public async System.Threading.Tasks.Task<SummaryReport> GetSentMessagesSummaryAsync (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = await GetSentMessagesSummaryAsyncWithHttpInfo(endDate, groupBy, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, summaryBy, summaryField, messageFormat, metadataKey, metadataValue, statusCode, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a summarised report of messages sent Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="groupBy">Field to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request.</param>
        /// <param name="accounts">Filter results by specific accounts. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SummaryReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetSentMessagesSummaryAsyncWithHttpInfo (DateTime? endDate, string groupBy, DateTime? startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetSentMessagesSummary");
            // verify the required parameter 'groupBy' is set
            if (groupBy == null)
                throw new ApiException(400, "Missing required parameter 'groupBy' when calling MessagingReportsApi->GetSentMessagesSummary");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetSentMessagesSummary");

            var localVarPath = "/reporting/sent_messages/summary";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
            if (deliveryReport != null) localVarQueryParams.Add("delivery_report", Configuration.ApiClient.ParameterToString(deliveryReport)); // query parameter
            if (destinationAddressCountry != null) localVarQueryParams.Add("destination_address_country", Configuration.ApiClient.ParameterToString(destinationAddressCountry)); // query parameter
            if (destinationAddress != null) localVarQueryParams.Add("destination_address", Configuration.ApiClient.ParameterToString(destinationAddress)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (summaryBy != null) localVarQueryParams.Add("summary_by", Configuration.ApiClient.ParameterToString(summaryBy)); // query parameter
            if (summaryField != null) localVarQueryParams.Add("summary_field", Configuration.ApiClient.ParameterToString(summaryField)); // query parameter
            if (groupBy != null) localVarQueryParams.Add("group_by", Configuration.ApiClient.ParameterToString(groupBy)); // query parameter
            if (messageFormat != null) localVarQueryParams.Add("message_format", Configuration.ApiClient.ParameterToString(messageFormat)); // query parameter
            if (metadataKey != null) localVarQueryParams.Add("metadata_key", Configuration.ApiClient.ParameterToString(metadataKey)); // query parameter
            if (metadataValue != null) localVarQueryParams.Add("metadata_value", Configuration.ApiClient.ParameterToString(metadataValue)); // query parameter
            if (statusCode != null) localVarQueryParams.Add("status_code", Configuration.ApiClient.ParameterToString(statusCode)); // query parameter
            if (sourceAddressCountry != null) localVarQueryParams.Add("source_address_country", Configuration.ApiClient.ParameterToString(sourceAddressCountry)); // query parameter
            if (sourceAddress != null) localVarQueryParams.Add("source_address", Configuration.ApiClient.ParameterToString(sourceAddress)); // query parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (timezone != null) localVarQueryParams.Add("timezone", Configuration.ApiClient.ParameterToString(timezone)); // query parameter

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSentMessagesSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SummaryReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SummaryReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SummaryReport)));
            
        }

    }
}

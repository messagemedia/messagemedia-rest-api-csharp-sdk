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
        /// Gets a single asynchronous report.
        /// </summary>
        /// <remarks>
        /// This endpoints shows information of a single requested asynchronous report.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>AsyncReport</returns>
        AsyncReport GetAsyncReportById (Guid? reportId);

        /// <summary>
        /// Gets a single asynchronous report.
        /// </summary>
        /// <remarks>
        /// This endpoints shows information of a single requested asynchronous report.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>ApiResponse of AsyncReport</returns>
        ApiResponse<AsyncReport> GetAsyncReportByIdWithHttpInfo (Guid? reportId);
        /// <summary>
        /// Gets the data of an asynchronous report.
        /// </summary>
        /// <remarks>
        /// This endpoints gets the data of an asynchronous report as a download.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetAsyncReportDataById (Guid? reportId);

        /// <summary>
        /// Gets the data of an asynchronous report.
        /// </summary>
        /// <remarks>
        /// This endpoints gets the data of an asynchronous report as a download.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> GetAsyncReportDataByIdWithHttpInfo (Guid? reportId);
        /// <summary>
        /// Lists asynchronous reports.
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the requested asynchronous reports.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetAsyncReports (int? page = null, int? pageSize = null);

        /// <summary>
        /// Lists asynchronous reports.
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the requested asynchronous reports.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetAsyncReportsWithHttpInfo (int? page = null, int? pageSize = null);
        /// <summary>
        /// Returns a list of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all delivery reports received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>DeliveryReports</returns>
        DeliveryReports GetDeliveryReportsDetail (string endDate, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all delivery reports received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of DeliveryReports</returns>
        ApiResponse<DeliveryReports> GetDeliveryReportsDetailWithHttpInfo (string endDate, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SummaryReport</returns>
        SummaryReport GetDeliveryReportsSummary (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SummaryReport</returns>
        ApiResponse<SummaryReport> GetDeliveryReportsSummaryWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a list of metadata keys
        /// </summary>
        /// <remarks>
        /// Returns a list of all metadata keys used for the specified message type during the specified time. Results are limited to 100 keys.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageType">Message type. Possible values are sent messages, received messages and delivery receipts.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>MetadataKeysResponse</returns>
        MetadataKeysResponse GetMetadataKeys (string messageType, string startDate, string endDate, string accounts = null, string timezone = null);

        /// <summary>
        /// Returns a list of metadata keys
        /// </summary>
        /// <remarks>
        /// Returns a list of all metadata keys used for the specified message type during the specified time. Results are limited to 100 keys.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageType">Message type. Possible values are sent messages, received messages and delivery receipts.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of MetadataKeysResponse</returns>
        ApiResponse<MetadataKeysResponse> GetMetadataKeysWithHttpInfo (string messageType, string startDate, string endDate, string accounts = null, string timezone = null);
        /// <summary>
        /// Returns a list message received
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        ReceivedMessages GetReceivedMessagesDetail (string endDate, string startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list message received
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        ApiResponse<ReceivedMessages> GetReceivedMessagesDetailWithHttpInfo (string endDate, string startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of messages received
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        SummaryReport GetReceivedMessagesSummary (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of messages received
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        ApiResponse<SummaryReport> GetReceivedMessagesSummaryWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a list of message sent
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message sent during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SentMessages</returns>
        SentMessages GetSentMessagesDetail (string endDate, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list of message sent
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message sent during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SentMessages</returns>
        ApiResponse<SentMessages> GetSentMessagesDetailWithHttpInfo (string endDate, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of messages sent
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        SummaryReport GetSentMessagesSummary (string endDate, List<string> groupBy, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of messages sent
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        ApiResponse<SummaryReport> GetSentMessagesSummaryWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all delivery reports received during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportDetailRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        AsyncReportResponse SubmitAsyncDeliveryReportsDetail (AsyncDeliveryReportDetailRequest asyncDeliveryReportDetailRequest);

        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all delivery reports received during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportDetailRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        ApiResponse<AsyncReportResponse> SubmitAsyncDeliveryReportsDetailWithHttpInfo (AsyncDeliveryReportDetailRequest asyncDeliveryReportDetailRequest);
        /// <summary>
        /// Submits a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all delivery reports during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportsSummaryRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        AsyncReportResponse SubmitDeliveryReportsSummary (AsyncDeliveryReportsSummaryRequest asyncDeliveryReportsSummaryRequest);

        /// <summary>
        /// Submits a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all delivery reports during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportsSummaryRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        ApiResponse<AsyncReportResponse> SubmitDeliveryReportsSummaryWithHttpInfo (AsyncDeliveryReportsSummaryRequest asyncDeliveryReportsSummaryRequest);
        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all received messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesDetailRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        AsyncReportResponse SubmitReceivedMessagesDetail (AsyncReceivedMessagesDetailRequest asyncReceivedMessagesDetailRequest);

        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all received messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesDetailRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        ApiResponse<AsyncReportResponse> SubmitReceivedMessagesDetailWithHttpInfo (AsyncReceivedMessagesDetailRequest asyncReceivedMessagesDetailRequest);
        /// <summary>
        /// Submits a summarised report of received messages
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all received messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesSummaryRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        AsyncReportResponse SubmitReceivedMessagesSummary (AsyncReceivedMessagesSummaryRequest asyncReceivedMessagesSummaryRequest);

        /// <summary>
        /// Submits a summarised report of received messages
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all received messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesSummaryRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        ApiResponse<AsyncReportResponse> SubmitReceivedMessagesSummaryWithHttpInfo (AsyncReceivedMessagesSummaryRequest asyncReceivedMessagesSummaryRequest);
        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all sent messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncSentMessagesDetailRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        AsyncReportResponse SubmitSentMessagesDetail (AsyncSentMessagesDetailRequest asyncSentMessagesDetailRequest);

        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all sent messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncSentMessagesDetailRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        ApiResponse<AsyncReportResponse> SubmitSentMessagesDetailWithHttpInfo (AsyncSentMessagesDetailRequest asyncSentMessagesDetailRequest);
        /// <summary>
        /// Submits a summarised report of sent messages
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all sent messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliverySentMessagesRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        AsyncReportResponse SubmitSentMessagesSummary (AsyncDeliverySentMessagesRequest asyncDeliverySentMessagesRequest);

        /// <summary>
        /// Submits a summarised report of sent messages
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all sent messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliverySentMessagesRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        ApiResponse<AsyncReportResponse> SubmitSentMessagesSummaryWithHttpInfo (AsyncDeliverySentMessagesRequest asyncDeliverySentMessagesRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets a single asynchronous report.
        /// </summary>
        /// <remarks>
        /// This endpoints shows information of a single requested asynchronous report.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>Task of AsyncReport</returns>
        System.Threading.Tasks.Task<AsyncReport> GetAsyncReportByIdAsync (Guid? reportId);

        /// <summary>
        /// Gets a single asynchronous report.
        /// </summary>
        /// <remarks>
        /// This endpoints shows information of a single requested asynchronous report.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>Task of ApiResponse (AsyncReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncReport>> GetAsyncReportByIdAsyncWithHttpInfo (Guid? reportId);
        /// <summary>
        /// Gets the data of an asynchronous report.
        /// </summary>
        /// <remarks>
        /// This endpoints gets the data of an asynchronous report as a download.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> GetAsyncReportDataByIdAsync (Guid? reportId);

        /// <summary>
        /// Gets the data of an asynchronous report.
        /// </summary>
        /// <remarks>
        /// This endpoints gets the data of an asynchronous report as a download.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetAsyncReportDataByIdAsyncWithHttpInfo (Guid? reportId);
        /// <summary>
        /// Lists asynchronous reports.
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the requested asynchronous reports.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetAsyncReportsAsync (int? page = null, int? pageSize = null);

        /// <summary>
        /// Lists asynchronous reports.
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the requested asynchronous reports.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetAsyncReportsAsyncWithHttpInfo (int? page = null, int? pageSize = null);
        /// <summary>
        /// Returns a list of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all delivery reports received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of DeliveryReports</returns>
        System.Threading.Tasks.Task<DeliveryReports> GetDeliveryReportsDetailAsync (string endDate, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all delivery reports received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (DeliveryReports)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeliveryReports>> GetDeliveryReportsDetailAsyncWithHttpInfo (string endDate, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SummaryReport</returns>
        System.Threading.Tasks.Task<SummaryReport> GetDeliveryReportsSummaryAsync (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SummaryReport)</returns>
        System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetDeliveryReportsSummaryAsyncWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a list of metadata keys
        /// </summary>
        /// <remarks>
        /// Returns a list of all metadata keys used for the specified message type during the specified time. Results are limited to 100 keys.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageType">Message type. Possible values are sent messages, received messages and delivery receipts.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of MetadataKeysResponse</returns>
        System.Threading.Tasks.Task<MetadataKeysResponse> GetMetadataKeysAsync (string messageType, string startDate, string endDate, string accounts = null, string timezone = null);

        /// <summary>
        /// Returns a list of metadata keys
        /// </summary>
        /// <remarks>
        /// Returns a list of all metadata keys used for the specified message type during the specified time. Results are limited to 100 keys.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageType">Message type. Possible values are sent messages, received messages and delivery receipts.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (MetadataKeysResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetadataKeysResponse>> GetMetadataKeysAsyncWithHttpInfo (string messageType, string startDate, string endDate, string accounts = null, string timezone = null);
        /// <summary>
        /// Returns a list message received
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        System.Threading.Tasks.Task<ReceivedMessages> GetReceivedMessagesDetailAsync (string endDate, string startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list message received
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message received during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        System.Threading.Tasks.Task<ApiResponse<ReceivedMessages>> GetReceivedMessagesDetailAsyncWithHttpInfo (string endDate, string startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of messages received
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        System.Threading.Tasks.Task<SummaryReport> GetReceivedMessagesSummaryAsync (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of messages received
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetReceivedMessagesSummaryAsyncWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a list of message sent
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message sent during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SentMessages</returns>
        System.Threading.Tasks.Task<SentMessages> GetSentMessagesDetailAsync (string endDate, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a list of message sent
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of all message sent during the specified time
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SentMessages)</returns>
        System.Threading.Tasks.Task<ApiResponse<SentMessages>> GetSentMessagesDetailAsyncWithHttpInfo (string endDate, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Returns a summarised report of messages sent
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        System.Threading.Tasks.Task<SummaryReport> GetSentMessagesSummaryAsync (string endDate, List<string> groupBy, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);

        /// <summary>
        /// Returns a summarised report of messages sent
        /// </summary>
        /// <remarks>
        /// Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetSentMessagesSummaryAsyncWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null);
        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all delivery reports received during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportDetailRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        System.Threading.Tasks.Task<AsyncReportResponse> SubmitAsyncDeliveryReportsDetailAsync (AsyncDeliveryReportDetailRequest asyncDeliveryReportDetailRequest);

        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all delivery reports received during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportDetailRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitAsyncDeliveryReportsDetailAsyncWithHttpInfo (AsyncDeliveryReportDetailRequest asyncDeliveryReportDetailRequest);
        /// <summary>
        /// Submits a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all delivery reports during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportsSummaryRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        System.Threading.Tasks.Task<AsyncReportResponse> SubmitDeliveryReportsSummaryAsync (AsyncDeliveryReportsSummaryRequest asyncDeliveryReportsSummaryRequest);

        /// <summary>
        /// Submits a summarised report of delivery reports
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all delivery reports during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportsSummaryRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitDeliveryReportsSummaryAsyncWithHttpInfo (AsyncDeliveryReportsSummaryRequest asyncDeliveryReportsSummaryRequest);
        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all received messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesDetailRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        System.Threading.Tasks.Task<AsyncReportResponse> SubmitReceivedMessagesDetailAsync (AsyncReceivedMessagesDetailRequest asyncReceivedMessagesDetailRequest);

        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all received messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesDetailRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitReceivedMessagesDetailAsyncWithHttpInfo (AsyncReceivedMessagesDetailRequest asyncReceivedMessagesDetailRequest);
        /// <summary>
        /// Submits a summarised report of received messages
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all received messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesSummaryRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        System.Threading.Tasks.Task<AsyncReportResponse> SubmitReceivedMessagesSummaryAsync (AsyncReceivedMessagesSummaryRequest asyncReceivedMessagesSummaryRequest);

        /// <summary>
        /// Submits a summarised report of received messages
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all received messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesSummaryRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitReceivedMessagesSummaryAsyncWithHttpInfo (AsyncReceivedMessagesSummaryRequest asyncReceivedMessagesSummaryRequest);
        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all sent messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncSentMessagesDetailRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        System.Threading.Tasks.Task<AsyncReportResponse> SubmitSentMessagesDetailAsync (AsyncSentMessagesDetailRequest asyncSentMessagesDetailRequest);

        /// <summary>
        /// Submits a request to generate an async detail report
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async detail report of all sent messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncSentMessagesDetailRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitSentMessagesDetailAsyncWithHttpInfo (AsyncSentMessagesDetailRequest asyncSentMessagesDetailRequest);
        /// <summary>
        /// Submits a summarised report of sent messages
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all sent messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliverySentMessagesRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        System.Threading.Tasks.Task<AsyncReportResponse> SubmitSentMessagesSummaryAsync (AsyncDeliverySentMessagesRequest asyncDeliverySentMessagesRequest);

        /// <summary>
        /// Submits a summarised report of sent messages
        /// </summary>
        /// <remarks>
        /// Submits a request to generate an async summary report of all sent messages during the specified time.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliverySentMessagesRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitSentMessagesSummaryAsyncWithHttpInfo (AsyncDeliverySentMessagesRequest asyncDeliverySentMessagesRequest);
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
        /// Gets a single asynchronous report. This endpoints shows information of a single requested asynchronous report.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>AsyncReport</returns>
        public AsyncReport GetAsyncReportById (Guid? reportId)
        {
             ApiResponse<AsyncReport> localVarResponse = GetAsyncReportByIdWithHttpInfo(reportId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a single asynchronous report. This endpoints shows information of a single requested asynchronous report.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>ApiResponse of AsyncReport</returns>
        public ApiResponse< AsyncReport > GetAsyncReportByIdWithHttpInfo (Guid? reportId)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling MessagingReportsApi->GetAsyncReportById");

            var localVarPath = "/reporting/async_reports/{report_id}";
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
            if (reportId != null) localVarPathParams.Add("report_id", Configuration.ApiClient.ParameterToString(reportId)); // path parameter

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
                Exception exception = ExceptionFactory("GetAsyncReportById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReport)));
            
        }

        /// <summary>
        /// Gets a single asynchronous report. This endpoints shows information of a single requested asynchronous report.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>Task of AsyncReport</returns>
        public async System.Threading.Tasks.Task<AsyncReport> GetAsyncReportByIdAsync (Guid? reportId)
        {
             ApiResponse<AsyncReport> localVarResponse = await GetAsyncReportByIdAsyncWithHttpInfo(reportId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a single asynchronous report. This endpoints shows information of a single requested asynchronous report.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>Task of ApiResponse (AsyncReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncReport>> GetAsyncReportByIdAsyncWithHttpInfo (Guid? reportId)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling MessagingReportsApi->GetAsyncReportById");

            var localVarPath = "/reporting/async_reports/{report_id}";
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
            if (reportId != null) localVarPathParams.Add("report_id", Configuration.ApiClient.ParameterToString(reportId)); // path parameter

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
                Exception exception = ExceptionFactory("GetAsyncReportById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReport>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReport) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReport)));
            
        }

        /// <summary>
        /// Gets the data of an asynchronous report. This endpoints gets the data of an asynchronous report as a download.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream GetAsyncReportDataById (Guid? reportId)
        {
             ApiResponse<System.IO.Stream> localVarResponse = GetAsyncReportDataByIdWithHttpInfo(reportId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the data of an asynchronous report. This endpoints gets the data of an asynchronous report as a download.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > GetAsyncReportDataByIdWithHttpInfo (Guid? reportId)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling MessagingReportsApi->GetAsyncReportDataById");

            var localVarPath = "/reporting/async_reports/{report_id}/data";
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
            if (reportId != null) localVarPathParams.Add("report_id", Configuration.ApiClient.ParameterToString(reportId)); // path parameter

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
                Exception exception = ExceptionFactory("GetAsyncReportDataById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
            
        }

        /// <summary>
        /// Gets the data of an asynchronous report. This endpoints gets the data of an asynchronous report as a download.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetAsyncReportDataByIdAsync (Guid? reportId)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await GetAsyncReportDataByIdAsyncWithHttpInfo(reportId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the data of an asynchronous report. This endpoints gets the data of an asynchronous report as a download.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">Unique ID of the async report</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetAsyncReportDataByIdAsyncWithHttpInfo (Guid? reportId)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling MessagingReportsApi->GetAsyncReportDataById");

            var localVarPath = "/reporting/async_reports/{report_id}/data";
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
            if (reportId != null) localVarPathParams.Add("report_id", Configuration.ApiClient.ParameterToString(reportId)); // path parameter

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
                Exception exception = ExceptionFactory("GetAsyncReportDataById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
            
        }

        /// <summary>
        /// Lists asynchronous reports. This endpoint lists all the requested asynchronous reports.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetAsyncReports (int? page = null, int? pageSize = null)
        {
             ApiResponse<InlineResponse200> localVarResponse = GetAsyncReportsWithHttpInfo(page, pageSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lists asynchronous reports. This endpoint lists all the requested asynchronous reports.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetAsyncReportsWithHttpInfo (int? page = null, int? pageSize = null)
        {

            var localVarPath = "/reporting/async_reports";
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
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page_size", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

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
                Exception exception = ExceptionFactory("GetAsyncReports", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Lists asynchronous reports. This endpoint lists all the requested asynchronous reports.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> GetAsyncReportsAsync (int? page = null, int? pageSize = null)
        {
             ApiResponse<InlineResponse200> localVarResponse = await GetAsyncReportsAsyncWithHttpInfo(page, pageSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lists asynchronous reports. This endpoint lists all the requested asynchronous reports.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetAsyncReportsAsyncWithHttpInfo (int? page = null, int? pageSize = null)
        {

            var localVarPath = "/reporting/async_reports";
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
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("page_size", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter

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
                Exception exception = ExceptionFactory("GetAsyncReports", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Returns a list of delivery reports Returns a detailed list of all delivery reports received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>DeliveryReports</returns>
        public DeliveryReports GetDeliveryReportsDetail (string endDate, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<DeliveryReports> localVarResponse = GetDeliveryReportsDetailWithHttpInfo(endDate, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, statuses, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of delivery reports Returns a detailed list of all delivery reports received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of DeliveryReports</returns>
        public ApiResponse< DeliveryReports > GetDeliveryReportsDetailWithHttpInfo (string endDate, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
            if (statuses != null) localVarQueryParams.Add("statuses", Configuration.ApiClient.ParameterToString(statuses)); // query parameter
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of DeliveryReports</returns>
        public async System.Threading.Tasks.Task<DeliveryReports> GetDeliveryReportsDetailAsync (string endDate, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<DeliveryReports> localVarResponse = await GetDeliveryReportsDetailAsyncWithHttpInfo(endDate, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, statuses, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list of delivery reports Returns a detailed list of all delivery reports received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (DeliveryReports)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeliveryReports>> GetDeliveryReportsDetailAsyncWithHttpInfo (string endDate, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
            if (statuses != null) localVarQueryParams.Add("statuses", Configuration.ApiClient.ParameterToString(statuses)); // query parameter
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SummaryReport</returns>
        public SummaryReport GetDeliveryReportsSummary (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = GetDeliveryReportsSummaryWithHttpInfo(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, statuses, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a summarised report of delivery reports Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SummaryReport</returns>
        public ApiResponse< SummaryReport > GetDeliveryReportsSummaryWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
            if (statuses != null) localVarQueryParams.Add("statuses", Configuration.ApiClient.ParameterToString(statuses)); // query parameter
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SummaryReport</returns>
        public async System.Threading.Tasks.Task<SummaryReport> GetDeliveryReportsSummaryAsync (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = await GetDeliveryReportsSummaryAsyncWithHttpInfo(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, statuses, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a summarised report of delivery reports Returns a summarised report of all delivery reports received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="summaryBy">Function to apply when summarising results (optional)</param>
        /// <param name="summaryField">Field to summarise results by (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SummaryReport)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetDeliveryReportsSummaryAsyncWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
            if (statuses != null) localVarQueryParams.Add("statuses", Configuration.ApiClient.ParameterToString(statuses)); // query parameter
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
        /// Returns a list of metadata keys Returns a list of all metadata keys used for the specified message type during the specified time. Results are limited to 100 keys.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageType">Message type. Possible values are sent messages, received messages and delivery receipts.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>MetadataKeysResponse</returns>
        public MetadataKeysResponse GetMetadataKeys (string messageType, string startDate, string endDate, string accounts = null, string timezone = null)
        {
             ApiResponse<MetadataKeysResponse> localVarResponse = GetMetadataKeysWithHttpInfo(messageType, startDate, endDate, accounts, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of metadata keys Returns a list of all metadata keys used for the specified message type during the specified time. Results are limited to 100 keys.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageType">Message type. Possible values are sent messages, received messages and delivery receipts.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of MetadataKeysResponse</returns>
        public ApiResponse< MetadataKeysResponse > GetMetadataKeysWithHttpInfo (string messageType, string startDate, string endDate, string accounts = null, string timezone = null)
        {
            // verify the required parameter 'messageType' is set
            if (messageType == null)
                throw new ApiException(400, "Missing required parameter 'messageType' when calling MessagingReportsApi->GetMetadataKeys");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetMetadataKeys");
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetMetadataKeys");

            var localVarPath = "/reporting/{messageType}/metadata/keys";
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
            if (messageType != null) localVarPathParams.Add("messageType", Configuration.ApiClient.ParameterToString(messageType)); // path parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
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
                Exception exception = ExceptionFactory("GetMetadataKeys", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetadataKeysResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MetadataKeysResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetadataKeysResponse)));
            
        }

        /// <summary>
        /// Returns a list of metadata keys Returns a list of all metadata keys used for the specified message type during the specified time. Results are limited to 100 keys.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageType">Message type. Possible values are sent messages, received messages and delivery receipts.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of MetadataKeysResponse</returns>
        public async System.Threading.Tasks.Task<MetadataKeysResponse> GetMetadataKeysAsync (string messageType, string startDate, string endDate, string accounts = null, string timezone = null)
        {
             ApiResponse<MetadataKeysResponse> localVarResponse = await GetMetadataKeysAsyncWithHttpInfo(messageType, startDate, endDate, accounts, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list of metadata keys Returns a list of all metadata keys used for the specified message type during the specified time. Results are limited to 100 keys.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageType">Message type. Possible values are sent messages, received messages and delivery receipts.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (MetadataKeysResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetadataKeysResponse>> GetMetadataKeysAsyncWithHttpInfo (string messageType, string startDate, string endDate, string accounts = null, string timezone = null)
        {
            // verify the required parameter 'messageType' is set
            if (messageType == null)
                throw new ApiException(400, "Missing required parameter 'messageType' when calling MessagingReportsApi->GetMetadataKeys");
            // verify the required parameter 'startDate' is set
            if (startDate == null)
                throw new ApiException(400, "Missing required parameter 'startDate' when calling MessagingReportsApi->GetMetadataKeys");
            // verify the required parameter 'endDate' is set
            if (endDate == null)
                throw new ApiException(400, "Missing required parameter 'endDate' when calling MessagingReportsApi->GetMetadataKeys");

            var localVarPath = "/reporting/{messageType}/metadata/keys";
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
            if (messageType != null) localVarPathParams.Add("messageType", Configuration.ApiClient.ParameterToString(messageType)); // path parameter
            if (startDate != null) localVarQueryParams.Add("start_date", Configuration.ApiClient.ParameterToString(startDate)); // query parameter
            if (endDate != null) localVarQueryParams.Add("end_date", Configuration.ApiClient.ParameterToString(endDate)); // query parameter
            if (accounts != null) localVarQueryParams.Add("accounts", Configuration.ApiClient.ParameterToString(accounts)); // query parameter
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
                Exception exception = ExceptionFactory("GetMetadataKeys", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetadataKeysResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MetadataKeysResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetadataKeysResponse)));
            
        }

        /// <summary>
        /// Returns a list message received Returns a detailed list of all message received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public ReceivedMessages GetReceivedMessagesDetail (string endDate, string startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<ReceivedMessages> localVarResponse = GetReceivedMessagesDetailWithHttpInfo(endDate, startDate, accounts, action, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list message received Returns a detailed list of all message received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public ApiResponse< ReceivedMessages > GetReceivedMessagesDetailWithHttpInfo (string endDate, string startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public async System.Threading.Tasks.Task<ReceivedMessages> GetReceivedMessagesDetailAsync (string endDate, string startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<ReceivedMessages> localVarResponse = await GetReceivedMessagesDetailAsyncWithHttpInfo(endDate, startDate, accounts, action, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list message received Returns a detailed list of all message received during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public async System.Threading.Tasks.Task<ApiResponse<ReceivedMessages>> GetReceivedMessagesDetailAsyncWithHttpInfo (string endDate, string startDate, string accounts = null, string action = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public SummaryReport GetReceivedMessagesSummary (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = GetReceivedMessagesSummaryWithHttpInfo(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a summarised report of messages received Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public ApiResponse< SummaryReport > GetReceivedMessagesSummaryWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public async System.Threading.Tasks.Task<SummaryReport> GetReceivedMessagesSummaryAsync (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = await GetReceivedMessagesSummaryAsyncWithHttpInfo(endDate, groupBy, startDate, accounts, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a summarised report of messages received Returns a summarised report of all messages received during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public async System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetReceivedMessagesSummaryAsyncWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string summaryBy = null, string summaryField = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>SentMessages</returns>
        public SentMessages GetSentMessagesDetail (string endDate, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SentMessages> localVarResponse = GetSentMessagesDetailWithHttpInfo(endDate, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, statuses, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of message sent Returns a detailed list of all message sent during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>ApiResponse of SentMessages</returns>
        public ApiResponse< SentMessages > GetSentMessagesDetailWithHttpInfo (string endDate, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
            if (statuses != null) localVarQueryParams.Add("statuses", Configuration.ApiClient.ParameterToString(statuses)); // query parameter
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of SentMessages</returns>
        public async System.Threading.Tasks.Task<SentMessages> GetSentMessagesDetailAsync (string endDate, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SentMessages> localVarResponse = await GetSentMessagesDetailAsyncWithHttpInfo(endDate, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, statuses, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list of message sent Returns a detailed list of all message sent during the specified time
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
        /// <param name="deliveryReport">Filter results by delivery report. (optional)</param>
        /// <param name="destinationAddressCountry">Filter results by destination address country. (optional)</param>
        /// <param name="destinationAddress">Filter results by destination address. (optional)</param>
        /// <param name="messageFormat">Filter results by message format. (optional)</param>
        /// <param name="metadataKey">Filter results for messages that include a metadata key. (optional)</param>
        /// <param name="metadataValue">Filter results for messages that include a metadata key containing this value. If this parameter is provided, the metadata_key parameter must also be provided. (optional)</param>
        /// <param name="statusCode">Filter results by message status code. (optional)</param>
        /// <param name="status">Filter results by message status. Can&#39;t be combined with statuses. (optional)</param>
        /// <param name="statuses">Filter results by message status. Can&#39;t be combined with status. (optional)</param>
        /// <param name="page">Page number for paging through paginated result sets. (optional)</param>
        /// <param name="pageSize">Number of results to return in a page for paginated result sets. (optional)</param>
        /// <param name="sortBy">Field to sort results set by (optional)</param>
        /// <param name="sortDirection">Order to sort results by. (optional)</param>
        /// <param name="sourceAddressCountry">Filter results by source address country. (optional)</param>
        /// <param name="sourceAddress">Filter results by source address. (optional)</param>
        /// <param name="timezone">The timezone to use for the context of the request. If provided this will be used as the timezone for the start date and end date parameters, and all datetime fields returns in the response. The timezone should be provided as a IANA (Internet Assigned Numbers Authority) time zone database zone name, i.e. &#39;Australia/Melbourne&#39;. (optional)</param>
        /// <returns>Task of ApiResponse (SentMessages)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SentMessages>> GetSentMessagesDetailAsyncWithHttpInfo (string endDate, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string status = null, List<string> statuses = null, int? page = null, int? pageSize = null, string sortBy = null, string sortDirection = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
            if (statuses != null) localVarQueryParams.Add("statuses", Configuration.ApiClient.ParameterToString(statuses)); // query parameter
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public SummaryReport GetSentMessagesSummary (string endDate, List<string> groupBy, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = GetSentMessagesSummaryWithHttpInfo(endDate, groupBy, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, summaryBy, summaryField, messageFormat, metadataKey, metadataValue, statusCode, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a summarised report of messages sent Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public ApiResponse< SummaryReport > GetSentMessagesSummaryWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public async System.Threading.Tasks.Task<SummaryReport> GetSentMessagesSummaryAsync (string endDate, List<string> groupBy, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
        {
             ApiResponse<SummaryReport> localVarResponse = await GetSentMessagesSummaryAsyncWithHttpInfo(endDate, groupBy, startDate, accounts, deliveryReport, destinationAddressCountry, destinationAddress, summaryBy, summaryField, messageFormat, metadataKey, metadataValue, statusCode, sourceAddressCountry, sourceAddress, timezone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a summarised report of messages sent Returns a summarised report of all messages sent during the specified time, grouped by by the specified grouping parameter
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endDate">End date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="groupBy">List of fields to group results set by</param>
        /// <param name="startDate">Start date time for report window. By default, the timezone for this parameter will be taken from the account settings for the account associated with the credentials used to make the request, or the account included in the Account parameter. This can be overridden using the timezone parameter per request. The date must be in the format of \&quot;yyyy-MM-dd&#39;T&#39;HH:mm:ss\&quot;, e.g. \&quot;2017-02-10T13:30:00\&quot;.</param>
        /// <param name="accounts">Filter results by a specific account. By default results will be returned for the account associated with the authentication credentials and all sub accounts. (optional)</param>
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
        public async System.Threading.Tasks.Task<ApiResponse<SummaryReport>> GetSentMessagesSummaryAsyncWithHttpInfo (string endDate, List<string> groupBy, string startDate, string accounts = null, bool? deliveryReport = null, string destinationAddressCountry = null, string destinationAddress = null, string summaryBy = null, string summaryField = null, string messageFormat = null, string metadataKey = null, string metadataValue = null, string statusCode = null, string sourceAddressCountry = null, string sourceAddress = null, string timezone = null)
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

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all delivery reports received during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportDetailRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        public AsyncReportResponse SubmitAsyncDeliveryReportsDetail (AsyncDeliveryReportDetailRequest asyncDeliveryReportDetailRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = SubmitAsyncDeliveryReportsDetailWithHttpInfo(asyncDeliveryReportDetailRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all delivery reports received during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportDetailRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        public ApiResponse< AsyncReportResponse > SubmitAsyncDeliveryReportsDetailWithHttpInfo (AsyncDeliveryReportDetailRequest asyncDeliveryReportDetailRequest)
        {
            // verify the required parameter 'asyncDeliveryReportDetailRequest' is set
            if (asyncDeliveryReportDetailRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncDeliveryReportDetailRequest' when calling MessagingReportsApi->SubmitAsyncDeliveryReportsDetail");

            var localVarPath = "/reporting/delivery_reports/detail/async";
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
            if (asyncDeliveryReportDetailRequest != null && asyncDeliveryReportDetailRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncDeliveryReportDetailRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncDeliveryReportDetailRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitAsyncDeliveryReportsDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all delivery reports received during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportDetailRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        public async System.Threading.Tasks.Task<AsyncReportResponse> SubmitAsyncDeliveryReportsDetailAsync (AsyncDeliveryReportDetailRequest asyncDeliveryReportDetailRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = await SubmitAsyncDeliveryReportsDetailAsyncWithHttpInfo(asyncDeliveryReportDetailRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all delivery reports received during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportDetailRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitAsyncDeliveryReportsDetailAsyncWithHttpInfo (AsyncDeliveryReportDetailRequest asyncDeliveryReportDetailRequest)
        {
            // verify the required parameter 'asyncDeliveryReportDetailRequest' is set
            if (asyncDeliveryReportDetailRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncDeliveryReportDetailRequest' when calling MessagingReportsApi->SubmitAsyncDeliveryReportsDetail");

            var localVarPath = "/reporting/delivery_reports/detail/async";
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
            if (asyncDeliveryReportDetailRequest != null && asyncDeliveryReportDetailRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncDeliveryReportDetailRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncDeliveryReportDetailRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitAsyncDeliveryReportsDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a summarised report of delivery reports Submits a request to generate an async summary report of all delivery reports during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportsSummaryRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        public AsyncReportResponse SubmitDeliveryReportsSummary (AsyncDeliveryReportsSummaryRequest asyncDeliveryReportsSummaryRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = SubmitDeliveryReportsSummaryWithHttpInfo(asyncDeliveryReportsSummaryRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submits a summarised report of delivery reports Submits a request to generate an async summary report of all delivery reports during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportsSummaryRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        public ApiResponse< AsyncReportResponse > SubmitDeliveryReportsSummaryWithHttpInfo (AsyncDeliveryReportsSummaryRequest asyncDeliveryReportsSummaryRequest)
        {
            // verify the required parameter 'asyncDeliveryReportsSummaryRequest' is set
            if (asyncDeliveryReportsSummaryRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncDeliveryReportsSummaryRequest' when calling MessagingReportsApi->SubmitDeliveryReportsSummary");

            var localVarPath = "/reporting/delivery_reports/summary/async";
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
            if (asyncDeliveryReportsSummaryRequest != null && asyncDeliveryReportsSummaryRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncDeliveryReportsSummaryRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncDeliveryReportsSummaryRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitDeliveryReportsSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a summarised report of delivery reports Submits a request to generate an async summary report of all delivery reports during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportsSummaryRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        public async System.Threading.Tasks.Task<AsyncReportResponse> SubmitDeliveryReportsSummaryAsync (AsyncDeliveryReportsSummaryRequest asyncDeliveryReportsSummaryRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = await SubmitDeliveryReportsSummaryAsyncWithHttpInfo(asyncDeliveryReportsSummaryRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submits a summarised report of delivery reports Submits a request to generate an async summary report of all delivery reports during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliveryReportsSummaryRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitDeliveryReportsSummaryAsyncWithHttpInfo (AsyncDeliveryReportsSummaryRequest asyncDeliveryReportsSummaryRequest)
        {
            // verify the required parameter 'asyncDeliveryReportsSummaryRequest' is set
            if (asyncDeliveryReportsSummaryRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncDeliveryReportsSummaryRequest' when calling MessagingReportsApi->SubmitDeliveryReportsSummary");

            var localVarPath = "/reporting/delivery_reports/summary/async";
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
            if (asyncDeliveryReportsSummaryRequest != null && asyncDeliveryReportsSummaryRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncDeliveryReportsSummaryRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncDeliveryReportsSummaryRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitDeliveryReportsSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all received messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesDetailRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        public AsyncReportResponse SubmitReceivedMessagesDetail (AsyncReceivedMessagesDetailRequest asyncReceivedMessagesDetailRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = SubmitReceivedMessagesDetailWithHttpInfo(asyncReceivedMessagesDetailRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all received messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesDetailRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        public ApiResponse< AsyncReportResponse > SubmitReceivedMessagesDetailWithHttpInfo (AsyncReceivedMessagesDetailRequest asyncReceivedMessagesDetailRequest)
        {
            // verify the required parameter 'asyncReceivedMessagesDetailRequest' is set
            if (asyncReceivedMessagesDetailRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncReceivedMessagesDetailRequest' when calling MessagingReportsApi->SubmitReceivedMessagesDetail");

            var localVarPath = "/reporting/received_messages/detail/async";
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
            if (asyncReceivedMessagesDetailRequest != null && asyncReceivedMessagesDetailRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncReceivedMessagesDetailRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncReceivedMessagesDetailRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitReceivedMessagesDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all received messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesDetailRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        public async System.Threading.Tasks.Task<AsyncReportResponse> SubmitReceivedMessagesDetailAsync (AsyncReceivedMessagesDetailRequest asyncReceivedMessagesDetailRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = await SubmitReceivedMessagesDetailAsyncWithHttpInfo(asyncReceivedMessagesDetailRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all received messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesDetailRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitReceivedMessagesDetailAsyncWithHttpInfo (AsyncReceivedMessagesDetailRequest asyncReceivedMessagesDetailRequest)
        {
            // verify the required parameter 'asyncReceivedMessagesDetailRequest' is set
            if (asyncReceivedMessagesDetailRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncReceivedMessagesDetailRequest' when calling MessagingReportsApi->SubmitReceivedMessagesDetail");

            var localVarPath = "/reporting/received_messages/detail/async";
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
            if (asyncReceivedMessagesDetailRequest != null && asyncReceivedMessagesDetailRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncReceivedMessagesDetailRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncReceivedMessagesDetailRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitReceivedMessagesDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a summarised report of received messages Submits a request to generate an async summary report of all received messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesSummaryRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        public AsyncReportResponse SubmitReceivedMessagesSummary (AsyncReceivedMessagesSummaryRequest asyncReceivedMessagesSummaryRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = SubmitReceivedMessagesSummaryWithHttpInfo(asyncReceivedMessagesSummaryRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submits a summarised report of received messages Submits a request to generate an async summary report of all received messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesSummaryRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        public ApiResponse< AsyncReportResponse > SubmitReceivedMessagesSummaryWithHttpInfo (AsyncReceivedMessagesSummaryRequest asyncReceivedMessagesSummaryRequest)
        {
            // verify the required parameter 'asyncReceivedMessagesSummaryRequest' is set
            if (asyncReceivedMessagesSummaryRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncReceivedMessagesSummaryRequest' when calling MessagingReportsApi->SubmitReceivedMessagesSummary");

            var localVarPath = "/reporting/received_messages/summary/async";
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
            if (asyncReceivedMessagesSummaryRequest != null && asyncReceivedMessagesSummaryRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncReceivedMessagesSummaryRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncReceivedMessagesSummaryRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitReceivedMessagesSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a summarised report of received messages Submits a request to generate an async summary report of all received messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesSummaryRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        public async System.Threading.Tasks.Task<AsyncReportResponse> SubmitReceivedMessagesSummaryAsync (AsyncReceivedMessagesSummaryRequest asyncReceivedMessagesSummaryRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = await SubmitReceivedMessagesSummaryAsyncWithHttpInfo(asyncReceivedMessagesSummaryRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submits a summarised report of received messages Submits a request to generate an async summary report of all received messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncReceivedMessagesSummaryRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitReceivedMessagesSummaryAsyncWithHttpInfo (AsyncReceivedMessagesSummaryRequest asyncReceivedMessagesSummaryRequest)
        {
            // verify the required parameter 'asyncReceivedMessagesSummaryRequest' is set
            if (asyncReceivedMessagesSummaryRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncReceivedMessagesSummaryRequest' when calling MessagingReportsApi->SubmitReceivedMessagesSummary");

            var localVarPath = "/reporting/received_messages/summary/async";
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
            if (asyncReceivedMessagesSummaryRequest != null && asyncReceivedMessagesSummaryRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncReceivedMessagesSummaryRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncReceivedMessagesSummaryRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitReceivedMessagesSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all sent messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncSentMessagesDetailRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        public AsyncReportResponse SubmitSentMessagesDetail (AsyncSentMessagesDetailRequest asyncSentMessagesDetailRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = SubmitSentMessagesDetailWithHttpInfo(asyncSentMessagesDetailRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all sent messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncSentMessagesDetailRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        public ApiResponse< AsyncReportResponse > SubmitSentMessagesDetailWithHttpInfo (AsyncSentMessagesDetailRequest asyncSentMessagesDetailRequest)
        {
            // verify the required parameter 'asyncSentMessagesDetailRequest' is set
            if (asyncSentMessagesDetailRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncSentMessagesDetailRequest' when calling MessagingReportsApi->SubmitSentMessagesDetail");

            var localVarPath = "/reporting/sent_messages/detail/async";
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
            if (asyncSentMessagesDetailRequest != null && asyncSentMessagesDetailRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncSentMessagesDetailRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncSentMessagesDetailRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitSentMessagesDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all sent messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncSentMessagesDetailRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        public async System.Threading.Tasks.Task<AsyncReportResponse> SubmitSentMessagesDetailAsync (AsyncSentMessagesDetailRequest asyncSentMessagesDetailRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = await SubmitSentMessagesDetailAsyncWithHttpInfo(asyncSentMessagesDetailRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submits a request to generate an async detail report Submits a request to generate an async detail report of all sent messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncSentMessagesDetailRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitSentMessagesDetailAsyncWithHttpInfo (AsyncSentMessagesDetailRequest asyncSentMessagesDetailRequest)
        {
            // verify the required parameter 'asyncSentMessagesDetailRequest' is set
            if (asyncSentMessagesDetailRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncSentMessagesDetailRequest' when calling MessagingReportsApi->SubmitSentMessagesDetail");

            var localVarPath = "/reporting/sent_messages/detail/async";
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
            if (asyncSentMessagesDetailRequest != null && asyncSentMessagesDetailRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncSentMessagesDetailRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncSentMessagesDetailRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitSentMessagesDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a summarised report of sent messages Submits a request to generate an async summary report of all sent messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliverySentMessagesRequest"></param>
        /// <returns>AsyncReportResponse</returns>
        public AsyncReportResponse SubmitSentMessagesSummary (AsyncDeliverySentMessagesRequest asyncDeliverySentMessagesRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = SubmitSentMessagesSummaryWithHttpInfo(asyncDeliverySentMessagesRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submits a summarised report of sent messages Submits a request to generate an async summary report of all sent messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliverySentMessagesRequest"></param>
        /// <returns>ApiResponse of AsyncReportResponse</returns>
        public ApiResponse< AsyncReportResponse > SubmitSentMessagesSummaryWithHttpInfo (AsyncDeliverySentMessagesRequest asyncDeliverySentMessagesRequest)
        {
            // verify the required parameter 'asyncDeliverySentMessagesRequest' is set
            if (asyncDeliverySentMessagesRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncDeliverySentMessagesRequest' when calling MessagingReportsApi->SubmitSentMessagesSummary");

            var localVarPath = "/reporting/sent_messages/summary/async";
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
            if (asyncDeliverySentMessagesRequest != null && asyncDeliverySentMessagesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncDeliverySentMessagesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncDeliverySentMessagesRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitSentMessagesSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

        /// <summary>
        /// Submits a summarised report of sent messages Submits a request to generate an async summary report of all sent messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliverySentMessagesRequest"></param>
        /// <returns>Task of AsyncReportResponse</returns>
        public async System.Threading.Tasks.Task<AsyncReportResponse> SubmitSentMessagesSummaryAsync (AsyncDeliverySentMessagesRequest asyncDeliverySentMessagesRequest)
        {
             ApiResponse<AsyncReportResponse> localVarResponse = await SubmitSentMessagesSummaryAsyncWithHttpInfo(asyncDeliverySentMessagesRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Submits a summarised report of sent messages Submits a request to generate an async summary report of all sent messages during the specified time.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="asyncDeliverySentMessagesRequest"></param>
        /// <returns>Task of ApiResponse (AsyncReportResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncReportResponse>> SubmitSentMessagesSummaryAsyncWithHttpInfo (AsyncDeliverySentMessagesRequest asyncDeliverySentMessagesRequest)
        {
            // verify the required parameter 'asyncDeliverySentMessagesRequest' is set
            if (asyncDeliverySentMessagesRequest == null)
                throw new ApiException(400, "Missing required parameter 'asyncDeliverySentMessagesRequest' when calling MessagingReportsApi->SubmitSentMessagesSummary");

            var localVarPath = "/reporting/sent_messages/summary/async";
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
            if (asyncDeliverySentMessagesRequest != null && asyncDeliverySentMessagesRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(asyncDeliverySentMessagesRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = asyncDeliverySentMessagesRequest; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitSentMessagesSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AsyncReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncReportResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncReportResponse)));
            
        }

    }
}

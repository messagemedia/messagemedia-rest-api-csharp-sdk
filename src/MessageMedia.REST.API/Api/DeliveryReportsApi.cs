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
    public interface IDeliveryReportsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check delivery reports
        /// </summary>
        /// <remarks>
        /// Return up to 100 delivery reports that have been received and haven&#39;t been confirmed using the confirm reports endpoint
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Reports</returns>
        Reports CheckReports ();

        /// <summary>
        /// Check delivery reports
        /// </summary>
        /// <remarks>
        /// Return up to 100 delivery reports that have been received and haven&#39;t been confirmed using the confirm reports endpoint
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Reports</returns>
        ApiResponse<Reports> CheckReportsWithHttpInfo ();
        /// <summary>
        /// Confirm delivery reports as received
        /// </summary>
        /// <remarks>
        /// Confirm the specified delivery reports as being received so they will no longer be returned in check delivery reports requests
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryReportId">A list of delivery report IDs to mark as confirmed</param>
        /// <returns></returns>
        void ConfirmReports (DeliveryReportId deliveryReportId);

        /// <summary>
        /// Confirm delivery reports as received
        /// </summary>
        /// <remarks>
        /// Confirm the specified delivery reports as being received so they will no longer be returned in check delivery reports requests
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryReportId">A list of delivery report IDs to mark as confirmed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConfirmReportsWithHttpInfo (DeliveryReportId deliveryReportId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Check delivery reports
        /// </summary>
        /// <remarks>
        /// Return up to 100 delivery reports that have been received and haven&#39;t been confirmed using the confirm reports endpoint
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Reports</returns>
        System.Threading.Tasks.Task<Reports> CheckReportsAsync ();

        /// <summary>
        /// Check delivery reports
        /// </summary>
        /// <remarks>
        /// Return up to 100 delivery reports that have been received and haven&#39;t been confirmed using the confirm reports endpoint
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Reports)</returns>
        System.Threading.Tasks.Task<ApiResponse<Reports>> CheckReportsAsyncWithHttpInfo ();
        /// <summary>
        /// Confirm delivery reports as received
        /// </summary>
        /// <remarks>
        /// Confirm the specified delivery reports as being received so they will no longer be returned in check delivery reports requests
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryReportId">A list of delivery report IDs to mark as confirmed</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConfirmReportsAsync (DeliveryReportId deliveryReportId);

        /// <summary>
        /// Confirm delivery reports as received
        /// </summary>
        /// <remarks>
        /// Confirm the specified delivery reports as being received so they will no longer be returned in check delivery reports requests
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryReportId">A list of delivery report IDs to mark as confirmed</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConfirmReportsAsyncWithHttpInfo (DeliveryReportId deliveryReportId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeliveryReportsApi : IDeliveryReportsApi
    {
        private MessageMedia.REST.API.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeliveryReportsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="DeliveryReportsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeliveryReportsApi(Configuration configuration = null)
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
        /// Check delivery reports Return up to 100 delivery reports that have been received and haven&#39;t been confirmed using the confirm reports endpoint
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Reports</returns>
        public Reports CheckReports ()
        {
             ApiResponse<Reports> localVarResponse = CheckReportsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check delivery reports Return up to 100 delivery reports that have been received and haven&#39;t been confirmed using the confirm reports endpoint
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Reports</returns>
        public ApiResponse< Reports > CheckReportsWithHttpInfo ()
        {

            var localVarPath = "/delivery_reports";
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
                Exception exception = ExceptionFactory("CheckReports", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Reports>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reports) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reports)));
            
        }

        /// <summary>
        /// Check delivery reports Return up to 100 delivery reports that have been received and haven&#39;t been confirmed using the confirm reports endpoint
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Reports</returns>
        public async System.Threading.Tasks.Task<Reports> CheckReportsAsync ()
        {
             ApiResponse<Reports> localVarResponse = await CheckReportsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check delivery reports Return up to 100 delivery reports that have been received and haven&#39;t been confirmed using the confirm reports endpoint
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Reports)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Reports>> CheckReportsAsyncWithHttpInfo ()
        {

            var localVarPath = "/delivery_reports";
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
                Exception exception = ExceptionFactory("CheckReports", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Reports>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Reports) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Reports)));
            
        }

        /// <summary>
        /// Confirm delivery reports as received Confirm the specified delivery reports as being received so they will no longer be returned in check delivery reports requests
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryReportId">A list of delivery report IDs to mark as confirmed</param>
        /// <returns></returns>
        public void ConfirmReports (DeliveryReportId deliveryReportId)
        {
             ConfirmReportsWithHttpInfo(deliveryReportId);
        }

        /// <summary>
        /// Confirm delivery reports as received Confirm the specified delivery reports as being received so they will no longer be returned in check delivery reports requests
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryReportId">A list of delivery report IDs to mark as confirmed</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConfirmReportsWithHttpInfo (DeliveryReportId deliveryReportId)
        {
            // verify the required parameter 'deliveryReportId' is set
            if (deliveryReportId == null)
                throw new ApiException(400, "Missing required parameter 'deliveryReportId' when calling DeliveryReportsApi->ConfirmReports");

            var localVarPath = "/delivery_reports/confirmed";
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
            if (deliveryReportId != null && deliveryReportId.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(deliveryReportId); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deliveryReportId; // byte array
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
                Exception exception = ExceptionFactory("ConfirmReports", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Confirm delivery reports as received Confirm the specified delivery reports as being received so they will no longer be returned in check delivery reports requests
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryReportId">A list of delivery report IDs to mark as confirmed</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConfirmReportsAsync (DeliveryReportId deliveryReportId)
        {
             await ConfirmReportsAsyncWithHttpInfo(deliveryReportId);

        }

        /// <summary>
        /// Confirm delivery reports as received Confirm the specified delivery reports as being received so they will no longer be returned in check delivery reports requests
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryReportId">A list of delivery report IDs to mark as confirmed</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConfirmReportsAsyncWithHttpInfo (DeliveryReportId deliveryReportId)
        {
            // verify the required parameter 'deliveryReportId' is set
            if (deliveryReportId == null)
                throw new ApiException(400, "Missing required parameter 'deliveryReportId' when calling DeliveryReportsApi->ConfirmReports");

            var localVarPath = "/delivery_reports/confirmed";
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
            if (deliveryReportId != null && deliveryReportId.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(deliveryReportId); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deliveryReportId; // byte array
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
                Exception exception = ExceptionFactory("ConfirmReports", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}

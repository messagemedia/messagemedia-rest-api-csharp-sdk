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
    public interface IMessagingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the status of a submitted message
        /// </summary>
        /// <remarks>
        /// Get the status and details of a previously submitted message
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message that has been submitted</param>
        /// <returns>SubmittedMessage</returns>
        SubmittedMessage GetMessageStatus (Guid? messageId);

        /// <summary>
        /// Get the status of a submitted message
        /// </summary>
        /// <remarks>
        /// Get the status and details of a previously submitted message
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message that has been submitted</param>
        /// <returns>ApiResponse of SubmittedMessage</returns>
        ApiResponse<SubmittedMessage> GetMessageStatusWithHttpInfo (Guid? messageId);
        /// <summary>
        /// Send one or more messages
        /// </summary>
        /// <remarks>
        /// Submit one or more (up to 100 per request) SMS or text to voice messages to be sent to the destination address. - A callback URL can be included with each message to which MO and DR notifications will be pushed to via a HTTP POST request. - The content of the message can be a Unicode string, up to 5000 characters long - A delivery report can be be requested with the message which will be pushed to a HTTP endpoint if specified, or available via the Check Reports endpoint. - The destination number should be specified in E.164 international format. For information on E.164, please refer to http://en.wikipedia.org/wiki/E.164 - The format specifies which format the message will be sent as, SMS (text message) or TTS (text to speech). With TTS format, we will call the destination number and read out the message using a computer generated voice. - If specified the source number included in the request will be shown as the source number for the message, this feature is not enabled by default, please contact MessageMedia for more information. - If a source number is specified, the type of source number may also be specified. This is recommended when using a source address type that is not an internationally formatted number, available options are INTERNATIONAL, ALPHANUMERIC or SHORTCODE - The message will be scheduled to be delivered in the future if the scheduled parameter is specified. - A message expiry timestamp can be provided, if the message is not delivered by this time, it will be discarded. - Metadata can be included with the message. Up to 10 key value pair strings can be included with each message. This metadata will be available in delivery reports and replies.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messages">A list of messages to be sent</param>
        /// <returns>SubmittedMessages</returns>
        SubmittedMessages SendMessages (Messages messages);

        /// <summary>
        /// Send one or more messages
        /// </summary>
        /// <remarks>
        /// Submit one or more (up to 100 per request) SMS or text to voice messages to be sent to the destination address. - A callback URL can be included with each message to which MO and DR notifications will be pushed to via a HTTP POST request. - The content of the message can be a Unicode string, up to 5000 characters long - A delivery report can be be requested with the message which will be pushed to a HTTP endpoint if specified, or available via the Check Reports endpoint. - The destination number should be specified in E.164 international format. For information on E.164, please refer to http://en.wikipedia.org/wiki/E.164 - The format specifies which format the message will be sent as, SMS (text message) or TTS (text to speech). With TTS format, we will call the destination number and read out the message using a computer generated voice. - If specified the source number included in the request will be shown as the source number for the message, this feature is not enabled by default, please contact MessageMedia for more information. - If a source number is specified, the type of source number may also be specified. This is recommended when using a source address type that is not an internationally formatted number, available options are INTERNATIONAL, ALPHANUMERIC or SHORTCODE - The message will be scheduled to be delivered in the future if the scheduled parameter is specified. - A message expiry timestamp can be provided, if the message is not delivered by this time, it will be discarded. - Metadata can be included with the message. Up to 10 key value pair strings can be included with each message. This metadata will be available in delivery reports and replies.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messages">A list of messages to be sent</param>
        /// <returns>ApiResponse of SubmittedMessages</returns>
        ApiResponse<SubmittedMessages> SendMessagesWithHttpInfo (Messages messages);
        /// <summary>
        /// Cancel a scheduled message
        /// </summary>
        /// <remarks>
        /// Cancel a scheduled message
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message to be updated</param>
        /// <param name="status">New status for the message</param>
        /// <returns></returns>
        void UpdateMessageStatus (Guid? messageId, Status status);

        /// <summary>
        /// Cancel a scheduled message
        /// </summary>
        /// <remarks>
        /// Cancel a scheduled message
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message to be updated</param>
        /// <param name="status">New status for the message</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateMessageStatusWithHttpInfo (Guid? messageId, Status status);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get the status of a submitted message
        /// </summary>
        /// <remarks>
        /// Get the status and details of a previously submitted message
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message that has been submitted</param>
        /// <returns>Task of SubmittedMessage</returns>
        System.Threading.Tasks.Task<SubmittedMessage> GetMessageStatusAsync (Guid? messageId);

        /// <summary>
        /// Get the status of a submitted message
        /// </summary>
        /// <remarks>
        /// Get the status and details of a previously submitted message
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message that has been submitted</param>
        /// <returns>Task of ApiResponse (SubmittedMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubmittedMessage>> GetMessageStatusAsyncWithHttpInfo (Guid? messageId);
        /// <summary>
        /// Send one or more messages
        /// </summary>
        /// <remarks>
        /// Submit one or more (up to 100 per request) SMS or text to voice messages to be sent to the destination address. - A callback URL can be included with each message to which MO and DR notifications will be pushed to via a HTTP POST request. - The content of the message can be a Unicode string, up to 5000 characters long - A delivery report can be be requested with the message which will be pushed to a HTTP endpoint if specified, or available via the Check Reports endpoint. - The destination number should be specified in E.164 international format. For information on E.164, please refer to http://en.wikipedia.org/wiki/E.164 - The format specifies which format the message will be sent as, SMS (text message) or TTS (text to speech). With TTS format, we will call the destination number and read out the message using a computer generated voice. - If specified the source number included in the request will be shown as the source number for the message, this feature is not enabled by default, please contact MessageMedia for more information. - If a source number is specified, the type of source number may also be specified. This is recommended when using a source address type that is not an internationally formatted number, available options are INTERNATIONAL, ALPHANUMERIC or SHORTCODE - The message will be scheduled to be delivered in the future if the scheduled parameter is specified. - A message expiry timestamp can be provided, if the message is not delivered by this time, it will be discarded. - Metadata can be included with the message. Up to 10 key value pair strings can be included with each message. This metadata will be available in delivery reports and replies.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messages">A list of messages to be sent</param>
        /// <returns>Task of SubmittedMessages</returns>
        System.Threading.Tasks.Task<SubmittedMessages> SendMessagesAsync (Messages messages);

        /// <summary>
        /// Send one or more messages
        /// </summary>
        /// <remarks>
        /// Submit one or more (up to 100 per request) SMS or text to voice messages to be sent to the destination address. - A callback URL can be included with each message to which MO and DR notifications will be pushed to via a HTTP POST request. - The content of the message can be a Unicode string, up to 5000 characters long - A delivery report can be be requested with the message which will be pushed to a HTTP endpoint if specified, or available via the Check Reports endpoint. - The destination number should be specified in E.164 international format. For information on E.164, please refer to http://en.wikipedia.org/wiki/E.164 - The format specifies which format the message will be sent as, SMS (text message) or TTS (text to speech). With TTS format, we will call the destination number and read out the message using a computer generated voice. - If specified the source number included in the request will be shown as the source number for the message, this feature is not enabled by default, please contact MessageMedia for more information. - If a source number is specified, the type of source number may also be specified. This is recommended when using a source address type that is not an internationally formatted number, available options are INTERNATIONAL, ALPHANUMERIC or SHORTCODE - The message will be scheduled to be delivered in the future if the scheduled parameter is specified. - A message expiry timestamp can be provided, if the message is not delivered by this time, it will be discarded. - Metadata can be included with the message. Up to 10 key value pair strings can be included with each message. This metadata will be available in delivery reports and replies.
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messages">A list of messages to be sent</param>
        /// <returns>Task of ApiResponse (SubmittedMessages)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubmittedMessages>> SendMessagesAsyncWithHttpInfo (Messages messages);
        /// <summary>
        /// Cancel a scheduled message
        /// </summary>
        /// <remarks>
        /// Cancel a scheduled message
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message to be updated</param>
        /// <param name="status">New status for the message</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateMessageStatusAsync (Guid? messageId, Status status);

        /// <summary>
        /// Cancel a scheduled message
        /// </summary>
        /// <remarks>
        /// Cancel a scheduled message
        /// </remarks>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message to be updated</param>
        /// <param name="status">New status for the message</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateMessageStatusAsyncWithHttpInfo (Guid? messageId, Status status);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MessagingApi : IMessagingApi
    {
        private MessageMedia.REST.API.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagingApi(String basePath)
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
        /// Initializes a new instance of the <see cref="MessagingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessagingApi(Configuration configuration = null)
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
        /// Get the status of a submitted message Get the status and details of a previously submitted message
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message that has been submitted</param>
        /// <returns>SubmittedMessage</returns>
        public SubmittedMessage GetMessageStatus (Guid? messageId)
        {
             ApiResponse<SubmittedMessage> localVarResponse = GetMessageStatusWithHttpInfo(messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of a submitted message Get the status and details of a previously submitted message
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message that has been submitted</param>
        /// <returns>ApiResponse of SubmittedMessage</returns>
        public ApiResponse< SubmittedMessage > GetMessageStatusWithHttpInfo (Guid? messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling MessagingApi->GetMessageStatus");

            var localVarPath = "/messages/{messageId}";
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
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

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
                Exception exception = ExceptionFactory("GetMessageStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubmittedMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmittedMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmittedMessage)));
            
        }

        /// <summary>
        /// Get the status of a submitted message Get the status and details of a previously submitted message
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message that has been submitted</param>
        /// <returns>Task of SubmittedMessage</returns>
        public async System.Threading.Tasks.Task<SubmittedMessage> GetMessageStatusAsync (Guid? messageId)
        {
             ApiResponse<SubmittedMessage> localVarResponse = await GetMessageStatusAsyncWithHttpInfo(messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the status of a submitted message Get the status and details of a previously submitted message
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message that has been submitted</param>
        /// <returns>Task of ApiResponse (SubmittedMessage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubmittedMessage>> GetMessageStatusAsyncWithHttpInfo (Guid? messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling MessagingApi->GetMessageStatus");

            var localVarPath = "/messages/{messageId}";
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
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter

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
                Exception exception = ExceptionFactory("GetMessageStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubmittedMessage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmittedMessage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmittedMessage)));
            
        }

        /// <summary>
        /// Send one or more messages Submit one or more (up to 100 per request) SMS or text to voice messages to be sent to the destination address. - A callback URL can be included with each message to which MO and DR notifications will be pushed to via a HTTP POST request. - The content of the message can be a Unicode string, up to 5000 characters long - A delivery report can be be requested with the message which will be pushed to a HTTP endpoint if specified, or available via the Check Reports endpoint. - The destination number should be specified in E.164 international format. For information on E.164, please refer to http://en.wikipedia.org/wiki/E.164 - The format specifies which format the message will be sent as, SMS (text message) or TTS (text to speech). With TTS format, we will call the destination number and read out the message using a computer generated voice. - If specified the source number included in the request will be shown as the source number for the message, this feature is not enabled by default, please contact MessageMedia for more information. - If a source number is specified, the type of source number may also be specified. This is recommended when using a source address type that is not an internationally formatted number, available options are INTERNATIONAL, ALPHANUMERIC or SHORTCODE - The message will be scheduled to be delivered in the future if the scheduled parameter is specified. - A message expiry timestamp can be provided, if the message is not delivered by this time, it will be discarded. - Metadata can be included with the message. Up to 10 key value pair strings can be included with each message. This metadata will be available in delivery reports and replies.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messages">A list of messages to be sent</param>
        /// <returns>SubmittedMessages</returns>
        public SubmittedMessages SendMessages (Messages messages)
        {
             ApiResponse<SubmittedMessages> localVarResponse = SendMessagesWithHttpInfo(messages);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send one or more messages Submit one or more (up to 100 per request) SMS or text to voice messages to be sent to the destination address. - A callback URL can be included with each message to which MO and DR notifications will be pushed to via a HTTP POST request. - The content of the message can be a Unicode string, up to 5000 characters long - A delivery report can be be requested with the message which will be pushed to a HTTP endpoint if specified, or available via the Check Reports endpoint. - The destination number should be specified in E.164 international format. For information on E.164, please refer to http://en.wikipedia.org/wiki/E.164 - The format specifies which format the message will be sent as, SMS (text message) or TTS (text to speech). With TTS format, we will call the destination number and read out the message using a computer generated voice. - If specified the source number included in the request will be shown as the source number for the message, this feature is not enabled by default, please contact MessageMedia for more information. - If a source number is specified, the type of source number may also be specified. This is recommended when using a source address type that is not an internationally formatted number, available options are INTERNATIONAL, ALPHANUMERIC or SHORTCODE - The message will be scheduled to be delivered in the future if the scheduled parameter is specified. - A message expiry timestamp can be provided, if the message is not delivered by this time, it will be discarded. - Metadata can be included with the message. Up to 10 key value pair strings can be included with each message. This metadata will be available in delivery reports and replies.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messages">A list of messages to be sent</param>
        /// <returns>ApiResponse of SubmittedMessages</returns>
        public ApiResponse< SubmittedMessages > SendMessagesWithHttpInfo (Messages messages)
        {
            // verify the required parameter 'messages' is set
            if (messages == null)
                throw new ApiException(400, "Missing required parameter 'messages' when calling MessagingApi->SendMessages");

            var localVarPath = "/messages";
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
            if (messages != null && messages.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(messages); // http body (model) parameter
            }
            else
            {
                localVarPostBody = messages; // byte array
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
                Exception exception = ExceptionFactory("SendMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubmittedMessages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmittedMessages) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmittedMessages)));
            
        }

        /// <summary>
        /// Send one or more messages Submit one or more (up to 100 per request) SMS or text to voice messages to be sent to the destination address. - A callback URL can be included with each message to which MO and DR notifications will be pushed to via a HTTP POST request. - The content of the message can be a Unicode string, up to 5000 characters long - A delivery report can be be requested with the message which will be pushed to a HTTP endpoint if specified, or available via the Check Reports endpoint. - The destination number should be specified in E.164 international format. For information on E.164, please refer to http://en.wikipedia.org/wiki/E.164 - The format specifies which format the message will be sent as, SMS (text message) or TTS (text to speech). With TTS format, we will call the destination number and read out the message using a computer generated voice. - If specified the source number included in the request will be shown as the source number for the message, this feature is not enabled by default, please contact MessageMedia for more information. - If a source number is specified, the type of source number may also be specified. This is recommended when using a source address type that is not an internationally formatted number, available options are INTERNATIONAL, ALPHANUMERIC or SHORTCODE - The message will be scheduled to be delivered in the future if the scheduled parameter is specified. - A message expiry timestamp can be provided, if the message is not delivered by this time, it will be discarded. - Metadata can be included with the message. Up to 10 key value pair strings can be included with each message. This metadata will be available in delivery reports and replies.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messages">A list of messages to be sent</param>
        /// <returns>Task of SubmittedMessages</returns>
        public async System.Threading.Tasks.Task<SubmittedMessages> SendMessagesAsync (Messages messages)
        {
             ApiResponse<SubmittedMessages> localVarResponse = await SendMessagesAsyncWithHttpInfo(messages);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send one or more messages Submit one or more (up to 100 per request) SMS or text to voice messages to be sent to the destination address. - A callback URL can be included with each message to which MO and DR notifications will be pushed to via a HTTP POST request. - The content of the message can be a Unicode string, up to 5000 characters long - A delivery report can be be requested with the message which will be pushed to a HTTP endpoint if specified, or available via the Check Reports endpoint. - The destination number should be specified in E.164 international format. For information on E.164, please refer to http://en.wikipedia.org/wiki/E.164 - The format specifies which format the message will be sent as, SMS (text message) or TTS (text to speech). With TTS format, we will call the destination number and read out the message using a computer generated voice. - If specified the source number included in the request will be shown as the source number for the message, this feature is not enabled by default, please contact MessageMedia for more information. - If a source number is specified, the type of source number may also be specified. This is recommended when using a source address type that is not an internationally formatted number, available options are INTERNATIONAL, ALPHANUMERIC or SHORTCODE - The message will be scheduled to be delivered in the future if the scheduled parameter is specified. - A message expiry timestamp can be provided, if the message is not delivered by this time, it will be discarded. - Metadata can be included with the message. Up to 10 key value pair strings can be included with each message. This metadata will be available in delivery reports and replies.
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messages">A list of messages to be sent</param>
        /// <returns>Task of ApiResponse (SubmittedMessages)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubmittedMessages>> SendMessagesAsyncWithHttpInfo (Messages messages)
        {
            // verify the required parameter 'messages' is set
            if (messages == null)
                throw new ApiException(400, "Missing required parameter 'messages' when calling MessagingApi->SendMessages");

            var localVarPath = "/messages";
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
            if (messages != null && messages.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(messages); // http body (model) parameter
            }
            else
            {
                localVarPostBody = messages; // byte array
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
                Exception exception = ExceptionFactory("SendMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SubmittedMessages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubmittedMessages) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubmittedMessages)));
            
        }

        /// <summary>
        /// Cancel a scheduled message Cancel a scheduled message
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message to be updated</param>
        /// <param name="status">New status for the message</param>
        /// <returns></returns>
        public void UpdateMessageStatus (Guid? messageId, Status status)
        {
             UpdateMessageStatusWithHttpInfo(messageId, status);
        }

        /// <summary>
        /// Cancel a scheduled message Cancel a scheduled message
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message to be updated</param>
        /// <param name="status">New status for the message</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateMessageStatusWithHttpInfo (Guid? messageId, Status status)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling MessagingApi->UpdateMessageStatus");
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling MessagingApi->UpdateMessageStatus");

            var localVarPath = "/messages/{messageId}";
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
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            if (status != null && status.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(status); // http body (model) parameter
            }
            else
            {
                localVarPostBody = status; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateMessageStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Cancel a scheduled message Cancel a scheduled message
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message to be updated</param>
        /// <param name="status">New status for the message</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateMessageStatusAsync (Guid? messageId, Status status)
        {
             await UpdateMessageStatusAsyncWithHttpInfo(messageId, status);

        }

        /// <summary>
        /// Cancel a scheduled message Cancel a scheduled message
        /// </summary>
        /// <exception cref="MessageMedia.REST.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">Unique ID representing message to be updated</param>
        /// <param name="status">New status for the message</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateMessageStatusAsyncWithHttpInfo (Guid? messageId, Status status)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling MessagingApi->UpdateMessageStatus");
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling MessagingApi->UpdateMessageStatus");

            var localVarPath = "/messages/{messageId}";
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
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            if (status != null && status.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(status); // http body (model) parameter
            }
            else
            {
                localVarPostBody = status; // byte array
            }

            // authentication (basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateMessageStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}

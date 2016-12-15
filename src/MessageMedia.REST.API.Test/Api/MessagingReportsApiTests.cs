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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using MessageMedia.REST.API.Client;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Model;

namespace MessageMedia.REST.API.Test
{
    /// <summary>
    ///  Class for testing MessagingReportsApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MessagingReportsApiTests
    {
        private MessagingReportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MessagingReportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MessagingReportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MessagingReportsApi
            //Assert.IsInstanceOfType(typeof(MessagingReportsApi), instance, "instance is a MessagingReportsApi");
        }

        
        /// <summary>
        /// Test GetDeliveryReportsDetail
        /// </summary>
        [Test]
        public void GetDeliveryReportsDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? endDate = null;
            //DateTime? startDate = null;
            //string account = null;
            //string destinationAddressCountry = null;
            //string destinationAddress = null;
            //string messageFormat = null;
            //string metadataKey = null;
            //string metadataValue = null;
            //string statusCode = null;
            //string status = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortBy = null;
            //string sortDirection = null;
            //string sourceAddressCountry = null;
            //string sourceAddress = null;
            //string timezone = null;
            //var response = instance.GetDeliveryReportsDetail(endDate, startDate, account, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
            //Assert.IsInstanceOf<DeliveryReports> (response, "response is DeliveryReports");
        }
        
        /// <summary>
        /// Test GetDeliveryReportsSummary
        /// </summary>
        [Test]
        public void GetDeliveryReportsSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? endDate = null;
            //string groupBy = null;
            //DateTime? startDate = null;
            //string account = null;
            //string destinationAddressCountry = null;
            //string destinationAddress = null;
            //string messageFormat = null;
            //string metadataKey = null;
            //string metadataValue = null;
            //string statusCode = null;
            //string status = null;
            //string summaryBy = null;
            //string summaryField = null;
            //string sourceAddressCountry = null;
            //string sourceAddress = null;
            //string timezone = null;
            //var response = instance.GetDeliveryReportsSummary(endDate, groupBy, startDate, account, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
            //Assert.IsInstanceOf<SummaryReport> (response, "response is SummaryReport");
        }
        
        /// <summary>
        /// Test GetReceivedMessagesDetail
        /// </summary>
        [Test]
        public void GetReceivedMessagesDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? endDate = null;
            //DateTime? startDate = null;
            //string account = null;
            //string action = null;
            //string destinationAddressCountry = null;
            //string destinationAddress = null;
            //string messageFormat = null;
            //string metadataKey = null;
            //string metadataValue = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortBy = null;
            //string sortDirection = null;
            //string sourceAddressCountry = null;
            //string sourceAddress = null;
            //string timezone = null;
            //var response = instance.GetReceivedMessagesDetail(endDate, startDate, account, action, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
            //Assert.IsInstanceOf<ReceivedMessages> (response, "response is ReceivedMessages");
        }
        
        /// <summary>
        /// Test GetReceivedMessagesSummary
        /// </summary>
        [Test]
        public void GetReceivedMessagesSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? endDate = null;
            //string groupBy = null;
            //DateTime? startDate = null;
            //string account = null;
            //string destinationAddressCountry = null;
            //string destinationAddress = null;
            //string messageFormat = null;
            //string metadataKey = null;
            //string metadataValue = null;
            //string summaryBy = null;
            //string summaryField = null;
            //string sourceAddressCountry = null;
            //string sourceAddress = null;
            //string timezone = null;
            //var response = instance.GetReceivedMessagesSummary(endDate, groupBy, startDate, account, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, summaryBy, summaryField, sourceAddressCountry, sourceAddress, timezone);
            //Assert.IsInstanceOf<SummaryReport> (response, "response is SummaryReport");
        }
        
        /// <summary>
        /// Test GetSentMessagesDetail
        /// </summary>
        [Test]
        public void GetSentMessagesDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? endDate = null;
            //DateTime? startDate = null;
            //string account = null;
            //bool? deliveryReport = null;
            //string destinationAddressCountry = null;
            //string destinationAddress = null;
            //string messageFormat = null;
            //string metadataKey = null;
            //string metadataValue = null;
            //string statusCode = null;
            //string status = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortBy = null;
            //string sortDirection = null;
            //string sourceAddressCountry = null;
            //string sourceAddress = null;
            //string timezone = null;
            //var response = instance.GetSentMessagesDetail(endDate, startDate, account, deliveryReport, destinationAddressCountry, destinationAddress, messageFormat, metadataKey, metadataValue, statusCode, status, page, pageSize, sortBy, sortDirection, sourceAddressCountry, sourceAddress, timezone);
            //Assert.IsInstanceOf<SentMessages> (response, "response is SentMessages");
        }
        
        /// <summary>
        /// Test GetSentMessagesSummary
        /// </summary>
        [Test]
        public void GetSentMessagesSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? endDate = null;
            //string groupBy = null;
            //DateTime? startDate = null;
            //string account = null;
            //bool? deliveryReport = null;
            //string destinationAddressCountry = null;
            //string destinationAddress = null;
            //string summaryBy = null;
            //string summaryField = null;
            //string messageFormat = null;
            //string metadataKey = null;
            //string metadataValue = null;
            //string statusCode = null;
            //string sourceAddressCountry = null;
            //string sourceAddress = null;
            //string timezone = null;
            //var response = instance.GetSentMessagesSummary(endDate, groupBy, startDate, account, deliveryReport, destinationAddressCountry, destinationAddress, summaryBy, summaryField, messageFormat, metadataKey, metadataValue, statusCode, sourceAddressCountry, sourceAddress, timezone);
            //Assert.IsInstanceOf<SummaryReport> (response, "response is SummaryReport");
        }
        
    }

}

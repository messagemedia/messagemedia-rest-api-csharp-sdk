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
    ///  Class for testing DeliveryReportsApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DeliveryReportsApiTests
    {
        private DeliveryReportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DeliveryReportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DeliveryReportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DeliveryReportsApi
            //Assert.IsInstanceOfType(typeof(DeliveryReportsApi), instance, "instance is a DeliveryReportsApi");
        }

        
        /// <summary>
        /// Test CheckReports
        /// </summary>
        [Test]
        public void CheckReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CheckReports();
            //Assert.IsInstanceOf<Reports> (response, "response is Reports");
        }
        
        /// <summary>
        /// Test ConfirmReports
        /// </summary>
        [Test]
        public void ConfirmReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeliveryReportId deliveryReportId = null;
            //instance.ConfirmReports(deliveryReportId);
            
        }
        
    }

}

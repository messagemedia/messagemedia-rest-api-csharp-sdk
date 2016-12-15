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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using MessageMedia.REST.API.Api;
using MessageMedia.REST.API.Model;
using MessageMedia.REST.API.Client;
using System.Reflection;

namespace MessageMedia.REST.API.Test
{
    /// <summary>
    ///  Class for testing ReceivedMessages
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ReceivedMessagesTests
    {
        // TODO uncomment below to declare an instance variable for ReceivedMessages
        //private ReceivedMessages instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ReceivedMessages
            //instance = new ReceivedMessages();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReceivedMessages
        /// </summary>
        [Test]
        public void ReceivedMessagesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ReceivedMessages
            //Assert.IsInstanceOfType<ReceivedMessages> (instance, "variable 'instance' is a ReceivedMessages");
        }

        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }
        /// <summary>
        /// Test the property 'Pagination'
        /// </summary>
        [Test]
        public void PaginationTest()
        {
            // TODO unit test for the property 'Pagination'
        }
        /// <summary>
        /// Test the property 'Properties'
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            // TODO unit test for the property 'Properties'
        }

    }

}

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
    ///  Class for testing MessagingApi
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MessagingApiTests
    {
        private MessagingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MessagingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MessagingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MessagingApi
            //Assert.IsInstanceOfType(typeof(MessagingApi), instance, "instance is a MessagingApi");
        }

        
        /// <summary>
        /// Test GetMessageStatus
        /// </summary>
        [Test]
        public void GetMessageStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? messageId = null;
            //var response = instance.GetMessageStatus(messageId);
            //Assert.IsInstanceOf<SubmittedMessage> (response, "response is SubmittedMessage");
        }
        
        /// <summary>
        /// Test SendMessages
        /// </summary>
        [Test]
        public void SendMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Messages messages = null;
            //var response = instance.SendMessages(messages);
            //Assert.IsInstanceOf<SubmittedMessages> (response, "response is SubmittedMessages");
        }
        
        /// <summary>
        /// Test UpdateMessageStatus
        /// </summary>
        [Test]
        public void UpdateMessageStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? messageId = null;
            //Status status = null;
            //instance.UpdateMessageStatus(messageId, status);
            
        }
        
    }

}

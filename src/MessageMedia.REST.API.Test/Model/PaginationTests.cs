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
    ///  Class for testing Pagination
    /// </summary>
    /// <remarks>
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PaginationTests
    {
        // TODO uncomment below to declare an instance variable for Pagination
        //private Pagination instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Pagination
            //instance = new Pagination();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Pagination
        /// </summary>
        [Test]
        public void PaginationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Pagination
            //Assert.IsInstanceOfType<Pagination> (instance, "variable 'instance' is a Pagination");
        }

        /// <summary>
        /// Test the property 'Page'
        /// </summary>
        [Test]
        public void PageTest()
        {
            // TODO unit test for the property 'Page'
        }
        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Test]
        public void PageSizeTest()
        {
            // TODO unit test for the property 'PageSize'
        }
        /// <summary>
        /// Test the property 'TotalCount'
        /// </summary>
        [Test]
        public void TotalCountTest()
        {
            // TODO unit test for the property 'TotalCount'
        }
        /// <summary>
        /// Test the property 'PageCount'
        /// </summary>
        [Test]
        public void PageCountTest()
        {
            // TODO unit test for the property 'PageCount'
        }
        /// <summary>
        /// Test the property 'NextUri'
        /// </summary>
        [Test]
        public void NextUriTest()
        {
            // TODO unit test for the property 'NextUri'
        }
        /// <summary>
        /// Test the property 'PreviousUri'
        /// </summary>
        [Test]
        public void PreviousUriTest()
        {
            // TODO unit test for the property 'PreviousUri'
        }

    }

}

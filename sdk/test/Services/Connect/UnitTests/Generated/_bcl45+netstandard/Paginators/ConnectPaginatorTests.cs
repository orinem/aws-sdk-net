#if !NETSTANDARD13
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */

using Amazon.Connect;
using Amazon.Connect.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ConnectPaginatorTests
    {
        private static Mock<AmazonConnectClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonConnectClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void GetCurrentMetricDataTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCurrentMetricDataRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCurrentMetricDataResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCurrentMetricDataResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCurrentMetricData(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCurrentMetricData(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCurrentMetricDataTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCurrentMetricDataRequest>();

            var response = InstantiateClassGenerator.Execute<GetCurrentMetricDataResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCurrentMetricData(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCurrentMetricData(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void GetMetricDataTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetMetricDataRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetMetricDataResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetMetricDataResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetMetricData(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetMetricData(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetMetricDataTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetMetricDataRequest>();

            var response = InstantiateClassGenerator.Execute<GetMetricDataResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetMetricData(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetMetricData(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListContactFlowsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContactFlowsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContactFlowsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContactFlowsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContactFlows(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContactFlows(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContactFlowsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContactFlowsRequest>();

            var response = InstantiateClassGenerator.Execute<ListContactFlowsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContactFlows(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContactFlows(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListHoursOfOperationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHoursOfOperationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHoursOfOperationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHoursOfOperationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHoursOfOperations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHoursOfOperations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHoursOfOperationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHoursOfOperationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListHoursOfOperationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHoursOfOperations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHoursOfOperations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListPhoneNumbersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPhoneNumbersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPhoneNumbersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPhoneNumbers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumbers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPhoneNumbersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersRequest>();

            var response = InstantiateClassGenerator.Execute<ListPhoneNumbersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPhoneNumbers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumbers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListQueuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListQueuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListQueues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListQueues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListQueuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListQueuesRequest>();

            var response = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListQueues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListQueues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListRoutingProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutingProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRoutingProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRoutingProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRoutingProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoutingProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRoutingProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutingProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRoutingProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRoutingProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoutingProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListSecurityProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSecurityProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSecurityProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSecurityProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSecurityProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSecurityProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSecurityProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSecurityProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSecurityProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListUserHierarchyGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUserHierarchyGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUserHierarchyGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUserHierarchyGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUserHierarchyGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUserHierarchyGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var response = InstantiateClassGenerator.Execute<ListUsersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif
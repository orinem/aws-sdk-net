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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Snowball.Model;

namespace Amazon.Snowball
{
    /// <summary>
    /// Interface for accessing Snowball
    ///
    /// AWS Snowball is a petabyte-scale data transport solution that uses secure devices
    /// to transfer large amounts of data between your on-premises data centers and Amazon
    /// Simple Storage Service (Amazon S3). The Snowball commands described here provide access
    /// to the same functionality that is available in the AWS Snowball Management Console,
    /// which enables you to create and manage jobs for Snowball. To transfer data locally
    /// with a Snowball device, you'll need to use the Snowball client or the Amazon S3 API
    /// adapter for Snowball. For more information, see the <a href="https://docs.aws.amazon.com/AWSImportExport/latest/ug/api-reference.html">User
    /// Guide</a>.
    /// </summary>
    public partial interface IAmazonSnowball : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISnowballPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelCluster



        /// <summary>
        /// Cancels a cluster job. You can only cancel a cluster job while it's in the <code>AwaitingQuorum</code>
        /// status. You'll have at least an hour after creating a cluster job to cancel it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCluster service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided AWS Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CancelCluster">REST API Reference for CancelCluster Operation</seealso>
        Task<CancelClusterResponse> CancelClusterAsync(CancelClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelJob



        /// <summary>
        /// Cancels the specified job. You can only cancel a job before its <code>JobState</code>
        /// value changes to <code>PreparingAppliance</code>. Requesting the <code>ListJobs</code>
        /// or <code>DescribeJob</code> action returns a job's <code>JobState</code> as part of
        /// the response element data returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided AWS Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CancelJob">REST API Reference for CancelJob Operation</seealso>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAddress



        /// <summary>
        /// Creates an address for a Snowball to be shipped to. In most regions, addresses are
        /// validated at the time of creation. The address you provide must be located within
        /// the serviceable area of your region. If the address is invalid or unsupported, then
        /// an exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAddress service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidAddressException">
        /// The address provided was invalid. Check the address with your region's carrier, and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.UnsupportedAddressException">
        /// The address is either outside the serviceable area for your region, or an error occurred.
        /// Check the address with your region's carrier and try again. If the issue persists,
        /// contact AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateAddress">REST API Reference for CreateAddress Operation</seealso>
        Task<CreateAddressResponse> CreateAddressAsync(CreateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCluster



        /// <summary>
        /// Creates an empty cluster. Each cluster supports five nodes. You use the <a>CreateJob</a>
        /// action separately to create the jobs for each of these nodes. The cluster does not
        /// ship until these five node jobs have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidInputCombinationException">
        /// Job or cluster creation failed. One or more inputs were invalid. Confirm that the
        /// <a>CreateClusterRequest$SnowballType</a> value supports your <a>CreateJobRequest$JobType</a>,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided AWS Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateJob



        /// <summary>
        /// Creates a job to import or export data between Amazon S3 and your on-premises data
        /// center. Your AWS account must have the right trust policies and permissions in place
        /// to create a job for Snowball. If you're creating a job for a node in a cluster, you
        /// only need to provide the <code>clusterId</code> value; the other job attributes are
        /// inherited from the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.ClusterLimitExceededException">
        /// Job creation failed. Currently, clusters support five nodes. If you have less than
        /// five nodes for your cluster and you have more nodes to create for this cluster, try
        /// again and create jobs until your cluster has exactly five notes.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidInputCombinationException">
        /// Job or cluster creation failed. One or more inputs were invalid. Confirm that the
        /// <a>CreateClusterRequest$SnowballType</a> value supports your <a>CreateJobRequest$JobType</a>,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided AWS Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/CreateJob">REST API Reference for CreateJob Operation</seealso>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAddress



        /// <summary>
        /// Takes an <code>AddressId</code> and returns specific details about that address in
        /// the form of an <code>Address</code> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddress service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeAddress">REST API Reference for DescribeAddress Operation</seealso>
        Task<DescribeAddressResponse> DescribeAddressAsync(DescribeAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAddresses



        /// <summary>
        /// Returns a specified number of <code>ADDRESS</code> objects. Calling this API in one
        /// of the US regions will return addresses from the list of all addresses associated
        /// with this account in all US regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCluster



        /// <summary>
        /// Returns information about a specific cluster including shipping information, cluster
        /// status, and other important metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeJob



        /// <summary>
        /// Returns information about a specific job including shipping information, job status,
        /// and other important metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJobManifest



        /// <summary>
        /// Returns a link to an Amazon S3 presigned URL for the manifest file associated with
        /// the specified <code>JobId</code> value. You can access the manifest file for up to
        /// 60 minutes after this request has been made. To access the manifest file after 60
        /// minutes have passed, you'll have to make another call to the <code>GetJobManifest</code>
        /// action.
        /// 
        ///  
        /// <para>
        /// The manifest is an encrypted file that you can download after your job enters the
        /// <code>WithCustomer</code> status. The manifest is decrypted by using the <code>UnlockCode</code>
        /// code value, when you pass both values to the Snowball through the Snowball client
        /// when the client is started for the first time.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, we recommend that you don't save a copy of an <code>UnlockCode</code>
        /// value in the same location as the manifest file for that job. Saving these separately
        /// helps prevent unauthorized parties from gaining access to the Snowball associated
        /// with that job.
        /// </para>
        ///  
        /// <para>
        /// The credentials of a given job, including its manifest file and unlock code, expire
        /// 90 days after the job is created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobManifest service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetJobManifest">REST API Reference for GetJobManifest Operation</seealso>
        Task<GetJobManifestResponse> GetJobManifestAsync(GetJobManifestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJobUnlockCode



        /// <summary>
        /// Returns the <code>UnlockCode</code> code value for the specified job. A particular
        /// <code>UnlockCode</code> value can be accessed for up to 90 days after the associated
        /// job has been created.
        /// 
        ///  
        /// <para>
        /// The <code>UnlockCode</code> value is a 29-character code with 25 alphanumeric characters
        /// and 4 hyphens. This code is used to decrypt the manifest file when it is passed along
        /// with the manifest to the Snowball through the Snowball client when the client is started
        /// for the first time.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, we recommend that you don't save a copy of the <code>UnlockCode</code>
        /// in the same location as the manifest file for that job. Saving these separately helps
        /// prevent unauthorized parties from gaining access to the Snowball associated with that
        /// job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobUnlockCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobUnlockCode service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetJobUnlockCode">REST API Reference for GetJobUnlockCode Operation</seealso>
        Task<GetJobUnlockCodeResponse> GetJobUnlockCodeAsync(GetJobUnlockCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSnowballUsage



        /// <summary>
        /// Returns information about the Snowball service limit for your account, and also the
        /// number of Snowballs your account has in use.
        /// 
        ///  
        /// <para>
        /// The default service limit for the number of Snowballs that you can have at one time
        /// is 1. If you want to increase your service limit, contact AWS Support.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnowballUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnowballUsage service method, as returned by Snowball.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetSnowballUsage">REST API Reference for GetSnowballUsage Operation</seealso>
        Task<GetSnowballUsageResponse> GetSnowballUsageAsync(GetSnowballUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSoftwareUpdates



        /// <summary>
        /// Returns an Amazon S3 presigned URL for an update file associated with a specified
        /// <code>JobId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSoftwareUpdates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSoftwareUpdates service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/GetSoftwareUpdates">REST API Reference for GetSoftwareUpdates Operation</seealso>
        Task<GetSoftwareUpdatesResponse> GetSoftwareUpdatesAsync(GetSoftwareUpdatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListClusterJobs



        /// <summary>
        /// Returns an array of <code>JobListEntry</code> objects of the specified length. Each
        /// <code>JobListEntry</code> object is for a job in the specified cluster and contains
        /// a job's state, a job's ID, and other information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusterJobs service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListClusterJobs">REST API Reference for ListClusterJobs Operation</seealso>
        Task<ListClusterJobsResponse> ListClusterJobsAsync(ListClusterJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListClusters



        /// <summary>
        /// Returns an array of <code>ClusterListEntry</code> objects of the specified length.
        /// Each <code>ClusterListEntry</code> object contains a cluster's state, a cluster's
        /// ID, and other important status information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListClusters">REST API Reference for ListClusters Operation</seealso>
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCompatibleImages



        /// <summary>
        /// This action returns a list of the different Amazon EC2 Amazon Machine Images (AMIs)
        /// that are owned by your AWS account that would be supported for use on a Snowball Edge
        /// device. Currently, supported AMIs are based on the CentOS 7 (x86_64) - with Updates
        /// HVM, Ubuntu Server 14.04 LTS (HVM), and Ubuntu 16.04 LTS - Xenial (HVM) images, available
        /// on the AWS Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompatibleImages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCompatibleImages service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListCompatibleImages">REST API Reference for ListCompatibleImages Operation</seealso>
        Task<ListCompatibleImagesResponse> ListCompatibleImagesAsync(ListCompatibleImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJobs



        /// <summary>
        /// Returns an array of <code>JobListEntry</code> objects of the specified length. Each
        /// <code>JobListEntry</code> object contains a job's state, a job's ID, and a value that
        /// indicates whether the job is a job part, in the case of export jobs. Calling this
        /// API action in one of the US regions will return jobs from the list of all jobs associated
        /// with this account in all US regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> string was altered unexpectedly, and the operation has
        /// stopped. Run the operation without changing the <code>NextToken</code> string, and
        /// try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/ListJobs">REST API Reference for ListJobs Operation</seealso>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCluster



        /// <summary>
        /// While a cluster's <code>ClusterState</code> value is in the <code>AwaitingQuorum</code>
        /// state, you can update some of the information associated with a cluster. Once the
        /// cluster changes to a different job state, usually 60 minutes after the cluster being
        /// created, this action is no longer available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidInputCombinationException">
        /// Job or cluster creation failed. One or more inputs were invalid. Confirm that the
        /// <a>CreateClusterRequest$SnowballType</a> value supports your <a>CreateJobRequest$JobType</a>,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided AWS Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateJob



        /// <summary>
        /// While a job's <code>JobState</code> value is <code>New</code>, you can update some
        /// of the information associated with a job. Once the job changes to a different job
        /// state, usually within 60 minutes of the job being created, this action is no longer
        /// available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by Snowball.</returns>
        /// <exception cref="Amazon.Snowball.Model.ClusterLimitExceededException">
        /// Job creation failed. Currently, clusters support five nodes. If you have less than
        /// five nodes for your cluster and you have more nodes to create for this cluster, try
        /// again and create jobs until your cluster has exactly five notes.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.Ec2RequestFailedException">
        /// Your IAM user lacks the necessary Amazon EC2 permissions to perform the attempted
        /// action.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidInputCombinationException">
        /// Job or cluster creation failed. One or more inputs were invalid. Confirm that the
        /// <a>CreateClusterRequest$SnowballType</a> value supports your <a>CreateJobRequest$JobType</a>,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidJobStateException">
        /// The action can't be performed because the job's current state doesn't allow that action
        /// to be performed.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.InvalidResourceException">
        /// The specified resource can't be found. Check the information you provided in your
        /// last request, and try again.
        /// </exception>
        /// <exception cref="Amazon.Snowball.Model.KMSRequestFailedException">
        /// The provided AWS Key Management Service key lacks the permissions to perform the specified
        /// <a>CreateJob</a> or <a>UpdateJob</a> action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snowball-2016-06-30/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}
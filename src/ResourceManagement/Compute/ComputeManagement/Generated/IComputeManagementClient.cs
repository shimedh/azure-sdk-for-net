// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;

namespace Microsoft.Azure.Management.Compute
{
    /// <summary>
    /// The Compute Management Client.
    /// </summary>
    public partial interface IComputeManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Operations for managing the availability sets in compute management.
        /// </summary>
        IAvailabilitySetOperations AvailabilitySets
        {
            get; 
        }
        
        /// <summary>
        /// Operations for listing usage.
        /// </summary>
        IUsageOperations Usage
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing the virtual machine extension images in
        /// compute management.
        /// </summary>
        IVirtualMachineExtensionImageOperations VirtualMachineExtensionImages
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing the virtual machine extensions in compute
        /// management.
        /// </summary>
        IVirtualMachineExtensionOperations VirtualMachineExtensions
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing the virtual machine images in compute
        /// management.
        /// </summary>
        IVirtualMachineImageOperations VirtualMachineImages
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing the virtual machines in compute management.
        /// </summary>
        IVirtualMachineOperations VirtualMachines
        {
            get; 
        }
        
        /// <summary>
        /// Operations for listing virtual machine sizes available in a region.
        /// </summary>
        IVirtualMachineSizeOperations VirtualMachineSizes
        {
            get; 
        }
        
        /// <summary>
        /// The Get Delete Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call GetDeleteOperationStatus to determine whether the
        /// operation has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The compute long running operation response.
        /// </returns>
        Task<DeleteOperationResponse> GetDeleteOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call GetLongRunningOperationStatus to determine whether the
        /// operation has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Compute service response for long-running operations.
        /// </returns>
        Task<ComputeLongRunningOperationResponse> GetLongRunningOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
    }
}
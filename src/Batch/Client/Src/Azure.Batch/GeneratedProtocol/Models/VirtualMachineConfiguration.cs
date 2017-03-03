// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// The configuration for compute nodes in a pool based on the Azure
    /// Virtual Machines infrastructure.
    /// </summary>
    public partial class VirtualMachineConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineConfiguration
        /// class.
        /// </summary>
        public VirtualMachineConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineConfiguration
        /// class.
        /// </summary>
        /// <param name="nodeAgentSKUId">The SKU of the Batch node agent to be
        /// provisioned on compute nodes in the pool.</param>
        /// <param name="imageReference">A reference to the Azure Virtual
        /// Machines Marketplace image to use.</param>
        /// <param name="osDisk">A reference to the OS disk image to
        /// use.</param>
        /// <param name="windowsConfiguration">Windows operating system
        /// settings on the virtual machine.</param>
        public VirtualMachineConfiguration(string nodeAgentSKUId, ImageReference imageReference = default(ImageReference), OSDisk osDisk = default(OSDisk), WindowsConfiguration windowsConfiguration = default(WindowsConfiguration))
        {
            ImageReference = imageReference;
            OsDisk = osDisk;
            NodeAgentSKUId = nodeAgentSKUId;
            WindowsConfiguration = windowsConfiguration;
        }

        /// <summary>
        /// Gets or sets a reference to the Azure Virtual Machines Marketplace
        /// image to use.
        /// </summary>
        /// <remarks>
        /// This property and osDisk are mutually exclusive and one of the
        /// properties must be specified.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "imageReference")]
        public ImageReference ImageReference { get; set; }

        /// <summary>
        /// Gets or sets a reference to the OS disk image to use.
        /// </summary>
        /// <remarks>
        /// This property can be specified only if the Batch account was
        /// created with its poolAllocationMode property set to
        /// 'UserSubscription'. This property and imageReference are mutually
        /// exclusive and one of the properties must be specified.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "osDisk")]
        public OSDisk OsDisk { get; set; }

        /// <summary>
        /// Gets or sets the SKU of the Batch node agent to be provisioned on
        /// compute nodes in the pool.
        /// </summary>
        /// <remarks>
        /// The Batch node agent is a program that runs on each node in the
        /// pool, and provides the command-and-control interface between the
        /// node and the Batch service. There are different implementations of
        /// the node agent, known as SKUs, for different operating systems. You
        /// must specify a node agent SKU which matches the selected image
        /// reference. To get the list of supported node agent SKUs along with
        /// their list of verified image references, see the 'List supported
        /// node agent SKUs' operation.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nodeAgentSKUId")]
        public string NodeAgentSKUId { get; set; }

        /// <summary>
        /// Gets or sets windows operating system settings on the virtual
        /// machine.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if the imageReference or osDisk
        /// property specifies a Linux OS image.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NodeAgentSKUId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "NodeAgentSKUId");
            }
            if (this.ImageReference != null)
            {
                this.ImageReference.Validate();
            }
            if (this.OsDisk != null)
            {
                this.OsDisk.Validate();
            }
        }
    }
}
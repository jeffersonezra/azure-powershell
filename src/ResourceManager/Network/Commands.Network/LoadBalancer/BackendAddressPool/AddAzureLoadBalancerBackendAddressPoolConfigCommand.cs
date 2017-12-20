﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Network.Models;
using System;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.Add, "AzureRmLoadBalancerBackendAddressPoolConfig"), OutputType(typeof(PSLoadBalancer))]
    public class AddAzureLoadBalancerBackendAddressPoolConfigCommand : AzureLoadBalancerBackendAddressPoolConfigBase
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The name of the BackendAddressPool")]
        [ValidateNotNullOrEmpty]
        public override string Name { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The load balancer")]
        public PSLoadBalancer LoadBalancer { get; set; }

        public override void Execute()
        {

            base.Execute();
            var existingbackendAddressPool = this.LoadBalancer.BackendAddressPools.SingleOrDefault(resource => string.Equals(resource.Name, this.Name, System.StringComparison.CurrentCultureIgnoreCase));

            if (existingbackendAddressPool != null)
            {
                throw new ArgumentException("BackendAddressPool with the specified name already exists");
            }

            var backendAddressPool = new PSBackendAddressPool();
            backendAddressPool.Name = this.Name;

            backendAddressPool.Id =
                ChildResourceHelper.GetResourceId(
                    this.NetworkClient.NetworkManagementClient.SubscriptionId,
                    this.LoadBalancer.ResourceGroupName,
                    this.LoadBalancer.Name,
                    Microsoft.Azure.Commands.Network.Properties.Resources.LoadBalancerBackendAddressPoolName,
                    this.Name);

            this.LoadBalancer.BackendAddressPools.Add(backendAddressPool);

            WriteObject(this.LoadBalancer);
        }
    }
}

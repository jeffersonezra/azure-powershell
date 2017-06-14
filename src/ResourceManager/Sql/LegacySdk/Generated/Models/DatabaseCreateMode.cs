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

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Defines the valid create modes of Azure SQL Databases. See MSDN for
    /// more information.
    /// </summary>
    public static partial class DatabaseCreateMode
    {
        /// <summary>
        /// Regular database creation.
        /// </summary>
        public const string Default = "Default";
        
        /// <summary>
        /// Create database as a one-time copy.
        /// </summary>
        public const string Copy = "Copy";
        
        /// <summary>
        /// Create database as a readable geo-secondary.
        /// </summary>
        public const string Secondary = "Secondary";
        
        /// <summary>
        /// Create database as non-readable geo-secondary.
        /// </summary>
        public const string NonReadableSecondary = "NonReadableSecondary";
        
        /// <summary>
        /// Database created as restore target where source is another live
        /// database
        /// </summary>
        public const string PointInTimeRestore = "PointInTimeRestore";
        
        /// <summary>
        /// Database created as restore target where source is a deleted
        /// database
        /// </summary>
        public const string Restore = "Restore";
        
        /// <summary>
        /// Database created by restoring the backups of another database from
        /// XStore
        /// </summary>
        public const string Recovery = "Recovery";
        
        /// <summary>
        /// Database created by restoring an external backup
        /// </summary>
        public const string RestoreExternalBackup = "RestoreExternalBackup";
        
        /// <summary>
        /// Database created by restoring an archived backup
        /// </summary>
        public const string RestoreArchivedBackup = "RestoreArchivedBackup";
    }
}

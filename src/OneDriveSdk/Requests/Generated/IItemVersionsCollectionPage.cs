// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;

    using Microsoft.Graph;
    using Newtonsoft.Json;

    /// <summary>
    /// The interface IItemVersionsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<ItemVersionsCollectionPage>))]
    public interface IItemVersionsCollectionPage : ICollectionPage<Item>
    {
        /// <summary>
        /// Gets the next page <see cref="IItemVersionsCollectionRequest"/> instance.
        /// </summary>
        IItemVersionsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}

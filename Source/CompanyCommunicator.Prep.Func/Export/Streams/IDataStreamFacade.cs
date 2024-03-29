﻿// <copyright file="IDataStreamFacade.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Prep.Func.Export.Streams
{
    using System.Collections.Generic;
    using Microsoft.Teams.Apps.CompanyCommunicator.Prep.Func.Export.Model;

    /// <summary>
    /// Facade to get the data stream.
    /// </summary>
    public interface IDataStreamFacade
    {
        /// <summary>
        /// get the users data streams.
        /// </summary>
        /// <param name="notificationId">the notification id.</param>
        /// <returns>the streams of user data.</returns>
        IAsyncEnumerable<IEnumerable<UserData>> GetUserDataStreamAsync(string notificationId);

        /// <summary>
        /// get the team data streams.
        /// </summary>
        /// <param name="notificationId">the notification id.</param>
        /// <returns>the streams of team data.</returns>
        IAsyncEnumerable<IEnumerable<TeamData>> GetTeamDataStreamAsync(string notificationId);

        /// <summary>
        /// get the reaction data streams.
        /// </summary>
        /// <param name="notificationId">the notification id.</param>
        /// <returns>the streams of reaction data.</returns>
        IAsyncEnumerable<IEnumerable<ReactionData>> GetReactionDataStreamAsync(string notificationId);
    }
}

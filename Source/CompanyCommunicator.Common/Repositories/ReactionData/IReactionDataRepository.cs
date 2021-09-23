// <copyright file="IReactionDataRepository.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// </copyright>
namespace Microsoft.Teams.Apps.CompanyCommunicator.Common.Repositories.ReactionData
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for Reaction Data Repository.
    /// </summary>
    public interface IReactionDataRepository : IRepository<ReactionDataEntity>
    {
        /// <summary>
        /// Gets reaction data entities by ID values.
        /// </summary>
        /// <param name="reactionIds">Reaction IDs.</param>
        /// <returns>Reaction data entities.</returns>
        public Task<IEnumerable<ReactionDataEntity>> GetReactionDataEntitiesByIdsAsync(IEnumerable<string> reactionIds);

        /// <summary>
        /// Get reaction names by Ids.
        /// </summary>
        /// <param name="ids">Reaction ids.</param>
        /// <returns>Names of the reactions matching incoming ids.</returns>
        public Task<IEnumerable<string>> GetReactionNamesByIdsAsync(IEnumerable<string> ids);

        /// <summary>
        /// Get all reaction data entities, and sort the result alphabetically by name.
        /// </summary>
        /// <returns>The reaction data entities sorted alphabetically by name.</returns>
        public Task<IEnumerable<ReactionDataEntity>> GetAllSortedAlphabeticallyByNameAsync();
    }
}

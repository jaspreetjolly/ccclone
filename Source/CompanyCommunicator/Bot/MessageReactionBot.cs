// <copyright file="Reaction.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Bot
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Bot.Builder;
    using Microsoft.Bot.Builder.Teams;
    using Microsoft.Bot.Schema;
    using Microsoft.Teams.Apps.CompanyCommunicator.Common.Repositories.ReactionData;
    using Microsoft.Teams.Apps.CompanyCommunicator.Repositories.Extensions;

    /// <inheritdoc/>
    public class MessageReactionBot : ActivityHandler
    {
        private readonly IReactionDataRepository reactionDataRepository;

        /// <inheritdoc/>
        public MessageReactionBot(IReactionDataRepository reactionDataRepository)
        {
            this.reactionDataRepository = reactionDataRepository ?? throw new ArgumentNullException(nameof(reactionDataRepository));
        }

        /// <inheritdoc/>
        protected override async Task OnMessageReactionActivityAsync(ITurnContext<IMessageReactionActivity> turnContext, CancellationToken cancellationToken)
        {
            System.Diagnostics.Trace.TraceError("If you're seeing this, something bad happened");
            if (turnContext.Activity.ReactionsRemoved != null && turnContext.Activity.ReactionsAdded != null)
            {
                await this.OnReactionsChangedAsync(turnContext.Activity.ReactionsRemoved, turnContext.Activity.ReactionsAdded, turnContext, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                if (turnContext.Activity.ReactionsAdded != null)
                {
                    await this.reactionDataRepository.SaveReactionDataAsync("",turnContext.Activity);
                }

                if (turnContext.Activity.ReactionsRemoved != null)
                {
                    await this.reactionDataRepository.RemoveReactionDataAsync("",turnContext.Activity);
                }
            }
        }

        private Task OnReactionsChangedAsync(IList<MessageReaction> reactionsRemoved, IList<MessageReaction> reactionsAdded, ITurnContext<IMessageReactionActivity> turnContext, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evently.Common.Application.EventBus;
public abstract class IntegrationEvent(Guid id, DateTime occurredOnUtc) : IIntegrationEvent
{
    public Guid Id { get; init; } = id;

    public DateTime OccurredOnUtc { get; init; } = occurredOnUtc;
}

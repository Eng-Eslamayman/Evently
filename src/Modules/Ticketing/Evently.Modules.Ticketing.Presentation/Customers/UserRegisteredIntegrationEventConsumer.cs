using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Evently.Common.Application.Exceptions;
using Evently.Common.Domain;
using Evently.Modules.Ticketing.Application.Customers.CreateCustomer;
using Evently.Modules.Ticketing.Domain.Customers;
using Evently.Modules.Users.IntegrationEvents;
using MassTransit;
using MediatR;

namespace Evently.Modules.Ticketing.Presentation.Customers;
public sealed class UserRegisteredIntegrationEventConsumer(ISender sender) : IConsumer<UserRegisteredIntegrationEvent>
{
    public async Task Consume(ConsumeContext<UserRegisteredIntegrationEvent> context)
    {
        Result result = await sender.Send(
            new CreateCustomerCommand(context.Message.UserId,
                context.Message.Email,
                context.Message.FirstName,
                context.Message.LastName));

        if (result.IsFailure)
        {
            throw new EventlyException(nameof(CreateCustomerCommand), result.Error);
        }
    }
}

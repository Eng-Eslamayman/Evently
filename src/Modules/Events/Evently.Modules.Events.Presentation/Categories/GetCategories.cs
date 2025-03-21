﻿using Evently.Common.Application.Caching;
using Evently.Common.Domain;
using Evently.Common.Presentation.Endpoints;
using Evently.Common.Presentation.Results;
using Evently.Modules.Events.Application.Categories.GetCategories;
using Evently.Modules.Events.Application.Categories.GetCategory;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Presentation.Categories;

internal sealed class GetCategories : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("categories", async (ISender sender, ICacheService cacheService) =>
            {
                IReadOnlyCollection<CategoryResponse>? category =
                    await cacheService.GetAsync<IReadOnlyCollection<CategoryResponse>>("categories");

                if (category is not null)
                {
                    return Results.Ok(category);
                }

                Result<IReadOnlyCollection<CategoryResponse>> result = await sender.Send(new GetCategoriesQuery());

                if (result.IsSuccess)
                {
                    await cacheService.SetAsync("categories", result.Value);
                }

                return result.Match(Results.Ok, ApiResults.Problem);
            })
        .WithTags(Tags.Categories);
    }
}

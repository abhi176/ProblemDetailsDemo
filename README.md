# ProblemDetailsDemo [![Build Status](https://dev.azure.com/christianacca/ProblemDetailsDemo/_apis/build/status/ProblemDetailsDemo%20-%20CI?branchName=master)](https://dev.azure.com/christianacca/ProblemDetailsDemo/_build/latest?definitionId=6?branchName=master)

## Overview

Example ASP.Net Core Web API that conforms to the [Problem Details spec](https://tools.ietf.org/html/rfc7807)

Uses [Hellang.Middleware.ProblemDetails](https://www.nuget.org/packages/Hellang.Middleware.ProblemDetails) to implement this spec.

The sample app includes a [Swagger UI](https://problem-details-demo.azurewebsites.net/swagger). Here you can find an explaination of each endpoint: 
how an MVC action result or raw middleware response is converted to a ProblemDetails response.

## Try examples online

1. Browse to : https://problem-details-demo.azurewebsites.net
4. Try out the various endpoints using the swagger UI

## Try examples locally

1. `cd src\ProblemDetailsDemo.Api`
2. `dotnet run` or `dotnet run --launch-profile ProblemDetailsDemo.Api.Production`
3. Browse to: http://localhost:5000
4. Try out the various endpoints using the swagger UI

## Additional resources

* blog post demonstrating nuget library see: https://codeopinion.com/http-api-problem-details-in-asp-net-core/
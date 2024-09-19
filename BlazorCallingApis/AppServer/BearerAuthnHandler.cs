using Microsoft.AspNetCore.Authorization;

namespace AppServer;

public class BearerAuthnHandler(IHttpContextAccessor httpContextAccessor) : AuthorizationHandler<BearerAuthnRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
        BearerAuthnRequirement requirement)
    {
        if (httpContextAccessor is null)
        {
            throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        var token = httpContextAccessor.HttpContext?.Request.Headers.Authorization;
        if (string.IsNullOrWhiteSpace(token) || token.Value != "Bearer MyBearerTokenValue")
        {
            context.Fail();
        }
        else
        {
            context.Succeed(requirement);
        }
        return Task.CompletedTask;
    }
}

public class BearerAuthnRequirement : IAuthorizationRequirement
{
}


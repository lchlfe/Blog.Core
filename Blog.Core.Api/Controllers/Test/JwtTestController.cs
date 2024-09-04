using Blog.Core.Common;
using Blog.Core.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SqlSugar;

namespace Blog.Core.Api.Controllers.Test;

[Route("api/[Controller]/[Action]")]
public class JwtTestController : BaseApiController
{



    /// <summary>
    /// 测试token,特性Authorize
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Authorize]
    public string GetAuthorize()
    {
        return "GetAuthorize";
    }

    /// <summary>
    /// 测试token，多角色特性[Authorize(Roles = "Admin,System11,Others")]
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Authorize(Roles = "Admin,System11,Others")]
    public string GetTokenByRole()
    {
        return "GetTokenByRole";
    }


    /// <summary>
    /// 测试token,特性 [Authorize(Policy = "GetTokenByClient")]
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Authorize(Policy = "Client")]
    public string GetTokenByClient()
    {
        return "GetTokenByClient";
    }

}
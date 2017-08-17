using JCE.OnlineTools.Domain.Model;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCE.OnlineTools.Api.Controllers
{
    /// <summary>
    /// 查询接口
    /// </summary>
    [Route("api/[controller]")]
    public class QueryController: Controller
    {
        /// <summary>
        /// 获取计算机信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ComputerInfo GetComputerInfo()
        {
            ComputerInfo result = new ComputerInfo();
            result.Encoding = Request.Headers["Accept-Encoding"].ToString();
            result.Lang = Request.Headers["Accept-Language"].ToString();
            result.UserAgent = Request.Headers["User-Agent"].ToString();
            result.Ip = HttpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress.ToString();
            return result;
        }
    }
}

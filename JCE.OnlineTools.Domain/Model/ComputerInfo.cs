using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace JCE.OnlineTools.Domain.Model
{
    /// <summary>
    /// 电脑信息
    /// </summary>
    public class ComputerInfo
    {
        /// <summary>
        /// 语言
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// 浏览器信息
        /// </summary>
        public string Browser { get; set; }

        /// <summary>
        /// 本机IP
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        public string System { get; set; }

        /// <summary>
        /// 用户代理
        /// </summary>
        public string UserAgent { get; set; }
    }
}
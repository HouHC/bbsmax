﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

using System;
using System.Collections.Generic;
using System.Text;
using MaxLabs.WebEngine;
using MaxLabs.bbsMax.Rescourses;
using MaxLabs.bbsMax.Entities;

namespace MaxLabs.bbsMax.Errors
{
    /// <summary>
    /// 没有权限错误
    /// </summary>
    public abstract class NoPermissionError : ErrorInfo
    {

        private string m_PermissionItemName = null;
        //private User m_TargetUser = null;

        public NoPermissionError(string permissionItemName)
        {
            this.m_PermissionItemName = permissionItemName;
        }

        public NoPermissionError()
        { }

        public override string Message
        {
            get { return string.Format("您没有权限{0}", m_PermissionItemName); }
        }

        public string PermissionItemName
        {
            get { return m_PermissionItemName; }
        }
    }
}
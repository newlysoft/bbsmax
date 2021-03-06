﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using MaxLabs.bbsMax.Entities;
using MaxLabs.WebEngine;
using MaxLabs.bbsMax.Enums;
using MaxLabs.bbsMax.Emoticons;
using System.Collections.Generic;
using MaxLabs.bbsMax.Errors;

namespace MaxLabs.bbsMax.Web.max_dialogs
{
    public partial class emoticon_user_import_batch : DialogPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!EmoticonBO.Instance.CanUseEmoticon(MyUserID))
            {
                ShowError(new NoPermissionUseEmoticonError());
                return;
            }

            if (Group == null)
            {
                ShowError("不存在的表情分组！");
            }

            if (Request.Form["state"] != null)
            {
                int state = _Request.Get<int>("state", Method.Post, 0);
                string msg = _Request.Get("message", Method.Post);

                switch (state)
                {
                    case 0:
                        ShowError(msg);
                        break;
                    case 1:
                        ShowWarning(msg, 1);
                        break;
                    case 2:
                        ShowSuccess(msg, 2);
                        break;
                }
            }
        }

        protected string MaxFileSize
        {
            get
            {
                return ConvertUtil.FormatSize(EmoticonBO.Instance.MaxEmticonFileSize(MyUserID));
            }
        }
        private EmoticonGroup m_group;
        protected EmoticonGroup Group
        {
            get
            {
                if (m_group == null)
                {
                    int groupId = _Request.Get<int>("groupid", Method.Get, 0);
                    m_group = EmoticonBO.Instance.GetEmoticonGroup(MyUserID, groupId);
                }
                return m_group;
            }
        }
    }
}
﻿namespace SKIT.FlurlHttpClient.Wechat.TenpayV2
{
    /// <summary>
    /// 微信支付 API 接口域名。
    /// </summary>
    public static class WechatTenpayEndpoints
    {
        /// <summary>
        /// 主域名（默认）。
        /// </summary>
        public const string DEFAULT = "https://api.mch.weixin.qq.com";

        /// <summary>
        /// 容灾备用域名。
        /// </summary>
        public const string BACKUP = "https://api2.mch.weixin.qq.com";

        /// <summary>
        /// 沙箱域名。
        /// </summary>
        public const string SANDBOX = "https://api.mch.weixin.qq.com/sandboxnew";
    }
}

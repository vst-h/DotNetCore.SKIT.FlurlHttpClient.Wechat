﻿namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /profitsharing/transactions/{transaction_id}/amounts 接口的请求。</para>
    /// </summary>
    public class GetProfitSharingTransactionAmountsRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TransactionId { get; set; } = string.Empty;
    }
}

using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOverseasRemitFxtradeorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitFxtradeorderCreateModel : AopObject
    {
        /// <summary>
        /// the unique id on block chain generated by the caller to represent this remit operation
        /// </summary>
        [XmlElement("bc_remit_id")]
        public string BcRemitId { get; set; }

        /// <summary>
        /// currency pair
        /// </summary>
        [XmlElement("currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// extended info
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// fx trade orderId
        /// </summary>
        [XmlElement("fx_trade_order_id")]
        public string FxTradeOrderId { get; set; }

        /// <summary>
        /// fx trade side
        /// </summary>
        [XmlElement("fx_trade_side")]
        public string FxTradeSide { get; set; }

        /// <summary>
        /// the Mid of the receiver allocated by net.
        /// </summary>
        [XmlElement("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// the Mid of the sender allocated by net.
        /// </summary>
        [XmlElement("sender_mid")]
        public string SenderMid { get; set; }

        /// <summary>
        /// { "currency":"CNY", "value":"100000" }
        /// </summary>
        [XmlElement("trans_amount")]
        public Money TransAmount { get; set; }
    }
}
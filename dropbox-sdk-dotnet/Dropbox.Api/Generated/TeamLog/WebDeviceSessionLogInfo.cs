// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Information on active web sessions</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.TeamLog.DeviceSessionLogInfo" />
    public class WebDeviceSessionLogInfo : DeviceSessionLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<WebDeviceSessionLogInfo> Encoder = new WebDeviceSessionLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<WebDeviceSessionLogInfo> Decoder = new WebDeviceSessionLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="WebDeviceSessionLogInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="userAgent">Information on the hosting device.</param>
        /// <param name="os">Information on the hosting operating system.</param>
        /// <param name="browser">Information on the browser used for this web session.</param>
        /// <param name="ipAddress">The IP address of the last activity from this session.
        /// Might be missing due to historical data gap.</param>
        /// <param name="created">The time this session was created. Might be missing due to
        /// historical data gap.</param>
        /// <param name="updated">The time of the last activity from this session. Might be
        /// missing due to historical data gap.</param>
        /// <param name="sessionInfo">Web session unique id. Might be missing due to historical
        /// data gap.</param>
        public WebDeviceSessionLogInfo(string userAgent,
                                       string os,
                                       string browser,
                                       string ipAddress = null,
                                       sys.DateTime? created = null,
                                       sys.DateTime? updated = null,
                                       WebSessionLogInfo sessionInfo = null)
            : base(ipAddress, created, updated)
        {
            if (userAgent == null)
            {
                throw new sys.ArgumentNullException("userAgent");
            }

            if (os == null)
            {
                throw new sys.ArgumentNullException("os");
            }

            if (browser == null)
            {
                throw new sys.ArgumentNullException("browser");
            }

            this.UserAgent = userAgent;
            this.Os = os;
            this.Browser = browser;
            this.SessionInfo = sessionInfo;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="WebDeviceSessionLogInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public WebDeviceSessionLogInfo()
        {
        }

        /// <summary>
        /// <para>Information on the hosting device.</para>
        /// </summary>
        public string UserAgent { get; protected set; }

        /// <summary>
        /// <para>Information on the hosting operating system.</para>
        /// </summary>
        public string Os { get; protected set; }

        /// <summary>
        /// <para>Information on the browser used for this web session.</para>
        /// </summary>
        public string Browser { get; protected set; }

        /// <summary>
        /// <para>Web session unique id. Might be missing due to historical data gap.</para>
        /// </summary>
        public WebSessionLogInfo SessionInfo { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="WebDeviceSessionLogInfo" />.</para>
        /// </summary>
        private class WebDeviceSessionLogInfoEncoder : enc.StructEncoder<WebDeviceSessionLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(WebDeviceSessionLogInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("user_agent", value.UserAgent, writer, enc.StringEncoder.Instance);
                WriteProperty("os", value.Os, writer, enc.StringEncoder.Instance);
                WriteProperty("browser", value.Browser, writer, enc.StringEncoder.Instance);
                if (value.IpAddress != null)
                {
                    WriteProperty("ip_address", value.IpAddress, writer, enc.StringEncoder.Instance);
                }
                if (value.Created != null)
                {
                    WriteProperty("created", value.Created.Value, writer, enc.DateTimeEncoder.Instance);
                }
                if (value.Updated != null)
                {
                    WriteProperty("updated", value.Updated.Value, writer, enc.DateTimeEncoder.Instance);
                }
                if (value.SessionInfo != null)
                {
                    WriteProperty("session_info", value.SessionInfo, writer, global::Dropbox.Api.TeamLog.WebSessionLogInfo.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="WebDeviceSessionLogInfo" />.</para>
        /// </summary>
        private class WebDeviceSessionLogInfoDecoder : enc.StructDecoder<WebDeviceSessionLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="WebDeviceSessionLogInfo"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override WebDeviceSessionLogInfo Create()
            {
                return new WebDeviceSessionLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(WebDeviceSessionLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "user_agent":
                        value.UserAgent = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "os":
                        value.Os = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "browser":
                        value.Browser = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "ip_address":
                        value.IpAddress = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "created":
                        value.Created = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "updated":
                        value.Updated = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "session_info":
                        value.SessionInfo = global::Dropbox.Api.TeamLog.WebSessionLogInfo.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}

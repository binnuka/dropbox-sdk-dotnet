// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Auth
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The token from o auth1 arg object</para>
    /// </summary>
    public class TokenFromOAuth1Arg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TokenFromOAuth1Arg> Encoder = new TokenFromOAuth1ArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TokenFromOAuth1Arg> Decoder = new TokenFromOAuth1ArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TokenFromOAuth1Arg" />
        /// class.</para>
        /// </summary>
        /// <param name="oauth1Token">The supplied OAuth 1.0 access token.</param>
        /// <param name="oauth1TokenSecret">The token secret associated with the supplied
        /// access token.</param>
        public TokenFromOAuth1Arg(string oauth1Token,
                                  string oauth1TokenSecret)
        {
            if (oauth1Token == null)
            {
                throw new sys.ArgumentNullException("oauth1Token");
            }
            if (oauth1Token.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("oauth1Token", "Length should be at least 1");
            }

            if (oauth1TokenSecret == null)
            {
                throw new sys.ArgumentNullException("oauth1TokenSecret");
            }
            if (oauth1TokenSecret.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("oauth1TokenSecret", "Length should be at least 1");
            }

            this.Oauth1Token = oauth1Token;
            this.Oauth1TokenSecret = oauth1TokenSecret;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TokenFromOAuth1Arg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public TokenFromOAuth1Arg()
        {
        }

        /// <summary>
        /// <para>The supplied OAuth 1.0 access token.</para>
        /// </summary>
        public string Oauth1Token { get; protected set; }

        /// <summary>
        /// <para>The token secret associated with the supplied access token.</para>
        /// </summary>
        public string Oauth1TokenSecret { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TokenFromOAuth1Arg" />.</para>
        /// </summary>
        private class TokenFromOAuth1ArgEncoder : enc.StructEncoder<TokenFromOAuth1Arg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TokenFromOAuth1Arg value, enc.IJsonWriter writer)
            {
                WriteProperty("oauth1_token", value.Oauth1Token, writer, enc.StringEncoder.Instance);
                WriteProperty("oauth1_token_secret", value.Oauth1TokenSecret, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TokenFromOAuth1Arg" />.</para>
        /// </summary>
        private class TokenFromOAuth1ArgDecoder : enc.StructDecoder<TokenFromOAuth1Arg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TokenFromOAuth1Arg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TokenFromOAuth1Arg Create()
            {
                return new TokenFromOAuth1Arg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TokenFromOAuth1Arg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "oauth1_token":
                        value.Oauth1Token = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "oauth1_token_secret":
                        value.Oauth1TokenSecret = enc.StringDecoder.Instance.Decode(reader);
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

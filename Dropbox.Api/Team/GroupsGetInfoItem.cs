// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The groups get info item object</para>
    /// </summary>
    public class GroupsGetInfoItem
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupsGetInfoItem> Encoder = new GroupsGetInfoItemEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupsGetInfoItem> Decoder = new GroupsGetInfoItemDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsGetInfoItem" />
        /// class.</para>
        /// </summary>
        public GroupsGetInfoItem()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is IdNotFound</para>
        /// </summary>
        public bool IsIdNotFound
        {
            get
            {
                return this is IdNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a IdNotFound, or <c>null</c>.</para>
        /// </summary>
        public IdNotFound AsIdNotFound
        {
            get
            {
                return this as IdNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupInfo</para>
        /// </summary>
        public bool IsGroupInfo
        {
            get
            {
                return this is GroupInfo;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupInfo, or <c>null</c>.</para>
        /// </summary>
        public GroupInfo AsGroupInfo
        {
            get
            {
                return this as GroupInfo;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupsGetInfoItem" />.</para>
        /// </summary>
        private class GroupsGetInfoItemEncoder : enc.StructEncoder<GroupsGetInfoItem>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupsGetInfoItem value, enc.IJsonWriter writer)
            {
                if (value is IdNotFound)
                {
                    WriteProperty(".tag", "id_not_found", writer, enc.StringEncoder.Instance);
                    IdNotFound.Encoder.EncodeFields((IdNotFound)value, writer);
                    return;
                }
                if (value is GroupInfo)
                {
                    WriteProperty(".tag", "group_info", writer, enc.StringEncoder.Instance);
                    GroupInfo.Encoder.EncodeFields((GroupInfo)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupsGetInfoItem" />.</para>
        /// </summary>
        private class GroupsGetInfoItemDecoder : enc.UnionDecoder<GroupsGetInfoItem>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupsGetInfoItem" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupsGetInfoItem Create()
            {
                return new GroupsGetInfoItem();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GroupsGetInfoItem Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "id_not_found":
                        return IdNotFound.Decoder.DecodeFields(reader);
                    case "group_info":
                        return GroupInfo.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>An ID that was provided as a parameter to <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.GroupsGetInfoAsync" />, and did not
        /// match a corresponding group. The ID can be a group ID, or an external ID, depending
        /// on how the method was called.</para>
        /// </summary>
        public sealed class IdNotFound : GroupsGetInfoItem
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<IdNotFound> Encoder = new IdNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<IdNotFound> Decoder = new IdNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IdNotFound" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public IdNotFound(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IdNotFound" /> class.</para>
            /// </summary>
            private IdNotFound()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="IdNotFound" />.</para>
            /// </summary>
            private class IdNotFoundEncoder : enc.StructEncoder<IdNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(IdNotFound value, enc.IJsonWriter writer)
                {
                    WriteProperty("id_not_found", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="IdNotFound" />.</para>
            /// </summary>
            private class IdNotFoundDecoder : enc.StructDecoder<IdNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="IdNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override IdNotFound Create()
                {
                    return new IdNotFound();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(IdNotFound value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "id_not_found":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Info about a group.</para>
        /// </summary>
        public sealed class GroupInfo : GroupsGetInfoItem
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupInfo> Encoder = new GroupInfoEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupInfo> Decoder = new GroupInfoDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupInfo" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public GroupInfo(GroupFullInfo value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupInfo" /> class.</para>
            /// </summary>
            private GroupInfo()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public GroupFullInfo Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupInfo" />.</para>
            /// </summary>
            private class GroupInfoEncoder : enc.StructEncoder<GroupInfo>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupInfo value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Team.GroupFullInfo.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupInfo" />.</para>
            /// </summary>
            private class GroupInfoDecoder : enc.StructDecoder<GroupInfo>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupInfo" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupInfo Create()
                {
                    return new GroupInfo();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupInfo DecodeFields(enc.IJsonReader reader)
                {
                    return new GroupInfo(Dropbox.Api.Team.GroupFullInfo.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }
    }
}

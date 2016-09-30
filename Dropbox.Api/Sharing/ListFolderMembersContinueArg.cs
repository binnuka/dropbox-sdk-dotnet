// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The list folder members continue arg object</para>
    /// </summary>
    public class ListFolderMembersContinueArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListFolderMembersContinueArg> Encoder = new ListFolderMembersContinueArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListFolderMembersContinueArg> Decoder = new ListFolderMembersContinueArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderMembersContinueArg" />
        /// class.</para>
        /// </summary>
        /// <param name="cursor">The cursor returned by your last call to <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.ListFolderMembersAsync" /> or
        /// <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.ListFolderMembersContinueAsync"
        /// />.</param>
        public ListFolderMembersContinueArg(string cursor)
        {
            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            this.Cursor = cursor;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderMembersContinueArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListFolderMembersContinueArg()
        {
        }

        /// <summary>
        /// <para>The cursor returned by your last call to <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.ListFolderMembersAsync" /> or
        /// <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.ListFolderMembersContinueAsync"
        /// />.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListFolderMembersContinueArg" />.</para>
        /// </summary>
        private class ListFolderMembersContinueArgEncoder : enc.StructEncoder<ListFolderMembersContinueArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListFolderMembersContinueArg value, enc.IJsonWriter writer)
            {
                WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListFolderMembersContinueArg" />.</para>
        /// </summary>
        private class ListFolderMembersContinueArgDecoder : enc.StructDecoder<ListFolderMembersContinueArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListFolderMembersContinueArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListFolderMembersContinueArg Create()
            {
                return new ListFolderMembersContinueArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListFolderMembersContinueArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
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

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
    /// <para>The team folder create error object</para>
    /// </summary>
    public class TeamFolderCreateError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamFolderCreateError> Encoder = new TeamFolderCreateErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamFolderCreateError> Decoder = new TeamFolderCreateErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderCreateError" />
        /// class.</para>
        /// </summary>
        public TeamFolderCreateError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidFolderName</para>
        /// </summary>
        public bool IsInvalidFolderName
        {
            get
            {
                return this is InvalidFolderName;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidFolderName, or <c>null</c>.</para>
        /// </summary>
        public InvalidFolderName AsInvalidFolderName
        {
            get
            {
                return this as InvalidFolderName;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FolderNameAlreadyUsed</para>
        /// </summary>
        public bool IsFolderNameAlreadyUsed
        {
            get
            {
                return this is FolderNameAlreadyUsed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FolderNameAlreadyUsed, or <c>null</c>.</para>
        /// </summary>
        public FolderNameAlreadyUsed AsFolderNameAlreadyUsed
        {
            get
            {
                return this as FolderNameAlreadyUsed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamFolderCreateError" />.</para>
        /// </summary>
        private class TeamFolderCreateErrorEncoder : enc.StructEncoder<TeamFolderCreateError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamFolderCreateError value, enc.IJsonWriter writer)
            {
                if (value is InvalidFolderName)
                {
                    WriteProperty(".tag", "invalid_folder_name", writer, enc.StringEncoder.Instance);
                    InvalidFolderName.Encoder.EncodeFields((InvalidFolderName)value, writer);
                    return;
                }
                if (value is FolderNameAlreadyUsed)
                {
                    WriteProperty(".tag", "folder_name_already_used", writer, enc.StringEncoder.Instance);
                    FolderNameAlreadyUsed.Encoder.EncodeFields((FolderNameAlreadyUsed)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamFolderCreateError" />.</para>
        /// </summary>
        private class TeamFolderCreateErrorDecoder : enc.UnionDecoder<TeamFolderCreateError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamFolderCreateError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamFolderCreateError Create()
            {
                return new TeamFolderCreateError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override TeamFolderCreateError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invalid_folder_name":
                        return InvalidFolderName.Decoder.DecodeFields(reader);
                    case "folder_name_already_used":
                        return FolderNameAlreadyUsed.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The provided name cannot be used.</para>
        /// </summary>
        public sealed class InvalidFolderName : TeamFolderCreateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidFolderName> Encoder = new InvalidFolderNameEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidFolderName> Decoder = new InvalidFolderNameDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidFolderName" />
            /// class.</para>
            /// </summary>
            private InvalidFolderName()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidFolderName</para>
            /// </summary>
            public static readonly InvalidFolderName Instance = new InvalidFolderName();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidFolderName" />.</para>
            /// </summary>
            private class InvalidFolderNameEncoder : enc.StructEncoder<InvalidFolderName>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidFolderName value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidFolderName" />.</para>
            /// </summary>
            private class InvalidFolderNameDecoder : enc.StructDecoder<InvalidFolderName>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidFolderName"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidFolderName Create()
                {
                    return new InvalidFolderName();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InvalidFolderName DecodeFields(enc.IJsonReader reader)
                {
                    return InvalidFolderName.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>There is already a team folder with the provided name.</para>
        /// </summary>
        public sealed class FolderNameAlreadyUsed : TeamFolderCreateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<FolderNameAlreadyUsed> Encoder = new FolderNameAlreadyUsedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<FolderNameAlreadyUsed> Decoder = new FolderNameAlreadyUsedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FolderNameAlreadyUsed" />
            /// class.</para>
            /// </summary>
            private FolderNameAlreadyUsed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of FolderNameAlreadyUsed</para>
            /// </summary>
            public static readonly FolderNameAlreadyUsed Instance = new FolderNameAlreadyUsed();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="FolderNameAlreadyUsed" />.</para>
            /// </summary>
            private class FolderNameAlreadyUsedEncoder : enc.StructEncoder<FolderNameAlreadyUsed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(FolderNameAlreadyUsed value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="FolderNameAlreadyUsed" />.</para>
            /// </summary>
            private class FolderNameAlreadyUsedDecoder : enc.StructDecoder<FolderNameAlreadyUsed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="FolderNameAlreadyUsed"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override FolderNameAlreadyUsed Create()
                {
                    return new FolderNameAlreadyUsed();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override FolderNameAlreadyUsed DecodeFields(enc.IJsonReader reader)
                {
                    return FolderNameAlreadyUsed.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : TeamFolderCreateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}

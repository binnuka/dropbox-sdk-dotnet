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
    /// <para>The group members add error object</para>
    /// </summary>
    public class GroupMembersAddError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupMembersAddError> Encoder = new GroupMembersAddErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupMembersAddError> Decoder = new GroupMembersAddErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupMembersAddError" />
        /// class.</para>
        /// </summary>
        public GroupMembersAddError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DuplicateUser</para>
        /// </summary>
        public bool IsDuplicateUser
        {
            get
            {
                return this is DuplicateUser;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DuplicateUser, or <c>null</c>.</para>
        /// </summary>
        public DuplicateUser AsDuplicateUser
        {
            get
            {
                return this as DuplicateUser;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupNotInTeam</para>
        /// </summary>
        public bool IsGroupNotInTeam
        {
            get
            {
                return this is GroupNotInTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupNotInTeam, or <c>null</c>.</para>
        /// </summary>
        public GroupNotInTeam AsGroupNotInTeam
        {
            get
            {
                return this as GroupNotInTeam;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MembersNotInTeam</para>
        /// </summary>
        public bool IsMembersNotInTeam
        {
            get
            {
                return this is MembersNotInTeam;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MembersNotInTeam, or <c>null</c>.</para>
        /// </summary>
        public MembersNotInTeam AsMembersNotInTeam
        {
            get
            {
                return this as MembersNotInTeam;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UsersNotFound</para>
        /// </summary>
        public bool IsUsersNotFound
        {
            get
            {
                return this is UsersNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UsersNotFound, or <c>null</c>.</para>
        /// </summary>
        public UsersNotFound AsUsersNotFound
        {
            get
            {
                return this as UsersNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// UserMustBeActiveToBeOwner</para>
        /// </summary>
        public bool IsUserMustBeActiveToBeOwner
        {
            get
            {
                return this is UserMustBeActiveToBeOwner;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UserMustBeActiveToBeOwner, or <c>null</c>.</para>
        /// </summary>
        public UserMustBeActiveToBeOwner AsUserMustBeActiveToBeOwner
        {
            get
            {
                return this as UserMustBeActiveToBeOwner;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// UserCannotBeManagerOfCompanyManagedGroup</para>
        /// </summary>
        public bool IsUserCannotBeManagerOfCompanyManagedGroup
        {
            get
            {
                return this is UserCannotBeManagerOfCompanyManagedGroup;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UserCannotBeManagerOfCompanyManagedGroup, or
        /// <c>null</c>.</para>
        /// </summary>
        public UserCannotBeManagerOfCompanyManagedGroup AsUserCannotBeManagerOfCompanyManagedGroup
        {
            get
            {
                return this as UserCannotBeManagerOfCompanyManagedGroup;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupNotFound</para>
        /// </summary>
        public bool IsGroupNotFound
        {
            get
            {
                return this is GroupNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupNotFound, or <c>null</c>.</para>
        /// </summary>
        public GroupNotFound AsGroupNotFound
        {
            get
            {
                return this as GroupNotFound;
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
        /// <para>Encoder for  <see cref="GroupMembersAddError" />.</para>
        /// </summary>
        private class GroupMembersAddErrorEncoder : enc.StructEncoder<GroupMembersAddError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupMembersAddError value, enc.IJsonWriter writer)
            {
                if (value is DuplicateUser)
                {
                    WriteProperty(".tag", "duplicate_user", writer, enc.StringEncoder.Instance);
                    DuplicateUser.Encoder.EncodeFields((DuplicateUser)value, writer);
                    return;
                }
                if (value is GroupNotInTeam)
                {
                    WriteProperty(".tag", "group_not_in_team", writer, enc.StringEncoder.Instance);
                    GroupNotInTeam.Encoder.EncodeFields((GroupNotInTeam)value, writer);
                    return;
                }
                if (value is MembersNotInTeam)
                {
                    WriteProperty(".tag", "members_not_in_team", writer, enc.StringEncoder.Instance);
                    MembersNotInTeam.Encoder.EncodeFields((MembersNotInTeam)value, writer);
                    return;
                }
                if (value is UsersNotFound)
                {
                    WriteProperty(".tag", "users_not_found", writer, enc.StringEncoder.Instance);
                    UsersNotFound.Encoder.EncodeFields((UsersNotFound)value, writer);
                    return;
                }
                if (value is UserMustBeActiveToBeOwner)
                {
                    WriteProperty(".tag", "user_must_be_active_to_be_owner", writer, enc.StringEncoder.Instance);
                    UserMustBeActiveToBeOwner.Encoder.EncodeFields((UserMustBeActiveToBeOwner)value, writer);
                    return;
                }
                if (value is UserCannotBeManagerOfCompanyManagedGroup)
                {
                    WriteProperty(".tag", "user_cannot_be_manager_of_company_managed_group", writer, enc.StringEncoder.Instance);
                    UserCannotBeManagerOfCompanyManagedGroup.Encoder.EncodeFields((UserCannotBeManagerOfCompanyManagedGroup)value, writer);
                    return;
                }
                if (value is GroupNotFound)
                {
                    WriteProperty(".tag", "group_not_found", writer, enc.StringEncoder.Instance);
                    GroupNotFound.Encoder.EncodeFields((GroupNotFound)value, writer);
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
        /// <para>Decoder for  <see cref="GroupMembersAddError" />.</para>
        /// </summary>
        private class GroupMembersAddErrorDecoder : enc.UnionDecoder<GroupMembersAddError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupMembersAddError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupMembersAddError Create()
            {
                return new GroupMembersAddError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GroupMembersAddError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "duplicate_user":
                        return DuplicateUser.Decoder.DecodeFields(reader);
                    case "group_not_in_team":
                        return GroupNotInTeam.Decoder.DecodeFields(reader);
                    case "members_not_in_team":
                        return MembersNotInTeam.Decoder.DecodeFields(reader);
                    case "users_not_found":
                        return UsersNotFound.Decoder.DecodeFields(reader);
                    case "user_must_be_active_to_be_owner":
                        return UserMustBeActiveToBeOwner.Decoder.DecodeFields(reader);
                    case "user_cannot_be_manager_of_company_managed_group":
                        return UserCannotBeManagerOfCompanyManagedGroup.Decoder.DecodeFields(reader);
                    case "group_not_found":
                        return GroupNotFound.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>You cannot add duplicate users. One or more of the members you are trying to
        /// add is already a member of the group.</para>
        /// </summary>
        public sealed class DuplicateUser : GroupMembersAddError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DuplicateUser> Encoder = new DuplicateUserEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DuplicateUser> Decoder = new DuplicateUserDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DuplicateUser" />
            /// class.</para>
            /// </summary>
            private DuplicateUser()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DuplicateUser</para>
            /// </summary>
            public static readonly DuplicateUser Instance = new DuplicateUser();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DuplicateUser" />.</para>
            /// </summary>
            private class DuplicateUserEncoder : enc.StructEncoder<DuplicateUser>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DuplicateUser value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DuplicateUser" />.</para>
            /// </summary>
            private class DuplicateUserDecoder : enc.StructDecoder<DuplicateUser>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DuplicateUser" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DuplicateUser Create()
                {
                    return new DuplicateUser();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override DuplicateUser DecodeFields(enc.IJsonReader reader)
                {
                    return DuplicateUser.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Group is not in this team. You cannot add members to a group that is outside
        /// of your team.</para>
        /// </summary>
        public sealed class GroupNotInTeam : GroupMembersAddError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupNotInTeam> Encoder = new GroupNotInTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupNotInTeam> Decoder = new GroupNotInTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupNotInTeam" />
            /// class.</para>
            /// </summary>
            private GroupNotInTeam()
            {
            }

            /// <summary>
            /// <para>A singleton instance of GroupNotInTeam</para>
            /// </summary>
            public static readonly GroupNotInTeam Instance = new GroupNotInTeam();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupNotInTeam" />.</para>
            /// </summary>
            private class GroupNotInTeamEncoder : enc.StructEncoder<GroupNotInTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupNotInTeam value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupNotInTeam" />.</para>
            /// </summary>
            private class GroupNotInTeamDecoder : enc.StructDecoder<GroupNotInTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupNotInTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupNotInTeam Create()
                {
                    return new GroupNotInTeam();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupNotInTeam DecodeFields(enc.IJsonReader reader)
                {
                    return GroupNotInTeam.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>These members are not part of your team. Currently, you cannot add members to
        /// a group if they are not part of your team, though this may change in a subsequent
        /// version. To add new members to your Dropbox Business team, use the <see
        /// cref="Dropbox.Api.Team.Routes.TeamTeamRoutes.MembersAddAsync" /> endpoint.</para>
        /// </summary>
        public sealed class MembersNotInTeam : GroupMembersAddError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MembersNotInTeam> Encoder = new MembersNotInTeamEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MembersNotInTeam> Decoder = new MembersNotInTeamDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MembersNotInTeam" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public MembersNotInTeam(col.IEnumerable<string> value)
            {
                this.Value = new col.List<string>(value);
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MembersNotInTeam" />
            /// class.</para>
            /// </summary>
            private MembersNotInTeam()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public col.IList<string> Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MembersNotInTeam" />.</para>
            /// </summary>
            private class MembersNotInTeamEncoder : enc.StructEncoder<MembersNotInTeam>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MembersNotInTeam value, enc.IJsonWriter writer)
                {
                    WriteListProperty("members_not_in_team", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MembersNotInTeam" />.</para>
            /// </summary>
            private class MembersNotInTeamDecoder : enc.StructDecoder<MembersNotInTeam>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MembersNotInTeam" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MembersNotInTeam Create()
                {
                    return new MembersNotInTeam();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(MembersNotInTeam value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "members_not_in_team":
                            value.Value = ReadList<string>(reader, enc.StringDecoder.Instance);
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
        /// <para>These users were not found in Dropbox.</para>
        /// </summary>
        public sealed class UsersNotFound : GroupMembersAddError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UsersNotFound> Encoder = new UsersNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UsersNotFound> Decoder = new UsersNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UsersNotFound" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public UsersNotFound(col.IEnumerable<string> value)
            {
                this.Value = new col.List<string>(value);
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UsersNotFound" />
            /// class.</para>
            /// </summary>
            private UsersNotFound()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public col.IList<string> Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UsersNotFound" />.</para>
            /// </summary>
            private class UsersNotFoundEncoder : enc.StructEncoder<UsersNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UsersNotFound value, enc.IJsonWriter writer)
                {
                    WriteListProperty("users_not_found", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UsersNotFound" />.</para>
            /// </summary>
            private class UsersNotFoundDecoder : enc.StructDecoder<UsersNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UsersNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UsersNotFound Create()
                {
                    return new UsersNotFound();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(UsersNotFound value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "users_not_found":
                            value.Value = ReadList<string>(reader, enc.StringDecoder.Instance);
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
        /// <para>A suspended user cannot be added to a group as <see
        /// cref="Dropbox.Api.Team.GroupAccessType.Owner" />.</para>
        /// </summary>
        public sealed class UserMustBeActiveToBeOwner : GroupMembersAddError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UserMustBeActiveToBeOwner> Encoder = new UserMustBeActiveToBeOwnerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UserMustBeActiveToBeOwner> Decoder = new UserMustBeActiveToBeOwnerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserMustBeActiveToBeOwner"
            /// /> class.</para>
            /// </summary>
            private UserMustBeActiveToBeOwner()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UserMustBeActiveToBeOwner</para>
            /// </summary>
            public static readonly UserMustBeActiveToBeOwner Instance = new UserMustBeActiveToBeOwner();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UserMustBeActiveToBeOwner" />.</para>
            /// </summary>
            private class UserMustBeActiveToBeOwnerEncoder : enc.StructEncoder<UserMustBeActiveToBeOwner>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UserMustBeActiveToBeOwner value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UserMustBeActiveToBeOwner" />.</para>
            /// </summary>
            private class UserMustBeActiveToBeOwnerDecoder : enc.StructDecoder<UserMustBeActiveToBeOwner>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UserMustBeActiveToBeOwner"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UserMustBeActiveToBeOwner Create()
                {
                    return new UserMustBeActiveToBeOwner();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override UserMustBeActiveToBeOwner DecodeFields(enc.IJsonReader reader)
                {
                    return UserMustBeActiveToBeOwner.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>A company-managed group cannot be managed by a user.</para>
        /// </summary>
        public sealed class UserCannotBeManagerOfCompanyManagedGroup : GroupMembersAddError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UserCannotBeManagerOfCompanyManagedGroup> Encoder = new UserCannotBeManagerOfCompanyManagedGroupEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UserCannotBeManagerOfCompanyManagedGroup> Decoder = new UserCannotBeManagerOfCompanyManagedGroupDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see
            /// cref="UserCannotBeManagerOfCompanyManagedGroup" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public UserCannotBeManagerOfCompanyManagedGroup(col.IEnumerable<string> value)
            {
                this.Value = new col.List<string>(value);
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see
            /// cref="UserCannotBeManagerOfCompanyManagedGroup" /> class.</para>
            /// </summary>
            private UserCannotBeManagerOfCompanyManagedGroup()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public col.IList<string> Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UserCannotBeManagerOfCompanyManagedGroup"
            /// />.</para>
            /// </summary>
            private class UserCannotBeManagerOfCompanyManagedGroupEncoder : enc.StructEncoder<UserCannotBeManagerOfCompanyManagedGroup>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UserCannotBeManagerOfCompanyManagedGroup value, enc.IJsonWriter writer)
                {
                    WriteListProperty("user_cannot_be_manager_of_company_managed_group", value.Value, writer, enc.StringEncoder.Instance);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UserCannotBeManagerOfCompanyManagedGroup"
            /// />.</para>
            /// </summary>
            private class UserCannotBeManagerOfCompanyManagedGroupDecoder : enc.StructDecoder<UserCannotBeManagerOfCompanyManagedGroup>
            {
                /// <summary>
                /// <para>Create a new instance of type <see
                /// cref="UserCannotBeManagerOfCompanyManagedGroup" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UserCannotBeManagerOfCompanyManagedGroup Create()
                {
                    return new UserCannotBeManagerOfCompanyManagedGroup();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(UserCannotBeManagerOfCompanyManagedGroup value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "user_cannot_be_manager_of_company_managed_group":
                            value.Value = ReadList<string>(reader, enc.StringDecoder.Instance);
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
        /// <para>No matching group found. No groups match the specified group ID.</para>
        /// </summary>
        public sealed class GroupNotFound : GroupMembersAddError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupNotFound> Encoder = new GroupNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupNotFound> Decoder = new GroupNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupNotFound" />
            /// class.</para>
            /// </summary>
            private GroupNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of GroupNotFound</para>
            /// </summary>
            public static readonly GroupNotFound Instance = new GroupNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupNotFound" />.</para>
            /// </summary>
            private class GroupNotFoundEncoder : enc.StructEncoder<GroupNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupNotFound" />.</para>
            /// </summary>
            private class GroupNotFoundDecoder : enc.StructDecoder<GroupNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupNotFound Create()
                {
                    return new GroupNotFound();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupNotFound DecodeFields(enc.IJsonReader reader)
                {
                    return GroupNotFound.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : GroupMembersAddError
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

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
    /// <para>Changed whether shared folder inherits members from parent folder.</para>
    /// </summary>
    public class SharedFolderChangeMembersInheritancePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderChangeMembersInheritancePolicyDetails> Encoder = new SharedFolderChangeMembersInheritancePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderChangeMembersInheritancePolicyDetails> Decoder = new SharedFolderChangeMembersInheritancePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeMembersInheritancePolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New member inheritance policy.</param>
        /// <param name="previousValue">Previous member inheritance policy. Might be missing
        /// due to historical data gap.</param>
        public SharedFolderChangeMembersInheritancePolicyDetails(SharedFolderMembersInheritancePolicy newValue,
                                                                 SharedFolderMembersInheritancePolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeMembersInheritancePolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedFolderChangeMembersInheritancePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New member inheritance policy.</para>
        /// </summary>
        public SharedFolderMembersInheritancePolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous member inheritance policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public SharedFolderMembersInheritancePolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderChangeMembersInheritancePolicyDetails"
        /// />.</para>
        /// </summary>
        private class SharedFolderChangeMembersInheritancePolicyDetailsEncoder : enc.StructEncoder<SharedFolderChangeMembersInheritancePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderChangeMembersInheritancePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.SharedFolderMembersInheritancePolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.SharedFolderMembersInheritancePolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderChangeMembersInheritancePolicyDetails"
        /// />.</para>
        /// </summary>
        private class SharedFolderChangeMembersInheritancePolicyDetailsDecoder : enc.StructDecoder<SharedFolderChangeMembersInheritancePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedFolderChangeMembersInheritancePolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderChangeMembersInheritancePolicyDetails Create()
            {
                return new SharedFolderChangeMembersInheritancePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderChangeMembersInheritancePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.SharedFolderMembersInheritancePolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.SharedFolderMembersInheritancePolicy.Decoder.Decode(reader);
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

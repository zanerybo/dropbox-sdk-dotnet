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
    /// <para>Deleted a policy.</para>
    /// </summary>
    public class GovernancePolicyDeleteDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GovernancePolicyDeleteDetails> Encoder = new GovernancePolicyDeleteDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GovernancePolicyDeleteDetails> Decoder = new GovernancePolicyDeleteDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GovernancePolicyDeleteDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="governancePolicyId">Policy ID.</param>
        /// <param name="name">Policy name.</param>
        /// <param name="policyType">Policy type.</param>
        public GovernancePolicyDeleteDetails(string governancePolicyId,
                                             string name,
                                             PolicyType policyType = null)
        {
            if (governancePolicyId == null)
            {
                throw new sys.ArgumentNullException("governancePolicyId");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            this.GovernancePolicyId = governancePolicyId;
            this.Name = name;
            this.PolicyType = policyType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GovernancePolicyDeleteDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GovernancePolicyDeleteDetails()
        {
        }

        /// <summary>
        /// <para>Policy ID.</para>
        /// </summary>
        public string GovernancePolicyId { get; protected set; }

        /// <summary>
        /// <para>Policy name.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>Policy type.</para>
        /// </summary>
        public PolicyType PolicyType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GovernancePolicyDeleteDetails" />.</para>
        /// </summary>
        private class GovernancePolicyDeleteDetailsEncoder : enc.StructEncoder<GovernancePolicyDeleteDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GovernancePolicyDeleteDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("governance_policy_id", value.GovernancePolicyId, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                if (value.PolicyType != null)
                {
                    WriteProperty("policy_type", value.PolicyType, writer, global::Dropbox.Api.TeamLog.PolicyType.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GovernancePolicyDeleteDetails" />.</para>
        /// </summary>
        private class GovernancePolicyDeleteDetailsDecoder : enc.StructDecoder<GovernancePolicyDeleteDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GovernancePolicyDeleteDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GovernancePolicyDeleteDetails Create()
            {
                return new GovernancePolicyDeleteDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GovernancePolicyDeleteDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "governance_policy_id":
                        value.GovernancePolicyId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "policy_type":
                        value.PolicyType = global::Dropbox.Api.TeamLog.PolicyType.Decoder.Decode(reader);
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

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
    /// <para>Sent account capture email to all unmanaged members.</para>
    /// </summary>
    public class AccountCaptureNotificationEmailsSentDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AccountCaptureNotificationEmailsSentDetails> Encoder = new AccountCaptureNotificationEmailsSentDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AccountCaptureNotificationEmailsSentDetails> Decoder = new AccountCaptureNotificationEmailsSentDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AccountCaptureNotificationEmailsSentDetails" /> class.</para>
        /// </summary>
        /// <param name="domainName">Domain name.</param>
        /// <param name="notificationType">Account-capture email notification type.</param>
        public AccountCaptureNotificationEmailsSentDetails(string domainName,
                                                           AccountCaptureNotificationType notificationType = null)
        {
            if (domainName == null)
            {
                throw new sys.ArgumentNullException("domainName");
            }

            this.DomainName = domainName;
            this.NotificationType = notificationType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AccountCaptureNotificationEmailsSentDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AccountCaptureNotificationEmailsSentDetails()
        {
        }

        /// <summary>
        /// <para>Domain name.</para>
        /// </summary>
        public string DomainName { get; protected set; }

        /// <summary>
        /// <para>Account-capture email notification type.</para>
        /// </summary>
        public AccountCaptureNotificationType NotificationType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AccountCaptureNotificationEmailsSentDetails"
        /// />.</para>
        /// </summary>
        private class AccountCaptureNotificationEmailsSentDetailsEncoder : enc.StructEncoder<AccountCaptureNotificationEmailsSentDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AccountCaptureNotificationEmailsSentDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("domain_name", value.DomainName, writer, enc.StringEncoder.Instance);
                if (value.NotificationType != null)
                {
                    WriteProperty("notification_type", value.NotificationType, writer, global::Dropbox.Api.TeamLog.AccountCaptureNotificationType.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AccountCaptureNotificationEmailsSentDetails"
        /// />.</para>
        /// </summary>
        private class AccountCaptureNotificationEmailsSentDetailsDecoder : enc.StructDecoder<AccountCaptureNotificationEmailsSentDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="AccountCaptureNotificationEmailsSentDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AccountCaptureNotificationEmailsSentDetails Create()
            {
                return new AccountCaptureNotificationEmailsSentDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AccountCaptureNotificationEmailsSentDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "domain_name":
                        value.DomainName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "notification_type":
                        value.NotificationType = global::Dropbox.Api.TeamLog.AccountCaptureNotificationType.Decoder.Decode(reader);
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
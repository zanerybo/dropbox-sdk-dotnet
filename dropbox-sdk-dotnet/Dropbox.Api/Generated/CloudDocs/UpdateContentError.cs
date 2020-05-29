// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.CloudDocs
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The update content error object</para>
    /// </summary>
    public class UpdateContentError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UpdateContentError> Encoder = new UpdateContentErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UpdateContentError> Decoder = new UpdateContentErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdateContentError" />
        /// class.</para>
        /// </summary>
        public UpdateContentError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UploadSizeTooLarge</para>
        /// </summary>
        public bool IsUploadSizeTooLarge
        {
            get
            {
                return this is UploadSizeTooLarge;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UploadSizeTooLarge, or <c>null</c>.</para>
        /// </summary>
        public UploadSizeTooLarge AsUploadSizeTooLarge
        {
            get
            {
                return this as UploadSizeTooLarge;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Conflict</para>
        /// </summary>
        public bool IsConflict
        {
            get
            {
                return this is Conflict;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Conflict, or <c>null</c>.</para>
        /// </summary>
        public Conflict AsConflict
        {
            get
            {
                return this as Conflict;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unlocked</para>
        /// </summary>
        public bool IsUnlocked
        {
            get
            {
                return this is Unlocked;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unlocked, or <c>null</c>.</para>
        /// </summary>
        public Unlocked AsUnlocked
        {
            get
            {
                return this as Unlocked;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidDocId</para>
        /// </summary>
        public bool IsInvalidDocId
        {
            get
            {
                return this is InvalidDocId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidDocId, or <c>null</c>.</para>
        /// </summary>
        public InvalidDocId AsInvalidDocId
        {
            get
            {
                return this as InvalidDocId;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotFound</para>
        /// </summary>
        public bool IsNotFound
        {
            get
            {
                return this is NotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotFound, or <c>null</c>.</para>
        /// </summary>
        public NotFound AsNotFound
        {
            get
            {
                return this as NotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PermissionDenied</para>
        /// </summary>
        public bool IsPermissionDenied
        {
            get
            {
                return this is PermissionDenied;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PermissionDenied, or <c>null</c>.</para>
        /// </summary>
        public PermissionDenied AsPermissionDenied
        {
            get
            {
                return this as PermissionDenied;
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
        /// <para>Encoder for  <see cref="UpdateContentError" />.</para>
        /// </summary>
        private class UpdateContentErrorEncoder : enc.StructEncoder<UpdateContentError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UpdateContentError value, enc.IJsonWriter writer)
            {
                if (value is UploadSizeTooLarge)
                {
                    WriteProperty(".tag", "upload_size_too_large", writer, enc.StringEncoder.Instance);
                    UploadSizeTooLarge.Encoder.EncodeFields((UploadSizeTooLarge)value, writer);
                    return;
                }
                if (value is Conflict)
                {
                    WriteProperty(".tag", "conflict", writer, enc.StringEncoder.Instance);
                    Conflict.Encoder.EncodeFields((Conflict)value, writer);
                    return;
                }
                if (value is Unlocked)
                {
                    WriteProperty(".tag", "unlocked", writer, enc.StringEncoder.Instance);
                    Unlocked.Encoder.EncodeFields((Unlocked)value, writer);
                    return;
                }
                if (value is InvalidDocId)
                {
                    WriteProperty(".tag", "invalid_doc_id", writer, enc.StringEncoder.Instance);
                    InvalidDocId.Encoder.EncodeFields((InvalidDocId)value, writer);
                    return;
                }
                if (value is NotFound)
                {
                    WriteProperty(".tag", "not_found", writer, enc.StringEncoder.Instance);
                    NotFound.Encoder.EncodeFields((NotFound)value, writer);
                    return;
                }
                if (value is PermissionDenied)
                {
                    WriteProperty(".tag", "permission_denied", writer, enc.StringEncoder.Instance);
                    PermissionDenied.Encoder.EncodeFields((PermissionDenied)value, writer);
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
        /// <para>Decoder for  <see cref="UpdateContentError" />.</para>
        /// </summary>
        private class UpdateContentErrorDecoder : enc.UnionDecoder<UpdateContentError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UpdateContentError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UpdateContentError Create()
            {
                return new UpdateContentError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override UpdateContentError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "upload_size_too_large":
                        return UploadSizeTooLarge.Decoder.DecodeFields(reader);
                    case "conflict":
                        return Conflict.Decoder.DecodeFields(reader);
                    case "unlocked":
                        return Unlocked.Decoder.DecodeFields(reader);
                    case "invalid_doc_id":
                        return InvalidDocId.Decoder.DecodeFields(reader);
                    case "not_found":
                        return NotFound.Decoder.DecodeFields(reader);
                    case "permission_denied":
                        return PermissionDenied.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Upload payload exceeds maximum allowed size of 150MB.</para>
        /// </summary>
        public sealed class UploadSizeTooLarge : UpdateContentError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UploadSizeTooLarge> Encoder = new UploadSizeTooLargeEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UploadSizeTooLarge> Decoder = new UploadSizeTooLargeDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UploadSizeTooLarge" />
            /// class.</para>
            /// </summary>
            private UploadSizeTooLarge()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UploadSizeTooLarge</para>
            /// </summary>
            public static readonly UploadSizeTooLarge Instance = new UploadSizeTooLarge();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UploadSizeTooLarge" />.</para>
            /// </summary>
            private class UploadSizeTooLargeEncoder : enc.StructEncoder<UploadSizeTooLarge>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UploadSizeTooLarge value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UploadSizeTooLarge" />.</para>
            /// </summary>
            private class UploadSizeTooLargeDecoder : enc.StructDecoder<UploadSizeTooLarge>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UploadSizeTooLarge"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UploadSizeTooLarge Create()
                {
                    return UploadSizeTooLarge.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>A lock on the document identified by path_or_id is held by another
        /// editor.</para>
        /// </summary>
        public sealed class Conflict : UpdateContentError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Conflict> Encoder = new ConflictEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Conflict> Decoder = new ConflictDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Conflict" /> class.</para>
            /// </summary>
            private Conflict()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Conflict</para>
            /// </summary>
            public static readonly Conflict Instance = new Conflict();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Conflict" />.</para>
            /// </summary>
            private class ConflictEncoder : enc.StructEncoder<Conflict>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Conflict value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Conflict" />.</para>
            /// </summary>
            private class ConflictDecoder : enc.StructDecoder<Conflict>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Conflict" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Conflict Create()
                {
                    return Conflict.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>A lock is not held on the document identified by path_or_id. Acquire lock
        /// before uploading content for the document.</para>
        /// </summary>
        public sealed class Unlocked : UpdateContentError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unlocked> Encoder = new UnlockedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unlocked> Decoder = new UnlockedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unlocked" /> class.</para>
            /// </summary>
            private Unlocked()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unlocked</para>
            /// </summary>
            public static readonly Unlocked Instance = new Unlocked();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unlocked" />.</para>
            /// </summary>
            private class UnlockedEncoder : enc.StructEncoder<Unlocked>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unlocked value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unlocked" />.</para>
            /// </summary>
            private class UnlockedDecoder : enc.StructDecoder<Unlocked>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unlocked" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unlocked Create()
                {
                    return Unlocked.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The Cloud Doc ID is invalid.</para>
        /// </summary>
        public sealed class InvalidDocId : UpdateContentError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidDocId> Encoder = new InvalidDocIdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidDocId> Decoder = new InvalidDocIdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidDocId" />
            /// class.</para>
            /// </summary>
            private InvalidDocId()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidDocId</para>
            /// </summary>
            public static readonly InvalidDocId Instance = new InvalidDocId();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidDocId" />.</para>
            /// </summary>
            private class InvalidDocIdEncoder : enc.StructEncoder<InvalidDocId>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidDocId value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidDocId" />.</para>
            /// </summary>
            private class InvalidDocIdDecoder : enc.StructDecoder<InvalidDocId>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidDocId" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidDocId Create()
                {
                    return InvalidDocId.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>A Cloud Doc could not be found for the given ID.</para>
        /// </summary>
        public sealed class NotFound : UpdateContentError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotFound> Encoder = new NotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotFound> Decoder = new NotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotFound" /> class.</para>
            /// </summary>
            private NotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotFound</para>
            /// </summary>
            public static readonly NotFound Instance = new NotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundEncoder : enc.StructEncoder<NotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundDecoder : enc.StructDecoder<NotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotFound Create()
                {
                    return NotFound.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Permission denied for the Cloud Doc with the given ID.</para>
        /// </summary>
        public sealed class PermissionDenied : UpdateContentError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PermissionDenied> Encoder = new PermissionDeniedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PermissionDenied> Decoder = new PermissionDeniedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PermissionDenied" />
            /// class.</para>
            /// </summary>
            private PermissionDenied()
            {
            }

            /// <summary>
            /// <para>A singleton instance of PermissionDenied</para>
            /// </summary>
            public static readonly PermissionDenied Instance = new PermissionDenied();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PermissionDenied" />.</para>
            /// </summary>
            private class PermissionDeniedEncoder : enc.StructEncoder<PermissionDenied>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PermissionDenied value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PermissionDenied" />.</para>
            /// </summary>
            private class PermissionDeniedDecoder : enc.StructDecoder<PermissionDenied>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PermissionDenied" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PermissionDenied Create()
                {
                    return PermissionDenied.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : UpdateContentError
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
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
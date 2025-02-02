﻿// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Nerdbank.Streams
{
    /// <content>
    /// Contains the <see cref="ControlCode"/> nested type.
    /// </content>
    public partial class MultiplexingStream
    {
        /// <summary>
        /// Signals what kind of frame is being transmitted.
        /// </summary>
        internal enum ControlCode : byte
        {
            /// <summary>
            /// A channel is proposed to the remote party.
            /// </summary>
            Offer,

            /// <summary>
            /// A channel proposal has been accepted.
            /// </summary>
            OfferAccepted,

            /// <summary>
            /// The payload of the frame is a payload intended for channel consumption.
            /// </summary>
            Content,

            /// <summary>
            /// Sent after all bytes have been transmitted on a given channel. Either or both sides may send this.
            /// A channel may be automatically closed when each side has both transmitted and received this message.
            /// </summary>
            ContentWritingCompleted,

            /// <summary>
            /// Sent when a channel is closed, an incoming offer is rejected, or an outgoing offer is canceled.
            /// </summary>
            ChannelTerminated,

            /// <summary>
            /// Sent when a channel has finished processing data received from the remote party,
            /// allowing them to send more data.
            /// </summary>
            ContentProcessed,

            /// <summary>
            /// Sent when one party experiences an exception related to a particular channel and carries details regarding the error,
            /// when using protocol version 2 or later.
            /// This is sent before a <see cref="ContentWritingCompleted"/> frame closes that channel.
            /// </summary>
            ContentWritingError,
        }
    }
}

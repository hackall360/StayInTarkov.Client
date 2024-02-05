﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayInTarkov.Networking
{
    /// <summary>
    /// Which Protocol the Connections of the Clients to Server to Clients are using
    /// </summary>
    public enum ESITProtocol : int
    {
        /// <summary>
        /// Peer to Peer connections over UDP
        /// </summary>
        PeerToPeerUdp = 0,

        /// <summary>
        /// Relay TCP between SIT Client -> Web Server -> SIT Client
        /// </summary>
        RelayTcp = 1,

        /// <summary>
        /// Currently unused
        /// </summary>
        PeerToPeerTcp = 2,
    }
}

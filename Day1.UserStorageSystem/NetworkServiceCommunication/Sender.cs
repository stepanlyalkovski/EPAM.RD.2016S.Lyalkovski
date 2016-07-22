﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using NetworkServiceCommunication.Entities;

namespace NetworkServiceCommunication
{
    public class Sender<TEntity> : IDisposable
    {
        private IList<Socket> sockets = new List<Socket>();
        private IPEndPoint _ipEndPoint;
        public Sender(IPAddress address, int port)
        {
            IPAddress ipAddr = address;
            _ipEndPoint = new IPEndPoint(ipAddr, port);
        }

        public void Connect(IEnumerable<IPEndPoint> ipEndPoints)
        {
            foreach (var ipEndPoint in ipEndPoints)
            {
                var socket = new Socket(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipEndPoint);
                sockets.Add(socket);
            }

        }
        public void Send(ServiceMessage<TEntity> message)
        {
            foreach (var socket in sockets)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (NetworkStream networkStream = new NetworkStream(socket, false))
                {
                    formatter.Serialize(networkStream, message);
                }
            }
        }

        public void Dispose()
        {
            foreach (var socket in sockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}
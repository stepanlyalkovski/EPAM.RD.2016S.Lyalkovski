﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using NetworkServiceCommunication;
using NUnit.Framework;
using Task1.StorageSystem.Concrete.Services;
using Task1.StorageSystem.Entities;

namespace Task1.Tests
{
    [TestFixture]
    public class UserServiceCommunicatorTests
    {
        [Test]
        public void SendAddMessage_ServiceCommunicatorWithSenderAndTwoCommunicatorsWithReceivers_ConnectionEstablishedAndMessageReceivedByTwoCommunicators()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress receiverAddress = null;
            int receiverPort1 = 2020;
            int receiverPort2 = 2021;
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    receiverAddress = ip;
                }
            }

            Sender<User> sender = new Sender<User>();
            Receiver<User> slaveReceiver1 = new Receiver<User>(receiverAddress, receiverPort1);
            Receiver<User> slaveReceiver2 = new Receiver<User>(receiverAddress, receiverPort2);
            UserServiceCommunicator masterCommunicator = new UserServiceCommunicator(sender);
            UserServiceCommunicator slaveCommunicator1 = new UserServiceCommunicator(slaveReceiver1);
            UserServiceCommunicator slaveCommunicator2 = new UserServiceCommunicator(slaveReceiver2);
            masterCommunicator.ConnectGroup(new[] { slaveReceiver1.IpEndPoint, slaveReceiver2.IpEndPoint });
            slaveCommunicator1.RunReceiver();
            slaveCommunicator2.RunReceiver();
            slaveCommunicator1.UserAdded += (o, args) => Console.WriteLine("Event Generated in Slave 1! " + args.User.LastName);
            slaveCommunicator2.UserAdded += (o, args) => Console.WriteLine("Event Generated in Slave 2! " + args.User.LastName);
            masterCommunicator.SendAdd(new UserDataApdatedEventArgs { User = new User { LastName = "Smith" } });
            Thread.Sleep(2000);

            slaveCommunicator2.StopReceiver();
            slaveCommunicator1.StopReceiver();
            masterCommunicator.Dispose();
            slaveCommunicator2.Dispose();
            slaveCommunicator1.Dispose();
        }

        [Test]
        public void Test()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress receiverAddress = null;
            int receiverPort1 = 2020;
            int receiverPort2 = 2021;

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    receiverAddress = ip;
                }
            }

            Sender<User> sender = new Sender<User>();
            Receiver<User> slaveReceiver = new Receiver<User>(receiverAddress, receiverPort1);
            Receiver<User> slaveReceiver2 = new Receiver<User>(receiverAddress, receiverPort2);
            UserServiceCommunicator masterCommunicator = new UserServiceCommunicator(sender);
            UserServiceCommunicator slaveCommunicator = new UserServiceCommunicator(slaveReceiver);
            UserServiceCommunicator slaveCommunicator2 = new UserServiceCommunicator(slaveReceiver2);
            slaveCommunicator.RunReceiver();
            slaveCommunicator2.RunReceiver();
            masterCommunicator.ConnectGroup(new[] { slaveReceiver.IpEndPoint, slaveReceiver2.IpEndPoint });
            slaveCommunicator2.UserAdded += (o, args) => Console.WriteLine("Event Generated in Slave 2! " + args.User.LastName);
            slaveCommunicator.UserAdded += (o, args) => Console.WriteLine("Event Generated in Slave ! " + args.User.LastName);
            masterCommunicator.SendAdd(new UserDataApdatedEventArgs { User = new User { LastName = "Smith" } });
        }
    }
}
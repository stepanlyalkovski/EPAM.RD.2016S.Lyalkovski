﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ServiceConfigurator.Entities;
using Task1.StorageSystem.Concrete.Services;

namespace ServiceConfigurator
{
    public static class UserServiceInitializer
    {
        /// <summary>
        /// Initialize application services with configuration from app.config
        /// </summary>
        /// <returns>User service collection</returns>
        public static IEnumerable<UserService> InitializeServices()
        {           
            var serviceConfigurations = ConfigParser.ParseServiceConfigSection();
            var dependencyConfugiration = ConfigParser.ParseDependencyConfiguration();
            var configurations = serviceConfigurations as IList<ServiceConfiguration> ?? serviceConfigurations.ToList();

            IList<UserService> services = UserServiceCreator.CreateServices(configurations).ToList();

            InitializeComponents(services, configurations, dependencyConfugiration);

            return services;     
        }

        /// <summary>
        /// Add some components to created services. Establish connection between master and slaves
        /// </summary>
        /// <param name="services">created services</param>
        /// <param name="configurations">application configuration parsed from app.config</param>
        /// <param name="dependencyConfiguration">dependency configuration parsed from app.config</param>
        private static void InitializeComponents(IEnumerable<UserService> services, IEnumerable<ServiceConfiguration> configurations, DependencyConfiguration dependencyConfiguration)
        {
            var userServices = services as IList<UserService> ?? services.ToList();

            var master = (MasterUserService)userServices.FirstOrDefault(s => s is MasterUserService);

            var slaves = userServices.OfType<SlaveUserService>().ToList();

            // master.Communicator.ConnectGroup(slavesAddresses);
            DependencyInitializer.InitalizeDependencies(master, dependencyConfiguration);
            foreach (var slaveUserService in slaves)
            {
                slaveUserService.Communicator.RunReceiver();
            }

            foreach (var userService in services)
            {
                WcfServiceInitializer.CreateWcfService(userService);
            }

            // SubscribeServices(master, slaves);
            // Thread.Sleep(10000);
            // ThreadInitializer.InitializeThreads(master, slaves);
        }
    }
}

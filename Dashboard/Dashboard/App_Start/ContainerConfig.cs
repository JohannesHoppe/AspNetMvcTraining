﻿using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Dashboard.Models;
using FakeDbSet;
using Moq;

namespace Dashboard
{
    /// <summary>
    /// Wires up Autofac
    /// </summary>
    public static class ContainerConfig
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<FakedGutachterRepository>()
                .As<IGutachterRepository>()
                .InstancePerRequest();

            return builder.Build();
        }
    }
}
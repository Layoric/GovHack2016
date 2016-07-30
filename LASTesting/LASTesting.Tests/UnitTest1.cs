using System;
using System.IO;
using NUnit.Framework;
using LASTesting.ServiceInterface;
using LASTesting.ServiceModel;
using LASTesting.ServiceModel.Types;
using Microsoft.Win32.SafeHandles;
using ServiceStack.Testing;
using ServiceStack;

namespace LASTesting.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private readonly ServiceStackHost appHost;

        public UnitTests()
        {
            appHost = new BasicAppHost(typeof(MyServices).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //Add your IoC dependencies here
                }
            }
            .Init();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            appHost.Dispose();
        }

        [Test]
        public void TestMethod1()
        {
            var service = appHost.Container.Resolve<MyServices>();

            var response = (HelloResponse)service.Any(new Hello { Name = "World" });

            Assert.That(response.Result, Is.EqualTo("Hello, World!"));
        }

        [Test]
        public void TryLoadLasFileHeader()
        {
            LASHeader header = new LASHeader();
            using (var fs = File.OpenRead("C:\\Temp\\ACT2015-C3-ORT_6826096_55_0002_0002.LAS"))
            {
                BinaryReader reader = new BinaryReader(fs);
                header.FileSig = new string(reader.ReadChars(4));
                header.SourceId = reader.ReadUInt16();
                header.GlobalEncoding = reader.ReadUInt16();
                header.ProjectGuid1 = reader.ReadInt64();
                header.ProjectGuid2 = reader.ReadUInt16();
                header.ProjectGuid3 = reader.ReadUInt16();
                header.ProjectGuid4 = new string(reader.ReadChars(8));
                header.MarjorVersion = reader.ReadChar();
                header.MinorVersion = reader.ReadChar();
                header.SystemId = new string(reader.ReadChars(32));
                header.GeneratingSoftware = new string(reader.ReadChars(32));
                
            }
        }
    }
}

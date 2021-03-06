﻿#region Using Statements
using System.IO;

using Cake.Core;
using Cake.Core.IO;
using Cake.Testing;

using Cake.AWS.S3;
#endregion



namespace Cake.AWS.CloudFront.Tests
{
    internal static class CakeHelper
    {
        #region Methods
        public static ICakeEnvironment CreateEnvironment()
        {
            var environment = FakeEnvironment.CreateWindowsEnvironment();
            environment.WorkingDirectory = Directory.GetCurrentDirectory();
            environment.WorkingDirectory = environment.WorkingDirectory.Combine("../../../");

            return environment;
        }



        public static IS3Manager CreateS3Manager()
        {
            return new S3Manager(new FileSystem(), CakeHelper.CreateEnvironment(), new DebugLog());
        }

        public static ICloudFrontManager CreateCloudFrontManager()
        {
            return new CloudFrontManager(CakeHelper.CreateEnvironment(), new DebugLog());
        }
        #endregion
    }
}

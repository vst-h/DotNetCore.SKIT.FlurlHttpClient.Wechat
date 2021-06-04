﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.Wechat.Work.UnitTests
{
    public class WechatWorkDeclarationTests
    {
        private static readonly Assembly _assembly = Assembly.Load("SKIT.FlurlHttpClient.Wechat.Work");

        [Fact(DisplayName = "验证 API 模型命名")]
        public void ApiModelsNamingTest()
        {
            TestAssertUtil.VerifyApiModelsNaming(_assembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 模型定义")]
        public void ApiModelsDefinitionTest()
        {
            string workdir = Path.Combine(Environment.CurrentDirectory, "ModelSamples");
            Assert.True(Directory.Exists(workdir));

            TestAssertUtil.VerifyApiModelsDefinition(_assembly, workdir, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }

        [Fact(DisplayName = "验证 API 接口命名")]
        public void ApiExtensionsNamingTest()
        {
            TestAssertUtil.VerifyApiExtensionsNaming(_assembly, out var ex);

            if (ex != null)
                throw ex;

            Assert.Null(ex);
        }
    }
}

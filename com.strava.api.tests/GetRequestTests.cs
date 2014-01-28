﻿using System;
using com.strava.api.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.strava.api.tests
{
    [TestClass]
    public class GetRequestTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExecuteNull()
        {
            GetRequest r = new GetRequest();
            r.Execute(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestExecuteEmpty()
        {
            GetRequest r = new GetRequest();
            r.Execute(String.Empty);
        }
    }
}

﻿using System.Threading.Tasks;
using NUnit.Framework;

namespace Meetup.Api.IntegrationTests.Services
{
    [TestFixture]
    public class MeetupApiIntegrationTests
    {
        [Test]
        public async Task GetStatus_ReturnTrue()
        {
            var result = await MeetupApi.GetStatus();

            Assert.IsTrue(result);
        }
    }
}

﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            GoToHomePage();
            Login(new AccountData ("admin","secret"));
            GoToGroupPage();
            SelectGroup();
            RemoveGroup(1);
            ReturnToGroupsPage();
            Logout();
        }
    }
}

using System;
using System.Linq;
using Xero.Api.Core;
using Xero.Api.Core.Model;
using Xero.Api.Example.TokenStores;
using Xero.Api.Infrastructure.OAuth;

namespace CoreTests
{
    public class ApiWrapperTest
    {
        private IXeroCoreApi _api;

        protected Account BankAccount { get; set; }
        protected Account Account { get; set; }
        
        protected IXeroCoreApi Api
        {
            get { return _api ?? (_api = CreateCoreApi()); }
        }

        private static IXeroCoreApi CreateCoreApi()
        {
            var user = new ApiUser { Name = Environment.MachineName };
            var tokenStore = new SqliteTokenStore();
            return new Xero.Api.Example.Applications.Public.Core(tokenStore, user)
            {
                UserAgent = "Xero Api - Integration tests"
            };
        }

        protected void SetUp()
        {
            BankAccount = Given_a_bank_account();
            Account = Given_an_account();
        }

        protected Account Given_a_bank_account()
        {
            return Api.Accounts.Where("Type == \"BANK\"").Find().First();
        }

        protected Account Given_an_account()
        {
            return Api.Accounts.Where("Type != \"BANK\"").Find().First();
        }
    }
}

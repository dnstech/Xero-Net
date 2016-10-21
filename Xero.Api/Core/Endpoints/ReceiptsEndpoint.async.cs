﻿using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public partial interface IReceiptsEndpoint : IAsyncXeroUpdateEndpoint<ReceiptsEndpoint, Receipt, ReceiptsRequest, ReceiptsResponse>
    {

    }
}
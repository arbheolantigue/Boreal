using IQ.Platform.Framework.WebApi.AspNet;
using IQ.Platform.Framework.WebApi.AspNet.Handlers;
using IQ.Platform.Framework.WebApi.Services.Security;
using Boreal.ApiServices.Security;

namespace Boreal.WebApi.Handlers
{
    public class PutYourApiSafeNameUserContextProvidingHandler
            : ApiSecurityContextProvidingHandler<BorealApiUser, NullUserContext>
    {

        public PutYourApiSafeNameUserContextProvidingHandler(
            IStoreDataInHttpRequest<BorealApiUser> apiUserInRequestStore)
            : base(new BorealUserFactory(), CreateContextProvider(), apiUserInRequestStore)
        {
        }

        static ApiUserContextProvider<BorealApiUser, NullUserContext> CreateContextProvider()
        {
            return
                new ApiUserContextProvider<BorealApiUser, NullUserContext>(_ => new NullUserContext());
        }
    }
}
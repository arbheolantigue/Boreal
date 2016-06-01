using IQ.Platform.Framework.Common;
using IQ.Platform.Framework.WebApi.AspNet;
using IQ.Platform.Framework.WebApi.Services.Security;

namespace Boreal.ApiServices.Security
{

    public class BorealApiUser : ApiUser<UserAuthData>
    {
        public BorealApiUser(string name, Option<UserAuthData> authData)
            : base(authData)
        {
            Name = name;
        }

        public string Name { get; private set; }

    }

    public class BorealUserFactory : ApiUserFactory<BorealApiUser, UserAuthData>
    {
        public BorealUserFactory() :
            base(new HttpRequestDataStore<UserAuthData>())
        {
        }

        protected override BorealApiUser CreateUser(Option<UserAuthData> auth)
        {
            return new BorealApiUser("Boreal user", auth);
        }
    }

}

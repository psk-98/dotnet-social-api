using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Models;

namespace dotnet_social_api.Interface;

public interface ITokenService
{
    string CreateToken(UserProfile user);

}

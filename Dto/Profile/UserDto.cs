using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.Profile;
public class UserDto
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string Bio { get; set; }
    public string Website { get; set; }
    public DateTime DateJoined { get; set; }
    public int Followers { get; set; }
    public int Following { get; set; }
}

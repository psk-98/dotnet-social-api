using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_social_api.Dto.MessageThread;

public class CreateMessageThreadDto
{
    public string UserOneId { get; set; }
    public string UserTwoId { get; set; }
}

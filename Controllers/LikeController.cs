using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_social_api.Interface;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_social_api.Controllers;

[Route("api/like")]
[ApiController]
public class LikeController : ControllerBase
{
    private readonly ILikeRepository _likeRepo;
    public LikeController(ILikeRepository likeRepo)
    {
        _likeRepo = likeRepo;
    }
}

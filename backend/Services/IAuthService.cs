﻿using System;
using backend.DTOs.Auth;
using backend.DTOs.CartItem;
using backend.DTOs.User;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Services;

public interface IAuthService
{
    Task<ServiceResponse<AuthUserRespDTO>> Login(AuthUserReqDTO request);
}


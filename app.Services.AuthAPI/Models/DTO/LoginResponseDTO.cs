﻿namespace app.Services.AuthAPI.Models.DTO
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
        public ResponseDTO Response { get; set; }
    }
}

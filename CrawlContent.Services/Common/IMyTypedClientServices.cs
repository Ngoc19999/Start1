﻿using Microsoft.AspNetCore.Http;

namespace General.Services
{
    public interface IMyTypedClientServices
    {
        public  UploadImagesResponse PostImgAndGetData(List<IFormFile> files, int width, int Obj_Id,int userId, int type);

    }
}

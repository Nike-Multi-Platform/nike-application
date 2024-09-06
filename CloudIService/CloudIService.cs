﻿using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.CloudIService
{
    class CloudIService
    {
        private Cloudinary _cloudinary;

        // Constructor để khởi tạo Cloudinary với tài khoản của bạn
        public CloudIService(string cloudName, string apiKey, string apiSecret)
        {
            var account = new Account(cloudName, apiKey, apiSecret);
            _cloudinary = new Cloudinary(account);
            _cloudinary.Api.Secure = true; // Đảm bảo sử dụng HTTPS
        }

        // Hàm để upload hình ảnh
        public string UploadImage(string filePath)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(filePath)
            };

            var uploadResult = _cloudinary.Upload(uploadParams);
            return uploadResult.SecureUrl.AbsoluteUri; // Trả về URL bảo mật của hình ảnh
        }

        // Hàm để upload video
        public string UploadVideo(string filePath)
        {
            var uploadParams = new VideoUploadParams()
            {
                File = new FileDescription(filePath)
            };

            var uploadResult = _cloudinary.Upload(uploadParams);
            return uploadResult.SecureUrl.AbsoluteUri;
        }

        // Hàm để tạo URL với biến đổi hình ảnh
        public string TransformImage(string publicId, int width, int height)
        {
            return _cloudinary.Api.UrlImgUp.Transform(new Transformation()
                .Width(width).Height(height).Crop("fill"))
                .BuildUrl(publicId);
        }
    }
}

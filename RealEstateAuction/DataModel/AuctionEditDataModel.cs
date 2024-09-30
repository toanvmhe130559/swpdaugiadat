﻿using RealEstateAuction.Models;
using System.ComponentModel.DataAnnotations;

namespace RealEstateAuction.DataModel
{
    public class AuctionEditDataModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tiêu đề phiên đấu giá")]
        [MinLength(15, ErrorMessage = "Tiêu đề tối thiểu 15 ký tự.")]
        public string Title { get; set; }
        public decimal StartPrice { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá kết thúc")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Giá kết thúc phải lớn hơn 0.")]
        public decimal EndPrice { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập diện tích")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Diện tích phải lớn hơn 0.")]
        public double Area { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mặt tiền")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Diện tích mặt tiền phải lớn hơn 0.")]
        public double Facade { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn hướng")]
        public string Direction { get; set; }

        [Required(ErrorMessage = "Vui lòng mô tả bất động sản")]
        public string Description { get; set; }

        public int? UserId { get; set; }

        public int? ApproverId { get; set; }

        public byte? Status { get; set; }

        public bool? DeleteFlag { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày bắt đầu")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập ngày kết thúc")]
        public DateTime EndTime { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }
        public ICollection<IFormFile>? ImageFiles { get; set; }

        public ICollection<Image>? Images { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace BTL_Demo2.ViewModels
{
	public class RegisterVM
	{
		[Display(Name = "Họ và tên")]
		[Required(ErrorMessage = "Vui lòng nhập tên của bạn")]
		[MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
		public string TenKH { get; set; }

		//[Display(Name = "Ngày sinh")]
		//[DataType(DataType.Date)]
		//public DateTime? NgaySinh { get; set; }

		[Display(Name = "Điện thoại")]
		[Key]
		[MaxLength(24, ErrorMessage = "Tối đa 24 kí tự")]
		[RegularExpression(@"0\d{9}", ErrorMessage = "Chưa đúng định dạng")]
		public string DienThoai { get; set; }

		[Display(Name = "Email")]
		[EmailAddress(ErrorMessage = "Chưa đúng định dạng email")]
		public string Email { get; set; }

		//[Display(Name = "Loại khách hàng")]
		//[Required(ErrorMessage = "Vui lòng chọn loại khách hàng")]
		//public CustomerType CustomerType { get; set; }

		[Display(Name = "Địa chỉ")]
		[MaxLength(60, ErrorMessage = "Tối đa 60 kí tự")]
		public string? DiaChi { get; set; } // Optional for dine-in and take-away

        [Display(Name = "Phương thức phục vụ")]
        [Required(ErrorMessage = "Vui lòng chọn phương thức phục vụ")]
        public string PhuongThuc { get; set; }
    }

	public enum CustomerType
	{
		DineIn,
		TakeAway,
		Delivery
	}
}

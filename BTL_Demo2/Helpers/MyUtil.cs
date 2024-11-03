using System.Text;

namespace BTL_Demo2.Helpers
{
	public class MyUtil
	{
		public static string GenerateCustomerKey(int length = 8)
		{
			if (length < 2) // Đảm bảo độ dài tối thiểu cho "KH"
			{
				throw new ArgumentException("Length must be at least 2 characters.");
			}

			var sb = new StringBuilder("KH"); // Bắt đầu với "KH"
			var rd = new Random();
			var digits = "0123456789"; // Chỉ số từ 0 đến 9

			// Tạo phần còn lại của mã
			for (int i = 2; i < length; i++)
			{
				sb.Append(digits[rd.Next(0, digits.Length)]); // Thêm số ngẫu nhiên
			}

			return sb.ToString();
		}

	}
}

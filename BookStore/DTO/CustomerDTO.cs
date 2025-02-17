using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace BookStore.DTO
{
    internal class CustomerDTO
    {
        [DisplayName("Mã KH")]
        public long CustomerId { get; set; }
        [DisplayName("Tên")]
        public string FirstName { get; set; } = null!;
        [DisplayName("Họ")]

        public string LastName { get; set; } = null!;
        [DisplayName("Ngày sinh")]

        public DateTime DateOfBirth { get; set; }
        [DisplayName("Giới tính")]

        public string Gender { get; set; } = null!;
        [DisplayName("Email")]

        public string CustomerEmail { get; set; } = null!;
        [DisplayName("Số điện thoại")]

        public string CustomerPhone { get; set; } = null!;
        [DisplayName("Địa chỉ")]

        public string CustomerAddress { get; set; } = null!;
    }
}

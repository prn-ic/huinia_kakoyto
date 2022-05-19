using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniFull.ClientAppOnWPF.MVVM.Model
{
    class UserModel
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Vk { get; set; }
        public string? Telegram { get; set; }
        public string? Description { get; set; }
        public int NotificationId { get; set; }
        public string? Status { get; set; }
    }
}

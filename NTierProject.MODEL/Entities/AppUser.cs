using NTierProject.CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierProject.MODEL.Entities
{
    public class AppUser : CoreEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez!")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil!")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir email adresi giriniz!")]
        public string EMail { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ImagePath { get; set; }
        public Role? UserRole { get; set; }
        public DateTime? BirthDate { get; set; }

        //Mapping

        public List<Order> Orders { get; set; }
    }

    public enum Role
    {
        Banned = 0,
        Member = 1,
        Admin = 2
    }

}

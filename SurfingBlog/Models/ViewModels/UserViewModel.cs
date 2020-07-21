using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurfingBlog.Models.ViewModels
{
    public class UserViewModel
    {
        /// <summary>
        /// Псевдоним
        /// </summary>
        [Display(Name = "Псевдоним")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [MaxLength(20, ErrorMessage = "Слишком длинный псевдоним, допустимо до 20 символов")]
        public string Nickname { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [MaxLength(20, ErrorMessage = "Слишком длинный пароль, допустимо до 20 символов")]
        public string Password { get; set; }

        /// <summary>
        /// Запомнить пароль
        /// </summary>
        [Display(Name = "Запомнить пароль")]
        public bool Remember { get; set; }
    }
}
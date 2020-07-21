using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SurfingBlog.Models.DBModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Псевдоним
        /// </summary>
        [Display(Name = "Псевдоним")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Слишком короткий псевдоним, допустимо от 3 символов")]
        [MaxLength(20, ErrorMessage = "Слишком длинный псевдоним, допустимо до 20 символов")]
        public string Nickname { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [MaxLength(31, ErrorMessage = "Слишком длинная почта, допустимо до 31 символа")]
        public string Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [MinLength(6, ErrorMessage = "Слишком короткий пароль, допустимо от 6 символов")]
        [MaxLength(20, ErrorMessage = "Слишком длинный пароль, допустимо до 20 символов")]
        public string Password { get; set; }

        /// <summary>
        /// Повторить пароль
        /// </summary>
        [Display(Name = "Подтвердите пароль")]
        [NotMapped]
        public string PasswordConfirm { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Display(Name = "Фамилия")]
        [MaxLength(31, ErrorMessage = "Слишком длинная фамилия, допустимо до 31 символа")]
        public string LastName { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Display(Name = "Имя")]
        [MaxLength(31, ErrorMessage = "Слишком длинное имя, допустимо до 31 символа")]
        public string Name { get; set; }

        /// <summary>
        /// Изображение
        /// </summary>
        [Display(Name = "Выберите фото")]
        public Guid Photo { get; set; }

        /// <summary>
        /// Контактная информация
        /// </summary>
        [Display(Name = "Контактная информация")]
        [MaxLength(255, ErrorMessage = "Допустимо до 255 символов")]
        public string ContactInf { get; set; }

        /// <summary>
        /// О себе
        /// </summary>
        [Display(Name = "О себе")]
        [MaxLength(255, ErrorMessage = "Допустимо до 255 символов")]
        public string About { get; set; }

        /// <summary>
        /// Достижения
        /// </summary>
        [Display(Name = "Достижения")]
        [MaxLength(255, ErrorMessage = "Допустимо до 255 символов")]
        public string Progress { get; set; }
    }
}
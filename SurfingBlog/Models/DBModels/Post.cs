using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurfingBlog.Models.DBModels
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Текст
        /// </summary>
        [Display(Name = "Введите текст")]
        [MaxLength(4095, ErrorMessage = "Допустимо до 4095 символов")]
        public string Text { get; set; }

        /// <summary>
        /// Изображение
        /// </summary>
        [Display(Name = "Прикрепить изображение")]
        public Guid Photo { get; set; }

        /// <summary>
        /// Дата публикации
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// Автор записи
        /// </summary>
        public virtual User Author { get; set; }
    }
}
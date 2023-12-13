﻿using BilConnect.Data.Base;
using BilConnect.Data.Enums;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilConnect.Models.PostModels
{
    public class Post : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Post Description")]
        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime PostDate { get; set; }

        public PostStatus PostStatus { get; set; }

        //Relationshpis

        //User
        public string UserId { get; set; }
        [ForeignKey("UserId")]

        // Navigation property for User
        public virtual ApplicationUser? User { get; set; }

    }
}

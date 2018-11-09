using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SnekWebsite.Models
{
    public class Snake
    {
        [Key]
        public int snakeID { get; set; }
        public string snakeName { get; set; }
        public string ownerName { get; set; }
        public string snakeBreed { get; set; }
        public string snakeAge { get; set; }
        public string linkToPic { get; set; }
    }
}
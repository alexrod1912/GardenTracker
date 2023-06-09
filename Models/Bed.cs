﻿using System;

namespace Tracker.Models
{
    public class Bed
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? UserId { get; set; }
        public ICollection<Seed>? Seeds { get; set; }


    public Bed(string name, string userId)
        {
            Name = name;
            Seeds = new List<Seed>();
            UserId = userId;
        }
         public Bed() 
        {
            Seeds = new List<Seed>();
        }    
       
    }
}

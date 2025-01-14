﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCC75_MVC.Models;

[Table("tb_m_universities")]

public class University
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Required, Column("name"), MaxLength(100)]
    public string Name { get; set; }

    // Cardinality
    // Many
    public ICollection<Education>? Educations { get; set; }
}

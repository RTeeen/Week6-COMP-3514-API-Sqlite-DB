using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Province {
  [Key]
  [Required]
  [DatabaseGenerated(DatabaseGeneratedOption.None)]
  public string ProvinceCode { get; set; }
  public string ProvinceName { get; set; }
  public List<City> Cities { get; set; }
}
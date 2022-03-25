using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    [DisplayName("Date Hired")]
    public DateTime HireDate { get; set; }

    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}
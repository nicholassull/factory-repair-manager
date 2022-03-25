using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Model { get; set; }
    [DisplayName("Operational Status")]
    public string OperationalStatus { get; set; }
    
    [DisplayName("Last Serviced")]
    public DateTime LastServiced { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}
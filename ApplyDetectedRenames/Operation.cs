using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyDetectedRenames
{
  public class Operation
  {
    public OperationType OperationType { get; set; }
    public string Source { get; set; }
    public string SourceRelative { get; set; }
    public string Destination { get; set; }
    public string DestinationRelative { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyDetectedRenames
{
  public class OperationError
  {
    public Operation Operation { get; set; }
    public Exception Exception { get; set; }
  }
}

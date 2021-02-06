using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyDetectedRenames
{
  public class ResultSummary
  {
    public List<Operation> Operations = new List<Operation>();
    public List<OperationError> Errors = new List<OperationError>();
    public Exception FailureReason { get; set; }
  }
}

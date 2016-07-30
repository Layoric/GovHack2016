using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASTesting.ServiceModel.Types
{
    public class VariableLengthHeader
    {
        ushort Reserved { get; set; }
        string UserId { get; set; }
        ushort RecordId { get; set; }
        ushort RecordIdAfterHeader { get; set; }
        string Description { get; set; }
    }
}

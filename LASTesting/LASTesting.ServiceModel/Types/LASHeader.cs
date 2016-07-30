using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASTesting.ServiceModel.Types
{
    public class LASHeader
    {
        public string FileSig { get; set; }
        public ushort SourceId { get; set; }
        public ushort GlobalEncoding { get; set; }
        public Int64 ProjectGuid1 { get; set; }
        public ushort ProjectGuid2 { get; set; }
        public ushort ProjectGuid3 { get; set; }
        public string ProjectGuid4 { get; set; }
        public char MarjorVersion { get; set; }
        public char MinorVersion { get; set; }
        public string SystemId { get; set; }
        public string GeneratingSoftware { get; set; }
        public ushort FileCreationDay { get; set; }
        public ushort FileCreationYear { get; set; }
        public ushort HeaderSize { get; set; }
        public ulong PointDataOffset { get; set; }
        public ulong NumberOfVariableRecords { get; set; }
        public char PointDataFormat { get; set; }
        public ushort PointDataLength { get; set; }

        private ulong LegacyNumberOfPointRecords { get; set; }
        private ulong[] LegacyNumberOfPointsByReturn { get; set; }

        public double XScaleFactor { get; set; }
        public double YScaleFactor { get; set; }
        public double ZScaleFactor { get; set; }
        public double XOffset { get; set; }
        public double YOffset { get; set; }
        public double ZOffset { get; set; }
        public double MaxX { get; set; }
        public double MinX { get; set; }
        public double MaxY { get; set; }
        public double MinY { get; set; }
        public double MaxZ { get; set; }
        public double MinZ { get; set; }

        public ulong StartWaveFormPacketRecord { get; set; }
        public ulong StartExtendedVariableLength { get; set; }
        public ulong NumberExtendedVariableLength { get; set; }
        public long NumberOfPointRecords { get; set; }
        public ulong[] NumberOfPointsReturned { get; set; }
    }
}

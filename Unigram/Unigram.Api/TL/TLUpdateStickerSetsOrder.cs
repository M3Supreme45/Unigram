// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateStickerSetsOrder : TLUpdateBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Masks = (1 << 0),
		}

		public bool IsMasks { get { return Flags.HasFlag(Flag.Masks); } set { Flags = value ? (Flags | Flag.Masks) : (Flags & ~Flag.Masks); } }

		public Flag Flags { get; set; }
		public TLVector<Int64> Order { get; set; }

		public TLUpdateStickerSetsOrder() { }
		public TLUpdateStickerSetsOrder(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateStickerSetsOrder; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Order = TLFactory.Read<TLVector<Int64>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xBB2D201);
			to.Write((Int32)Flags);
			to.WriteObject(Order);
		}
	}
}
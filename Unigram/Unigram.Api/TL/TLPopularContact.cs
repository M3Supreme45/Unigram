// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPopularContact : TLObject 
	{
		public Int64 ClientId { get; set; }
		public Int32 Importers { get; set; }

		public TLPopularContact() { }
		public TLPopularContact(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PopularContact; } }

		public override void Read(TLBinaryReader from)
		{
			ClientId = from.ReadInt64();
			Importers = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x5CE14175);
			to.Write(ClientId);
			to.Write(Importers);
		}
	}
}
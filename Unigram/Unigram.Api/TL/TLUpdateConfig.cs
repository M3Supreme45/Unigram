// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateConfig : TLUpdateBase 
	{
		public TLUpdateConfig() { }
		public TLUpdateConfig(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateConfig; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA229DD06);
		}
	}
}
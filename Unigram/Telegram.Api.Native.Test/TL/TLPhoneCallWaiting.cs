// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPhoneCallWaiting : TLPhoneCallBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			ReceiveDate = (1 << 0),
		}

		public bool HasReceiveDate { get { return Flags.HasFlag(Flag.ReceiveDate); } set { Flags = value ? (Flags | Flag.ReceiveDate) : (Flags & ~Flag.ReceiveDate); } }

		public Flag Flags { get; set; }
		public Int64 AccessHash { get; set; }
		public Int32 Date { get; set; }
		public Int32 AdminId { get; set; }
		public Int32 ParticipantId { get; set; }
		public TLPhoneCallProtocol Protocol { get; set; }
		public Int32? ReceiveDate { get; set; }

		public TLPhoneCallWaiting() { }
		public TLPhoneCallWaiting(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PhoneCallWaiting; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			Date = from.ReadInt32();
			AdminId = from.ReadInt32();
			ParticipantId = from.ReadInt32();
			Protocol = TLFactory.Read<TLPhoneCallProtocol>(from);
			if (HasReceiveDate) ReceiveDate = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt64(Id);
			to.WriteInt64(AccessHash);
			to.WriteInt32(Date);
			to.WriteInt32(AdminId);
			to.WriteInt32(ParticipantId);
			to.WriteObject(Protocol);
			if (HasReceiveDate) to.WriteInt32(ReceiveDate.Value);
		}

		private void UpdateFlags()
		{
			HasReceiveDate = ReceiveDate != null;
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiNoKuni
{
	class Charactor
	{
		public Charactor(uint address)
		{
			mAddress = address;
		}

		public uint Lv
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 36, 1); }
			set { Util.WriteNumber(mAddress + 36, 1, value, 1, 99); }
		}

		public String Name
		{
			get { return SaveData.Instance().ReadText(mAddress, 18); }
			set { SaveData.Instance().WriteText(mAddress, 18, value); }
		}

		public uint NowHP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 38, 2); }
			set { Util.WriteNumber(mAddress + 38, 2, value, 0, 9999); }
		}

		public uint MaxHP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 40, 2); }
			set { Util.WriteNumber(mAddress + 40, 2, value, 1, 9999); }
		}

		public uint NowMP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 42, 2); }
			set { Util.WriteNumber(mAddress + 42, 2, value, 0, 9999); }
		}

		public uint MaxMP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 44, 2); }
			set { Util.WriteNumber(mAddress + 44, 2, value, 1, 9999); }
		}

		public uint PhyAtk
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 46, 2); }
			set { Util.WriteNumber(mAddress + 46, 2, value, 1, 9999); }
		}

		public uint PhyDef
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 48, 2); }
			set { Util.WriteNumber(mAddress + 48, 2, value, 1, 9999); }
		}

		public uint Trick
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 50, 2); }
			set { Util.WriteNumber(mAddress + 50, 2, value, 1, 9999); }
		}

		public uint Tough
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 52, 2); }
			set { Util.WriteNumber(mAddress + 52, 2, value, 1, 9999); }
		}

		public uint Speed
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 54, 2); }
			set { Util.WriteNumber(mAddress + 54, 2, value, 1, 9999); }
		}

		public uint Skill
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 56, 2); }
			set { Util.WriteNumber(mAddress + 56, 2, value, 1, 9999); }
		}

		private readonly uint mAddress;
	}
}

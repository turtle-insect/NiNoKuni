using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiNoKuni
{
	class Charactor
	{
		public Charactor(uint address, String name)
		{
			mAddress = address;
			Name = name;
		}

		public uint Lv
		{
			get { return SaveData.Instance().ReadNumber(mAddress, 1); }
			set { Util.WriteNumber(mAddress, 1, value, 1, 99); }
		}

		public String Name { get; set; }

		public uint NowHP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 2, 2); }
			set { Util.WriteNumber(mAddress + 2, 2, value, 0, 9999); }
		}

		public uint MaxHP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 4, 2); }
			set { Util.WriteNumber(mAddress + 4, 2, value, 1, 9999); }
		}

		public uint NowMP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 6, 2); }
			set { Util.WriteNumber(mAddress + 6, 2, value, 0, 9999); }
		}

		public uint MaxMP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 8, 2); }
			set { Util.WriteNumber(mAddress + 8, 2, value, 1, 9999); }
		}

		private readonly uint mAddress;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace NiNoKuni
{
	class ViewModel
	{
		public ObservableCollection<Charactor> Party { get; set; } = new ObservableCollection<Charactor>();

		public ViewModel()
		{
			for (uint i = 0; i < 10; i++)
			{
				uint address = 0x17D35 + i * 850;
				String name = SaveData.Instance().ReadText(address, 3);
				if (String.IsNullOrEmpty(name)) break;

				Party.Add(new Charactor(address));
			}
		}
	}
}

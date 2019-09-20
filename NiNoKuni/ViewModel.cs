﻿using System;
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
			String[] names = { "オリバー" };
			for (uint i = 0; i < names.Length; i++)
			{
				Party.Add(new Charactor(0x17D59 + i * 0, names[i]));
			}
		}
	}
}

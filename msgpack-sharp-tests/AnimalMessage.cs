﻿using System;
using System.Collections.Generic;

namespace scopely.msgpacksharp.tests
{
	public class AnimalMessage
	{
		public AnimalMessage()
		{
		}

		[MsgPack(Sequence = 5)]
		public int HeightInches { get; set; }
		[MsgPack(Sequence = 10)]
		public string AnimalName { get; set; }
		[MsgPack(Sequence = 20)]
		public string AnimalKind { get; set; }
		[MsgPack(Sequence = 30)]
		public AnimalColor AnimalColor { get; set; }
		[MsgPack(Sequence = 40)]
		public DateTime BirthDay { get; set; }
		[MsgPack(Sequence = 50)]
		public int[] SomeNumbers { get; set; }
		[MsgPack(Sequence = 60)]
		public List<AnimalColor> SpotColors { get; set; }
		[MsgPack(Sequence = 70)]
		public List<AnimalColor> MoreColors { get; set; }
		[MsgPack(Sequence = 100)]
		public Dictionary<string,string> Metadata { get; set; }
		[MsgPack(Sequence = 80)]
		public List<int> ListOfInts { get; set; }
	}
}
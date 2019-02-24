﻿using KHSave.Attributes;

namespace KHSave.Types
{
	public enum AccessoryType : byte
	{
		Empty,
		Unknown01,
		Unknown02,
		Unknown03,
		Unknown04,
		Unknown05,
		Unknown06,
		Unknown07,
		Unknown08,
		Unknown09,
		Unknown0a,
		Unknown0b,
		Unknown0c,
		Unknown0d,
		Unknown0e,
		[Accessory("Phantom Ring")] PhantomRing,
		Unknown10,
		Unknown11,
		[Accessory("Rune Ring")] RuneRing,
		[Accessory("Force Ring")] ForceRing,
		Unknown14,
		Unknown15,
		Unknown16,
		Unknown17,
		[Accessory("Master's Necklace")] MasterNecklace,
		Unknown19,
		Unknown1a,
		Unknown1b,
		Unknown1c,
		Unknown1d,
		Unknown1e,
		[Accessory("Mickey Clasp")] MickeyClasp,
		Unknown20,
		Unknown21,
		Unknown22,
		Unknown23,
		Unknown24,
		Unknown25,
		Unknown26,
		Unknown27,
		Unknown28,
		Unknown29,
		Unknown2a,
		Unknown2b,
		Unknown2c,
		[Accessory("Celestriad")] Celestriad,
		Unknown2e,
		Unknown2f,
		Unknown30,
		Unknown31,
		[Accessory("Flanniversary Badge")] FlanniversaryBadge,
		Unknown33,
		Unknown34,
		Unknown35,
		Unknown36,
		Unknown37,
		Unknown38,
		Unknown39,
		Unknown3a,
		Unknown3b,
		Unknown3c,
		Unknown3d,
		Unknown3e,
		Unknown3f,
	}
}
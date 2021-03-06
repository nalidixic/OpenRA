#region Copyright & License Information
/*
 * Copyright 2007-2015 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using OpenRA.Traits;

namespace OpenRA.Mods.Common.Traits
{
	[Desc("This unit can be guarded (followed and protected) by a Guard unit.")]
	public class GuardableInfo : TraitInfo<Guardable>
	{
		[Desc("Maximum range that guarding actors will maintain. Measured in cells.")]
		public readonly int Range = 2;
	}

	public class Guardable { }
}

using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;
using Terraria;

namespace TeamMaintainer
{
	public class TeamPlayer : ModPlayer
	{
		public int defaultTeam = 2;
		public int team;


		public override void OnEnterWorld(Player player) {
			// We can refresh UI using OnEnterWorld. OnEnterWorld happens after Load, so nonStopParty is the correct value.
			player.team = defaultTeam;
			team = defaultTeam;
		}

		//TODO - Be able to click different teams and select them
		/*public override TagCompound Save() {
			return new TagCompound {
				{"team", team }
			};
		}

		public override void Load(TagCompound tag) {
			//tag.Get
		}*/
	}
}
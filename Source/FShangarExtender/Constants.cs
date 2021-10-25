/*
	This file is part of FShangarExtender /L
		© 2018-2021 Lisias T : http://lisias.net <support@lisias.net>
		© 2017-2018 LinuxGuruGamer
		© 2015 SNJO

	FShangarExtender is double licensed, as follows:

		* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
		* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	FShangarExtender /L Unleashed is distributed in the hope that it will be
	useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with FShangarExtender /L Unleashed.
	If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with FShangarExtender /L Unleashed.
	If not, see <https://www.gnu.org/licenses/>.

*/
using UnityEngine;
using System.IO;
using System.Reflection;

using Asset = KSPe.IO.Asset<FShangarExtender.Startup>;

namespace FShangarExtender
{
	static class Constants
	{
		public static string[] baseSceneNames = { "vabscenery", "sphscenery" };
		public static string[] baseHangarNames = { "vablvl1", "vablvl2", "vablvl3", "vabmodern", "sphlvl1", "sphlvl2", "sphlvl3", "sphmodern" };
		//public static string[] baseHangarVisibleNames = { "VABmodern", "VAB_interior_modern", "model_vab_interior_ground_v20", "Component_780_1", "ShadowPlane", "model_vab_exterior_ground_v46n", "VAB_Interior_Geometry", "model_vab_walls", "model_vab_windows", "model_vab_interior_lights_flood_v16", "model_vab_interior_occluder_v16", "model_sph_exterior_ground_v20", "Component_1_1", "Component_777_1", "ksp_runway", "ksp_runway_fbx" };
		public static string[] nonScalingNodeNames = { "vabcrew", "sphcrew" };

		public static readonly string settingRuntimeDirectory = Assembly.GetExecutingAssembly().Location.Replace(new FileInfo(Assembly.GetExecutingAssembly().Location).Name, "");

		public const float defaultScaleFactor = 10f;
		public const string defaultTempParentName = "FSHangarExtender_Temp_Parent";

		private const string Textures = "Textures";
		internal static readonly Texture2D extentIcon_36 = Asset.Texture2D.LoadFromFile(Textures, "IconExtend_38");
		internal static readonly Texture2D shrinkIcon_36 = Asset.Texture2D.LoadFromFile(Textures, "IconShrink_38");
		internal static readonly Texture2D extentIcon_24 = Asset.Texture2D.LoadFromFile(Textures, "IconExtend_24");
		internal static readonly Texture2D shrinkIcon_24 = Asset.Texture2D.LoadFromFile(Textures, "IconShrink_24");
	}
}

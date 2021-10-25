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

using KSPe.Annotations;
using GUI = KSPe.UI.GUI;
using GUILayout = KSPe.UI.GUILayout;
using Toolbar = KSPe.UI.Toolbar;

namespace FShangarExtender
{
	[KSPAddon(KSPAddon.Startup.MainMenu, true)]
	public class ToolbarController : MonoBehaviour
	{
		internal static KSPe.UI.Toolbar.Toolbar Instance => KSPe.UI.Toolbar.Controller.Instance.Get<ToolbarController>();

		[UsedImplicitly]
		private void Start()
		{
			KSPe.UI.Toolbar.Controller.Instance.Register<ToolbarController>(Version.FriendlyName);
		}
	}
}

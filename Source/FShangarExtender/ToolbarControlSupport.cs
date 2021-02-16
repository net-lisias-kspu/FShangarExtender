/*
 	This file is part of FShangarExtender /L
	© 2018-2021 Lisias T : http://lisias.net <support@lisias.net>
	© 2017-2018 LinuxGuruGamer
	© 2015 SNJO

 	FShangarExtender /L is licensed follows:

 	* CC BY 4.0 : https://creativecommons.org/licenses/by/4.0/

 	FShangarExtender /L is distributed in the hope that it will be useful,
 	but WITHOUT ANY WARRANTY; without even the implied warranty of
 	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/
using System;
using UnityEngine;

namespace FShangarExtender
{
	[KSPAddon(KSPAddon.Startup.MainMenu, true)]
	public class RegisterToolbar : MonoBehaviour
	{
		private void Start()
		{
			ToolbarControl_NS.ToolbarControl.RegisterMod(Constants.MODID, Constants.MODNAME);
		}
	}
}

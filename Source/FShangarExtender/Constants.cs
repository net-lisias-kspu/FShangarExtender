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
using UnityEngine;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

using PluginData = KSPe.IO.File<FShangarExtender.Startup>.Asset;

namespace FShangarExtender
{
	static class Constants
	{
		internal const string MODID = "FSeditorExtender_NS";
		internal const string MODNAME = "FS Editor Extender";

		public const string debugMarker = "[FSHangarExtender]";
		public const string debugVersion = "Version 3.5.0";

		public static string[] baseSceneNames = { "vabscenery", "sphscenery" };
		public static string[] baseHangarNames = { "vablvl1", "vablvl2", "vablvl3", "vabmodern", "sphlvl1", "sphlvl2", "sphlvl3", "sphmodern" };
		//public static string[] baseHangarVisibleNames = { "VABmodern", "VAB_interior_modern", "model_vab_interior_ground_v20", "Component_780_1", "ShadowPlane", "model_vab_exterior_ground_v46n", "VAB_Interior_Geometry", "model_vab_walls", "model_vab_windows", "model_vab_interior_lights_flood_v16", "model_vab_interior_occluder_v16", "model_sph_exterior_ground_v20", "Component_1_1", "Component_777_1", "ksp_runway", "ksp_runway_fbx" };
		public static string[] nonScalingNodeNames = { "vabcrew", "sphcrew" };

		public static readonly string settingRuntimeDirectory = Assembly.GetExecutingAssembly().Location.Replace(new FileInfo(Assembly.GetExecutingAssembly().Location).Name, "");
		public static readonly string extentIconFileName = PluginData.Solve("Textures", "IconExtend");
        public static readonly string shrinkIconFileName = PluginData.Solve("Textures", "IconShrink");
//		public static string completeShrinkIconFileNamePath = string.Concat(settingRuntimeDirectory, extentIconFileName);
//		public static string completeExtendIconFileNamePath = string.Concat(settingRuntimeDirectory, shrinkIconFileName);
        
		public const float defaultScaleFactor = 10f;
		public const string defaultTempParentName = "FSHangarExtender_Temp_Parent";
	}
}

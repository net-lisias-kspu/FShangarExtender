# Hangar Extender :: Change Log

* 2015-1011: 3.4.5 (Alewx) for KSP 1.0.4
	+ Added stock toolbar button for the Hangar extender
	+ Slightly improved Hangar hiding (far from perfect)
* 2015-0918: 3.4.4 (Alewx) for KSP 1.0.4
	+ added option to hide hangars in the editor
	+ added option to enable advanced debugging (minature performance improvement / log clearance)
	+ minimum zoom distance is increased by the scalingFactor 
* 2015-0906: 3.4.3 (Alewx) for KSP 1.0.4
	+ reduced possible bugs at Scene changes and after Scene reentries 
* 2015-0905: 3.4.2 (Alewx) for KSP 1.0.4 (No Binary)
	+ fixed a bug that would stuck all part palcements and the camera
* 2015-0905: 3.4.1 (Alewx) for KSP 1.0.4
	+ Fixed a bug in SPH scaling 
* 2015-0905: 3.4 (Alewx) for KSP 1.0.4
	+ improved compatibility for 1.0.4
	+ added the visual scaling of the building
	+ updated settingsfile to work with single factor for scaling
	+ scaling is read from config but limited to 10 as a maximum 
* 2015-0420: 3.3 (Snjo) for KSP 1.0
	+ Enabled config values for camera max distance and work area. Check settings.txt
	+ Defaults are now lower than before to avoid too high cam distance when entering the editor.
* 2015-0307: 3.2 (Snjo) for KSP 0.90
	+ Fixed camera max zoom distance not being set. Stayed at default 35m, Now 1000m.
* 2015-0307: 3.1 (Snjo) for KSP 0.90
	+ If the work area and camera movement stays small after loading the SPH/VAB, press the hotkey to reattempt the fix.
	+ The default hotkey is Numpad *. This key is reconfigurable in settings.txt.
	+ For the custom key to work, the settings.txt file MUST be placed in GameData\FShangarExtender\settings.txt
	+ The reason the scaling sometimes doesn't happen is probably due to timing between the scaling attempts and the speed the game loads the scene and settings.
* 2015-0201: 3.0 (Snjo) for KSP 0.90
	+ Rebuilt with code from NathanKell
	+ camera and work area scales
	+ models no longer scale, no hotkey to switch scales
* 2014-0728: 2.0 (Snjo) for KSP 0.24.2
	+ Scaling the building model now works in VAB too thanks to B9's help.
	+ Default building size configurable in the settings.txt
	+ Complete refactoring of the code 
* 2014-0530: 1.1 (Snjo) for KSP 0.23.5
	+ Added re-bindable hot key to scale the hangar. Edit the settings.txt file.

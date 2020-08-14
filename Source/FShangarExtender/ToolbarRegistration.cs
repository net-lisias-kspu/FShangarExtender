using UnityEngine;
using ToolbarControl_NS;

namespace FShangarExtender
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class RegisterToolbar : MonoBehaviour
    {
        void Start()
        {
            ToolbarControl.RegisterMod(FSeditorExtender.MODID, FSeditorExtender.MODNAME);
        }
    }
}
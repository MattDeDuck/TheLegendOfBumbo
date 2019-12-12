using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BepInEx;
using UnityEngine;

namespace TrinketHelper
{
    [BepInPlugin("org.bepinex.plugins.trinkethelper", "Trinket Helper", "1.0.0.0")]
    public class TrinketHelper : BaseUnityPlugin
    {
        void Awake()
        {
            On.DebugController.Update += this.DebugController_Update;
        }

        private void DebugController_Update(On.DebugController.orig_Update orig, DebugController self)
        {
            orig(self);

            int TrinketCount = self.app.model.characterSheet.trinkets.Count;

            if (Input.GetKey(KeyCode.Alpha1))
            {
                if (!self.app.model.paused) // If game isn't paused
                {
                    if (TrinketCount == 1 || TrinketCount == 2 || TrinketCount == 3 || TrinketCount == 4) // If trinket exists
                    {
                        self.app.controller.GUINotification(self.app.model.characterSheet.trinkets[0].trinketName + "\n" + self.app.model.characterSheet.trinkets[0].Name, GUINotificationView.NotifyType.General, null, true);
                    }
                }
            }

            if (Input.GetKey(KeyCode.Alpha2))
            {
                if (!self.app.model.paused)
                {
                    if (TrinketCount == 2 || TrinketCount == 3 || TrinketCount == 4)
                    {
                        self.app.controller.GUINotification(self.app.model.characterSheet.trinkets[1].trinketName + "\n" + self.app.model.characterSheet.trinkets[1].Name, GUINotificationView.NotifyType.General, null, true);
                    }
                }
            }

            if (Input.GetKey(KeyCode.Alpha3))
            {
                if (!self.app.model.paused)
                {
                    if (TrinketCount == 3 || TrinketCount == 4)
                    {
                        self.app.controller.GUINotification(self.app.model.characterSheet.trinkets[2].trinketName + "\n" + self.app.model.characterSheet.trinkets[2].Name, GUINotificationView.NotifyType.General, null, true);
                    }
                }
            }

            if (Input.GetKey(KeyCode.Alpha4))
            {
                if (!self.app.model.paused)
                {
                    if (TrinketCount == 4)
                    {
                        self.app.controller.GUINotification(self.app.model.characterSheet.trinkets[3].trinketName + "\n" + self.app.model.characterSheet.trinkets[3].Name, GUINotificationView.NotifyType.General, null, true);
                    }
                }
            }

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.Z))
            {
                self.turnOnDebug = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using MonoMod.RuntimeDetour;
using MonoMod.Utils;

namespace CustomLoadingTips
{
    [BepInPlugin("org.bepinex.plugins.customloadingtips", "Custom Loading Tips", "1.0.0.0")]
    public class CustomLoadingTips : BaseUnityPlugin
    {
        private ConfigEntry<string> LoadingTip1, LoadingTip2, LoadingTip3, LoadingTip4, LoadingTip5, LoadingTip6, LoadingTip7, LoadingTip8, LoadingTip9, LoadingTip10, LoadingTip11, LoadingTip12;

        public void Awake()
        {
            LoadingTip1 = Config.Bind("Loading Tips",
                                      "LDTip1",
                                      "\"blue enemies are resistant\\nto spell attacks!\"",
                                      "Loading tip 1 of 12");

            LoadingTip2 = Config.Bind("Loading Tips",
                                      "LDTip2",
                                      "\"purple enemies are resistant to puzzle attacks!\"",
                                      "Loading tip 2 of 12");

            LoadingTip3 = Config.Bind("Loading Tips",
                                      "LDTip3",
                                      "\"make sure to always spin\\nthe stat wheel!\"",
                                      "Loading tip 3 of 12");

            LoadingTip4 = Config.Bind("Loading Tips",
                                      "LDTip4",
                                      "\"need better spells?\\nvisit the prick seller at the wooden nickel!\"",
                                      "Loading tip 4 of 12");

            LoadingTip5 = Config.Bind("Loading Tips",
                                      "LDTip5",
                                      "\"want more trinkets? play the skull game\\nat the wooden nickel!\"",
                                      "Loading tip 5 of 12");

            LoadingTip6 = Config.Bind("Loading Tips",
                                      "LDTip6",
                                      "\"flying enemies directly above\\nwalking enemies always get hit first!\"",
                                      "Loading tip 6 of 12");

            LoadingTip7 = Config.Bind("Loading Tips",
                                      "LDTip7",
                                      "\"the next tiles will appear in\\nthe black area above the puzzle board!\"",
                                      "Loading tip 7 of 12");

            LoadingTip8 = Config.Bind("Loading Tips",
                                      "LDTip8",
                                      "\"you can still cast spells\\nwhen you run out of moves!\"",
                                      "Loading tip 8 of 12");

            LoadingTip9 = Config.Bind("Loading Tips",
                                      "LDTip9",
                                      "\"attacking through green\\ngas will blow it towards you!\"",
                                      "Loading tip 9 of 12");

            LoadingTip10 = Config.Bind("Loading Tips",
                                      "LDTip10",
                                      "\"enemies with a vein on their heads\\nhave bonus movement!\"",
                                      "Loading tip 10 of 12");

            LoadingTip11 = Config.Bind("Loading Tips",
                                      "LDTip11",
                                      "\"some enemies can move more than once.\\nbe prepared!\"",
                                      "Loading tip 11 of 12");

            LoadingTip12 = Config.Bind("Loading Tips",
                                      "LDTip12",
                                      "\"some enemies can cast spells that\\nprotect or buff other enemies!\"",
                                      "Loading tip 12 of 12");

            On.LoadingController.Start += LoadingController_Start;
        }

        private void LoadingController_Start(On.LoadingController.orig_Start orig, LoadingController self)
        {
            orig(self);

            short num2 = 0;
            while ((int)num2 < self.tips.Length)
            {
                self.tips[(int)num2].SetActive(false);
                num2 += 1;
            }

            self.tips[0].SetActive(true);
            self.tips[1].SetActive(true);
            self.tips[2].SetActive(true);
            self.tips[3].SetActive(true);
            self.tips[4].SetActive(true);
            self.tips[5].SetActive(true);
            self.tips[6].SetActive(true);
            self.tips[7].SetActive(true);
            self.tips[8].SetActive(true);
            self.tips[9].SetActive(true);
            self.tips[10].SetActive(true);
            self.tips[11].SetActive(true);

            GameObject loadTip0, loadTip1, loadTip2, loadTip3, loadTip4, loadTip5, loadTip6, loadTip7, loadTip8, loadTip9, loadTip10, loadTip11;

            loadTip0 = GameObject.Find("Tip 1");
            TextMeshProUGUI L0 = loadTip0.GetComponent<TextMeshProUGUI>();
            L0.text = LoadingTip1.Value;
            self.tips[0].SetActive(false);

            loadTip1 = GameObject.Find("Tip 2");
            TextMeshProUGUI L1 = loadTip1.GetComponent<TextMeshProUGUI>();
            L1.text = LoadingTip2.Value;
            self.tips[1].SetActive(false);

            loadTip2 = GameObject.Find("Tip 3");
            TextMeshProUGUI L2 = loadTip2.GetComponent<TextMeshProUGUI>();
            L2.text = LoadingTip3.Value;
            self.tips[2].SetActive(false);

            loadTip3 = GameObject.Find("Tip 4");
            TextMeshProUGUI L3 = loadTip3.GetComponent<TextMeshProUGUI>();
            L3.text = LoadingTip4.Value;
            self.tips[3].SetActive(false);

            loadTip4 = GameObject.Find("Tip 5");
            TextMeshProUGUI L4 = loadTip4.GetComponent<TextMeshProUGUI>();
            L4.text = LoadingTip5.Value;
            self.tips[4].SetActive(false);

            loadTip5 = GameObject.Find("Tip 6");
            TextMeshProUGUI L5 = loadTip5.GetComponent<TextMeshProUGUI>();
            L5.text = LoadingTip6.Value;
            self.tips[5].SetActive(false);

            loadTip6 = GameObject.Find("Tip 7");
            TextMeshProUGUI L6 = loadTip6.GetComponent<TextMeshProUGUI>();
            L6.text = LoadingTip7.Value;
            self.tips[6].SetActive(false);

            loadTip7 = GameObject.Find("Tip 8");
            TextMeshProUGUI L7 = loadTip7.GetComponent<TextMeshProUGUI>();
            L7.text = LoadingTip8.Value;
            self.tips[7].SetActive(false);

            loadTip8 = GameObject.Find("Tip 9");
            TextMeshProUGUI L8 = loadTip8.GetComponent<TextMeshProUGUI>();
            L8.text = LoadingTip9.Value;
            self.tips[8].SetActive(false);

            loadTip9 = GameObject.Find("Tip 10");
            TextMeshProUGUI L9 = loadTip9.GetComponent<TextMeshProUGUI>();
            L9.text = LoadingTip10.Value;
            self.tips[9].SetActive(false);

            loadTip10 = GameObject.Find("Tip 11");
            TextMeshProUGUI L10 = loadTip10.GetComponent<TextMeshProUGUI>();
            L10.text = LoadingTip11.Value;
            self.tips[10].SetActive(false);

            loadTip11 = GameObject.Find("Tip 12");
            TextMeshProUGUI L11 = loadTip11.GetComponent<TextMeshProUGUI>();
            L11.text = LoadingTip12.Value;
            self.tips[11].SetActive(false);

            int numb = UnityEngine.Random.Range(0, 12);
            self.tips[numb].SetActive(true);
        }
    }
}

/*
Tip 1 - \"blue enemies are resistant\nto spell attacks!\"
Tip 2 - \"purple enemies are resistant to puzzle attacks!\"
Tip 3 - \"make sure to always spin\nthe stat wheel!\"
Tip 4 - \"need better spells?\nvisit the prick seller at the wooden nickel!\"
Tip 5 - \"want more trinkets? play the skull game\nat the wooden nickel!\"
Tip 6 - \"flying enemies directly above\nwalking enemies always get hit first!\"
Tip 7 - \"the next tiles will appear in\nthe black area above the puzzle board!\"
Tip 8 - \"you can still cast spells\nwhen you run out of moves!\"
Tip 9 - \"attacking through green\ngas will blow it towards you!\"
Tip 10 - \"enemies with a vein on their heads\nhave bonus movement!\"
Tip 11 - \"some enemies can move more than once.\nbe prepared!\"
Tip 12 - \"some enemies can cast spells that\nprotect or buff other enemies!\"
*/

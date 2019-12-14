# Custom Loading Tips

Custom Loading Tips is a plugin for BepInEx. It allows you to set your own custom loading tips that you can see ingame when viewing the loading screen. This is done through using a config file which is generated upon launching the game once.

## How to use

1. You need to install [BepInEx](https://github.com/BepInEx/BepInEx#readme) to The Legend of Bum-Bo game folder.
2. Download the two files `CustomLoadingTips.dll` and `MMHOOK_Assembly-CSharp.dll`
3. Create a folder in `The Legend of Bum-Bo/BepInEx/Plugins` entitled `CustomLoadingTips`
4. Place the two files within `The Legend of Bum-Bo/BepInEx/plugins/TrinketHelper`
5. Run the game once as this will create the config file.

## How to edit the config file

1. Navigate to `The Legend of Bum-Bo/BepInEx/config/` and open up `org.bepinex.plugins.customloadingtips.cfg` with an editor of your choice. (I prefer Notepad++)
2. Find the loading tip you want to edit, for example this is the 4th loading tip:
```## Loading tip 3 of 12
# Setting type: String
# Default value: "make sure to always spin\nthe stat wheel!"
LDTip3 = \"make sure to always spin\nthe stat wheel!\"```


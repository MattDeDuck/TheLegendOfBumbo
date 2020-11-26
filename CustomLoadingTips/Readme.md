# Custom Loading Tips

Custom Loading Tips is a plugin for BepInEx. It allows you to set your own custom loading tips that you can see ingame when viewing the loading screen. This is done through using a config file which is generated upon launching the game once.

## How to use

1. You need to install [BepInEx](https://github.com/BepInEx/BepInEx#readme) to The Legend of Bum-Bo game folder.
2. Download the two files `CustomLoadingTips.dll` and `MMHOOK_Assembly-CSharp.dll`
3. Create a folder in `The Legend of Bum-Bo/BepInEx/Plugins` entitled `CustomLoadingTips`
4. Place the two files within ```The Legend of Bum-Bo/BepInEx/plugins/CustomLoadingTips```
5. Run the game once as this will create the config file.

## How to edit the config file

1. Make sure you have run the game once to generate the config file after installing the plugin!
2. Navigate to `The Legend of Bum-Bo/BepInEx/config/` and open up `org.bepinex.plugins.customloadingtips.cfg` with an editor of your choice. (I prefer Notepad++)
3. Find the loading tip you want to edit, for example this is the 3rd loading tip:
```## Loading tip 3 of 12
# Setting type: String
# Default value: "make sure to always spin\nthe stat wheel!"
LDTip3 = \"make sure to always spin\nthe stat wheel!\"
```
4. Now `LDTip3` is the value we need to edit.
5. For example I will change it to `LDTip3 = \"spells that manipulate the board\nare quite useful!\"`
6. Save the file and run the game again
7. When that tip is loaded it will display as follows...
![Loading Tip #3 Example](https://github.com/MattDeDuck/TheLegendOfBumbo/blob/master/CustomLoadingTips/loadtip1.png)

## Notes

- The use of the `\` before the quotation marks is to allow the game to read it as a normal quotation mark and not part of the coding language
- The use of `\n` is to create a new line

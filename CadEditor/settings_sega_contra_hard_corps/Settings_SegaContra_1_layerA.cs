using CadEditor;
using System;
using System.Drawing;

public class Data 
{ 
  public GameType getGameType()        { return GameType.Generic; }
  public OffsetRec getScreensOffset()  { return new OffsetRec(0x0, 1 , 256*16);   }
  public int getScreenWidth()          { return 256; }
  public int getScreenHeight()         { return 16; }
  public string getBlocksFilename()    { return "settings_sega_contra_hard_corps/sega_contra_1.png"; }
  
  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return false; }
  public bool isLayoutEditorEnabled()   { return false; }
  public bool isEnemyEditorEnabled()    { return false; }
  public bool isVideoEditorEnabled()    { return false; }
}
using CadEditor;
using System;
using System.Drawing;

public class Data 
{ 
  public GameType getGameType()        { return GameType.Generic; }
  public OffsetRec getScreensOffset()  { return new OffsetRec(0x01D57F, 1 , 256); }
  public int getScreenWidth()          { return 22; }
  public int getScreenHeight()         { return 6; }
  public string getBlocksFilename()    { return "settings_fist_of_the_nortstar/fist_of_the_nortstar_6.png"; }
  public int    getPictureBlocksWidth()   { return 16; }

// Width
  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return false; }
  public bool isLayoutEditorEnabled()   { return false; }
  public bool isEnemyEditorEnabled()    { return false; }
  public bool isVideoEditorEnabled()    { return false; }

  public bool getScreenVertical()         { return false; }
}
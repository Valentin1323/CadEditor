using CadEditor;
using System.Collections.Generic;
//css_include Settings_CapcomBase.cs;
public class Data : CapcomBase
{ 
  public OffsetRec getPalOffset()       { return new OffsetRec(0, 1  , 16);     }
  public OffsetRec getVideoOffset()     { return new OffsetRec(0, 1  , 0x1000); }
  public OffsetRec getVideoObjOffset()  { return new OffsetRec(0, 1  , 0x1000); }
  public OffsetRec getBigBlocksOffset() { return new OffsetRec(0, 1  , 0x4000); }
  public OffsetRec getBlocksOffset()    { return new OffsetRec(0, 1  , 0x4000); }
  public OffsetRec getScreensOffset()   { return new OffsetRec(85106 , 1 , 62*32);   }
  public override int getScreenWidth()    { return 62; }
  public override int getScreenHeight()   { return 32; }
  public string getBlocksFilename() { return "settings_jungle_book/jungle_book_1.png"; }
  public IList<LevelRec> getLevelRecs() { return null; }
  
  public bool isBigBlockEditorEnabled() { return false; }
  public bool isBlockEditorEnabled()    { return false; }
  public bool isLayoutEditorEnabled()   { return false; }
  public bool isEnemyEditorEnabled()    { return false; }
  public bool isVideoEditorEnabled()    { return false; }
}
﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CadEditor
{
    static public class Video
    {
        static Video()
        {
            NesColors[0] = Color.FromArgb( 124,124,124);
            NesColors[1] = Color.FromArgb(0,0,252);
            NesColors[2] = Color.FromArgb(0,0,188);
            NesColors[3] = Color.FromArgb(68,40,188);
            NesColors[4] = Color.FromArgb(148,0,132);
            NesColors[5] = Color.FromArgb(168,0,32);
            NesColors[6] = Color.FromArgb(168,16,0);
            NesColors[7] = Color.FromArgb(136,20,0);
            NesColors[8] = Color.FromArgb(80,48,0);
            NesColors[9] = Color.FromArgb(0,120,0);
            NesColors[0xA] = Color.FromArgb(0,104,0);
            NesColors[0xB] = Color.FromArgb(0,88,0);
            NesColors[0xC] = Color.FromArgb(0,64,88);
            NesColors[0xD] = Color.FromArgb(0, 0, 0);
            NesColors[0xE] = Color.FromArgb(0, 0, 0);
            NesColors[0xF] = Color.FromArgb(0, 0, 0);

            NesColors[0x10] = Color.FromArgb(188,188,188);
            NesColors[0x11] = Color.FromArgb(0,120,248);
            NesColors[0x12] = Color.FromArgb(0, 88, 248);
            NesColors[0x13] = Color.FromArgb(104, 68, 252);
            NesColors[0x14] = Color.FromArgb(216, 0, 204);
            NesColors[0x15] = Color.FromArgb(228, 0, 88);
            NesColors[0x16] = Color.FromArgb(248, 56, 0);
            NesColors[0x17] = Color.FromArgb(228, 92, 16);
            NesColors[0x18] = Color.FromArgb(172, 124, 0);
            NesColors[0x19] = Color.FromArgb(0, 184, 0);
            NesColors[0x1A] = Color.FromArgb(0, 168, 0);
            NesColors[0x1B] = Color.FromArgb(0, 168, 68);
            NesColors[0x1C] = Color.FromArgb(0, 136, 136);
            NesColors[0x1D] = Color.FromArgb(0, 0, 0);
            NesColors[0x1E] = Color.FromArgb(0, 0, 0);
            NesColors[0x1F] = Color.FromArgb(0, 0, 0);

            NesColors[0x20] = Color.FromArgb(248,248,248);
            NesColors[0x21] = Color.FromArgb(60, 188, 252);
            NesColors[0x22] = Color.FromArgb(104, 136, 252);
            NesColors[0x23] = Color.FromArgb(152, 120, 248);
            NesColors[0x24] = Color.FromArgb(248, 120, 248);
            NesColors[0x25] = Color.FromArgb(248, 88, 152);
            NesColors[0x26] = Color.FromArgb(248, 120, 88);
            NesColors[0x27] = Color.FromArgb(252, 160, 68);
            NesColors[0x28] = Color.FromArgb(248, 184, 0);
            NesColors[0x29] = Color.FromArgb(184, 248, 24);
            NesColors[0x2A] = Color.FromArgb(88, 216, 84);
            NesColors[0x2B] = Color.FromArgb(88,248,152);
            NesColors[0x2C] = Color.FromArgb(0, 232, 216);
            NesColors[0x2D] = Color.FromArgb(120, 120, 120);
            NesColors[0x2E] = Color.FromArgb(0, 0, 0);
            NesColors[0x2F] = Color.FromArgb(0, 0, 0);

            NesColors[0x30] = Color.FromArgb(252,252,252);
            NesColors[0x31] = Color.FromArgb(164, 228, 252);
            NesColors[0x32] = Color.FromArgb(184, 184, 248);
            NesColors[0x33] = Color.FromArgb(216,184,248);
            NesColors[0x34] = Color.FromArgb(248, 184, 248);
            NesColors[0x35] = Color.FromArgb(248, 164, 192);
            NesColors[0x36] = Color.FromArgb(240,208,176);
            NesColors[0x37] = Color.FromArgb(252, 224, 168);
            NesColors[0x38] = Color.FromArgb(248, 216, 120);
            NesColors[0x39] = Color.FromArgb(216, 248, 120);
            NesColors[0x3A] = Color.FromArgb(184,248,184);
            NesColors[0x3B] = Color.FromArgb(184, 248, 216);
            NesColors[0x3C] = Color.FromArgb(0, 252, 252);
            NesColors[0x3D] = Color.FromArgb(248, 216, 248);
            NesColors[0x3E] = Color.FromArgb(0, 0, 0);
            NesColors[0x3F] = Color.FromArgb(0, 0, 0);

            CadObjectTypeColors[0x0] = Color.FromArgb(196, 0, 255, 0);
            CadObjectTypeColors[0x1] = Color.FromArgb(196, 0, 255, 0);
            CadObjectTypeColors[0x2] = Color.FromArgb(196, 0, 196, 0);
            CadObjectTypeColors[0x3] = Color.FromArgb(196, 255, 0,0);
            CadObjectTypeColors[0x4] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0x5] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0x6] = Color.FromArgb(196, 0, 255, 0);
            CadObjectTypeColors[0x7] = Color.FromArgb(196, 255, 255, 0);
            CadObjectTypeColors[0x8] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0x9] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0xA] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0xB] = Color.FromArgb(196, 0, 0, 0);
            CadObjectTypeColors[0xC] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0xD] = Color.FromArgb(196, 255, 0, 0);
            CadObjectTypeColors[0xE] = Color.FromArgb(196, 0, 255, 255);
            CadObjectTypeColors[0xF] = Color.FromArgb(196, 0, 255, 255);
        }

        public static void updateColorsFromConfig()
        {
            if (ConfigScript.nesColors != null)
                NesColors = ConfigScript.nesColors;
        }

        public static Bitmap makeImageStrip(byte[] videoChunk, byte[] pallete, int subPalIndex, int scale, bool scaleAccurate = true)
        {
            Bitmap res = new Bitmap(8 * CHUNK_COUNT * scale, 8 * scale); 
            using (Graphics g = Graphics.FromImage(res))
            {
                for (int i = 0; i < CHUNK_COUNT; i++)
                {
                    int bitmapScale = scaleAccurate ? scale : 1;
                    Bitmap onePic = new Bitmap(8*bitmapScale, 8*bitmapScale);
                    int beginIndex = 16 * i;
                    for (int line = 0; line < 8; line++)
                    {
                        for (int pixel = 0; pixel < 8; pixel++)
                        {
                            bool bitLo = Utils.getBit(videoChunk[beginIndex + line], 8-pixel);
                            bool bitHi = Utils.getBit(videoChunk[beginIndex + line + 8], 8 - pixel);
                            int palIndex = mixBits(bitHi, bitLo);
                            Color c = NesColors[pallete[subPalIndex * 4 +palIndex]];
                            if (scaleAccurate)
                            {
                                for (int scaleFillX = 0; scaleFillX < scale; scaleFillX++)
                                    for (int scaleFillY = 0; scaleFillY < scale; scaleFillY++)
                                        onePic.SetPixel(pixel * scale + scaleFillX, line * scale + scaleFillY, c);
                            }
                            else
                            {
                                onePic.SetPixel(pixel, line, c);
                            }
                        }
                    }
                    g.DrawImage(onePic, new Rectangle(i * 8 * scale, 0, 8*scale, 8*scale));
                }
            }
            return res;
        }

        public static Bitmap makeObjectsStrip(byte videoPageId, byte tilesId, byte palId, int scale, MapViewType drawType, int constantSubpal = -1)
        {
            byte[] videoChunk = ConfigScript.getVideoChunk(videoPageId);

            int blocksCount = ConfigScript.getBlocksCount();
            ObjRec[] objects = ConfigScript.getBlocks(tilesId);
            
            byte[] palette = ConfigScript.getPal(palId);
            var objStrip1 = makeImageStrip(videoChunk, palette, 0, scale);
            var objStrip2 = makeImageStrip(videoChunk, palette, 1, scale);
            var objStrip3 = makeImageStrip(videoChunk, palette, 2, scale);
            var objStrip4 = makeImageStrip(videoChunk, palette, 3, scale);
            var objStrips = new[] { objStrip1, objStrip2, objStrip3, objStrip4 };
            Bitmap res = new Bitmap(16 * blocksCount * scale, 16 * scale);
            using (Graphics g = Graphics.FromImage(res))
            {
                for (int i = 0; i < blocksCount; i++)
                {
                    var mblock = new Bitmap(16 * scale, 16 * scale);
                    var co = objects[i];
                    Bitmap curStrip;
                    if (constantSubpal == -1)
                    {
                        if (Globals.gameType == GameType.DT2)
                        {
                            var objectForColor = objects[i / 4];
                            curStrip = objStrips[objectForColor.getSubpalleteForDt2(i % 4)];
                        }
                        else
                        {
                            curStrip = objStrips[co.getSubpallete()];
                        }
                    }
                    else
                    {
                        curStrip = objStrips[constantSubpal];
                    }

                    using (Graphics g2 = Graphics.FromImage(mblock))
                    {
                        g2.DrawImage(curStrip, new Rectangle(0, 0, 8 * scale, 8 * scale), new Rectangle(co.c1 * 8 * scale, 0, 8 * scale, 8 * scale), GraphicsUnit.Pixel);
                        g2.DrawImage(curStrip, new Rectangle(8 * scale, 0, 8 * scale, 8 * scale), new Rectangle(co.c2 * 8 * scale, 0, 8 * scale, 8 * scale), GraphicsUnit.Pixel);
                        g2.DrawImage(curStrip, new Rectangle(0, 8 * scale, 8 * scale, 8 * scale), new Rectangle(co.c3 * 8 * scale, 0, 8 * scale, 8 * scale), GraphicsUnit.Pixel);
                        g2.DrawImage(curStrip, new Rectangle(8 * scale, 8 * scale, 8 * scale, 8 * scale), new Rectangle(co.c4 * 8 * scale, 0, 8 * scale, 8 * scale), GraphicsUnit.Pixel);
                        if (drawType == MapViewType.ObjType)
                        {
                            if (Globals.gameType == GameType.DT2)
                            {
                                g2.FillRectangle(new SolidBrush(CadObjectTypeColors[co.getTypeForDt2(i)]), new Rectangle(0, 0, 16 * scale, 16 * scale));
                                g2.DrawString(String.Format("{0:X}", co.getTypeForDt2(i)), new Font("Arial", 6), Brushes.White, new Point(0, 0));
                            }
                            else
                            {
                                g2.FillRectangle(new SolidBrush(CadObjectTypeColors[co.getType()]), new Rectangle(0, 0, 16 * scale, 16 * scale));
                                g2.DrawString(String.Format("{0:X}", co.getType()), new Font("Arial", 6), Brushes.White, new Point(0, 0));
                            }
                        }
                        else if (drawType == MapViewType.ObjNumbers)
                        {
                            g2.FillRectangle(new SolidBrush(Color.FromArgb(192, 255, 255, 255)), new Rectangle(0, 0, 16 * scale, 16 * scale));
                            g2.DrawString(String.Format("{0:X}", i), new Font("Arial", 6), Brushes.Red, new Point(0, 0));
                        }
                    }
                    g.DrawImage(mblock, new Rectangle(i*16*scale, 0, 16*scale, 16*scale));
                }
            }
            return res;

        }

        public static Bitmap emptyScreen(int w, int h, bool withBorder = true)
        {
            var b = new Bitmap(w, h);
            using (var g = Graphics.FromImage(b))
            {
                g.FillRectangle(Brushes.Black, new Rectangle(0, 0, w, h));
                if (withBorder)
                  g.DrawRectangle(new Pen(Color.Green, w / 32), new Rectangle(0, 0, w, h));
            }
            return b;
        }

        //make capcom screen image
        public static Bitmap makeScreen(int scrNo, int videoNo, int bigBlockNo, int blockNo, int palleteNo, bool withBigTileBorders = true)
        {
            if (scrNo < 0)
                return emptyScreen(ConfigScript.getScreenWidth() * 64, ConfigScript.getScreenHeight() * 64);
            int blockCount = ConfigScript.getBigBlocksCount();
            int SCREEN_SIZE = ConfigScript.getScreenWidth() * ConfigScript.getScreenHeight();
            var smallBlocks = new System.Windows.Forms.ImageList();
            smallBlocks.ImageSize = new Size(withBigTileBorders ? 16 : 32, withBigTileBorders ? 16 :32);
            var bigBlocks = new Image[blockCount];

            byte blockId = (byte)bigBlockNo;
            byte blockIndexId = (byte)blockNo;
            byte backId = (byte)videoNo;
            byte palId = (byte)palleteNo;
            byte[] bigBlockIndexes = ConfigScript.getBigBlocks(blockIndexId);

            var im = Video.makeObjectsStrip(backId, blockId, palId, withBigTileBorders ? 1 : 2, MapViewType.Tiles);
            smallBlocks.Images.AddStrip(im);

            //tt version hardcode
            int smallBlockScaleFactor = 2;
            ImageList[] smallBlocksAll = null;
            byte[] smallBlocksColorBytes = null;
            if (GameType.TT == Globals.gameType)
            {
                smallBlocksAll = new ImageList[4];
                for (int i = 0; i < 4; i++)
                {
                    smallBlocksAll[i] = new ImageList();
                    smallBlocksAll[i].ImageSize = new Size(32, 32);
                    smallBlocksAll[i].Images.Clear();
                    smallBlocksAll[i].ImageSize = new System.Drawing.Size(16 * smallBlockScaleFactor, 16 * smallBlockScaleFactor);
                    smallBlocksAll[i].Images.AddStrip(Video.makeObjectsStrip((byte)backId, (byte)blockId, (byte)palId, smallBlockScaleFactor, MapViewType.Tiles, i));
                }
                smallBlocksColorBytes = Globals.getTTSmallBlocksColorBytes(blockId);
            }

            int blockWidth = 32;
            int blockHeight = 32;
            int curButtonScale = 2;
            for (int btileId = 0; btileId < blockCount; btileId++)
            {
                var b = new Bitmap(64, 64);
                using (Graphics g = Graphics.FromImage(b))
                {
                    /*if (withBigTileBorders)
                    {
                        g.DrawImage(smallBlocks.Images[bigBlockIndexes[btileId * 4]], new Rectangle(0, 0, 32, 32));
                        g.DrawImage(smallBlocks.Images[bigBlockIndexes[btileId * 4 + 1]], new Rectangle(31, 0, 32, 32));
                        g.DrawImage(smallBlocks.Images[bigBlockIndexes[btileId * 4 + 2]], new Rectangle(0, 31, 32, 32));
                        g.DrawImage(smallBlocks.Images[bigBlockIndexes[btileId * 4 + 3]], new Rectangle(31, 31, 32, 32));
                    }
                    else
                    {
                        g.DrawImage(smallBlocks.Images[bigBlockIndexes[btileId * 4]], new Rectangle(0, 0, 32, 32));
                        g.DrawImage(smallBlocks.Images[bigBlockIndexes[btileId * 4 + 1]], new Rectangle(32, 0, 32, 32));
                        g.DrawImage(smallBlocks.Images[bigBlockIndexes[btileId * 4 + 2]], new Rectangle(0, 32, 32, 32));
                        g.DrawImage(smallBlocks.Images[bigBlockIndexes[btileId * 4 + 3]], new Rectangle(32, 32, 32, 32));
                    }*/
                    switch (Globals.gameType)
                    {
                        case GameType.TT:
                            b = Video.makeBigBlockTT(btileId, blockWidth * curButtonScale, blockHeight * curButtonScale, bigBlockIndexes, smallBlocksAll, smallBlocksColorBytes);
                            break;
                        case GameType._3E:
                            b = Video.makeBigBlock3E(btileId, blockWidth * curButtonScale, blockHeight * curButtonScale, bigBlockIndexes, smallBlocks);
                            break;
                        default:
                            b = Video.makeBigBlock(btileId, blockWidth * curButtonScale, blockHeight * curButtonScale, bigBlockIndexes, smallBlocks);
                            break;
                    } 
                }
                bigBlocks[btileId] = b;
            }

            var bitmap = new Bitmap(ConfigScript.getScreenWidth()*64, ConfigScript.getScreenHeight()*64); //getScreenVertical, scales
            int[] indexes = Globals.getScreen(scrNo);
            using (var g = Graphics.FromImage(bitmap))
            {
                for (int tileNo = 0; tileNo < SCREEN_SIZE; tileNo++)
                {
                    int index = Globals.getBigTileNoFromScreen(indexes, tileNo);
                    if (withBigTileBorders)
                      g.DrawImage(bigBlocks[index], new Rectangle(tileNo % 8 * 63, tileNo / 8 * 63, 64, 64));
                    else
                      g.DrawImage(bigBlocks[index], new Rectangle(tileNo % 8 * 64, tileNo / 8 * 64, 64, 64));
                }
            }
            return bitmap;
        }

#region Render Functions
        public static Bitmap makeBigBlock(int i, int width, int height, byte[] bigBlockIndexes, System.Windows.Forms.ImageList smallBlocks)
        {
            int bbRectPosX = width / 2;
            int bbRectSizeX = width / 2;
            int bbRectPosY = height / 2;
            int bbRectSizeY = height / 2; 
            var b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(b))
            {
                    g.DrawImage(smallBlocks.Images[bigBlockIndexes[i * 4]], new Rectangle(0, 0, bbRectSizeX, bbRectSizeY));
                    g.DrawImage(smallBlocks.Images[bigBlockIndexes[i * 4 + 1]], new Rectangle(bbRectPosX, 0, bbRectSizeX, bbRectSizeY));
                    g.DrawImage(smallBlocks.Images[bigBlockIndexes[i * 4 + 2]], new Rectangle(0, bbRectPosY, bbRectSizeX, bbRectSizeY));
                    g.DrawImage(smallBlocks.Images[bigBlockIndexes[i * 4 + 3]], new Rectangle(bbRectPosX, bbRectPosY, bbRectSizeX, bbRectSizeY)); 
            }
            return b;
        }

        public static Bitmap makeBigBlock3E(int i, int width, int height, byte[] bigBlockIndexes, System.Windows.Forms.ImageList smallBlocks)
        {
            int bbRectPosX = width / 2;
            int bbRectSizeX = width / 2;
            int bbRectPosY = height / 2;
            int bbRectSizeY = height / 2;
            var b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.DrawImage(smallBlocks.Images[bigBlockIndexes[i * 4 + 0]], new Rectangle(0, 0, bbRectSizeX, bbRectSizeY));
                g.DrawImage(smallBlocks.Images[bigBlockIndexes[i * 4 + 2]], new Rectangle(bbRectPosX, 0, bbRectSizeX, bbRectSizeY));
                g.DrawImage(smallBlocks.Images[bigBlockIndexes[i * 4 + 1]], new Rectangle(0, bbRectPosY, bbRectSizeX, bbRectSizeY));
                g.DrawImage(smallBlocks.Images[bigBlockIndexes[i * 4 + 3]], new Rectangle(bbRectPosX, bbRectPosY, bbRectSizeX, bbRectSizeY));
            }
            return b;
        }

        public static Bitmap makeBigBlockTT(int i, int width, int height, byte[] bigBlockIndexes, System.Windows.Forms.ImageList[] smallBlocksAll, byte[] smallBlocksColorBytes)
        {
            int bbRectPosX = width / 2;
            int bbRectSizeX = width / 2;
            int bbRectPosY = height / 2;
            int bbRectSizeY = height / 2;
            var b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(b))
            {
                int scb = smallBlocksColorBytes[i];
                g.DrawImage(smallBlocksAll[scb >> 0 & 0x3].Images[bigBlockIndexes[i * 4]], new Rectangle(0, 0, bbRectSizeX, bbRectSizeY));
                g.DrawImage(smallBlocksAll[scb >> 2 & 0x3].Images[bigBlockIndexes[i * 4 + 1]], new Rectangle(bbRectPosX, 0, bbRectSizeX, bbRectSizeY));
                g.DrawImage(smallBlocksAll[scb >> 4 & 0x3].Images[bigBlockIndexes[i * 4 + 2]], new Rectangle(0, bbRectPosY, bbRectSizeX, bbRectSizeY));
                g.DrawImage(smallBlocksAll[scb >> 6 & 0x3].Images[bigBlockIndexes[i * 4 + 3]], new Rectangle(bbRectPosX, bbRectPosY, bbRectSizeX, bbRectSizeY));   
            }
            return b;
        }

        public static Bitmap addAxisRectangle(Bitmap source)
        {
            using (Graphics g = Graphics.FromImage(source))
                g.DrawRectangle(new Pen(Color.FromArgb(255, 255, 255, 255)), new Rectangle(0, 0, source.Width, source.Height));
            return source;
        }

        public static Bitmap addObjNumber(Bitmap source, int no)
        {
            using (Graphics g = Graphics.FromImage(source))
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(192, 255, 255, 255)), new Rectangle(0, 0, source.Width, source.Height));
                g.DrawString(String.Format("{0:X}", no), new Font("Arial", 16), Brushes.Red, new Point(0, 0));
            }
            return source;
        }
#endregion

        private static int mixBits(bool hi, bool lo)
        {
            return (hi?1:0) << 1 |(lo?1:0);
        }

        public static int NES_COLORS_COUNT = 64;
        public static int CHUNK_COUNT = 256;
        public static Color[] NesColors = new Color[NES_COLORS_COUNT];

        const int CAD_OBJTYPES_COUNT = 16;
        public static Color[] CadObjectTypeColors = new Color[CAD_OBJTYPES_COUNT];
    }

    public enum MapViewType
    {
        Tiles,
        ObjType,
        ObjNumbers
    };
}

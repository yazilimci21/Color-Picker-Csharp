using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ColorPicked
{
    class Lister
    {
        public string listFile = System.Windows.Forms.Application.StartupPath + "\\Colors.list";
        private string defaultGroupName;
        private string GroupStringStart = "[Group=";
        private string GroupStringEnd = "]";
        
        private ArrayList Groups = new ArrayList();
        private ArrayList Colors = new ArrayList();

        /// <summary>
        /// Liste Otomatik Oluşturulur
        /// </summary>
        public static Lister MyList;
        public Lister()
        {
            foreach (string gelen in File.ReadAllLines(listFile, Encoding.Default))
            {
                if (gelen.Length > 0)
                {
                    if (gelen.Substring(0, GroupStringStart.Length) == GroupStringStart)
                    {
                        defaultGroupName = gelen.Substring(GroupStringStart.Length, (gelen.Length - (GroupStringStart.Length + GroupStringEnd.Length)));
                        Groups.Add(defaultGroupName);
                    }
                    else
                    {
                        ListEra color = new ListEra();
                        color.GroupName = defaultGroupName;

                        string[] dizi = gelen.Split('=');
                        color.ColorName = dizi[0];

                        string[] dizi2 = dizi[1].Split(';');
                        color.Html = dizi2[0];
                        color.Rgb = dizi2[1];

                        Colors.Add(color);
                    }
                }
            }
            MyList = this;
        }



        private ArrayList getGroupList = new ArrayList();
        public ArrayList getGroup(string Group)
        {
            getGroupList.Clear();
            for (int i = 0; i < Colors.Count; i++)
            {
                ListEra color = (ListEra)Colors[i];
                if (color.GroupName == Group)
                {
                    getGroupList.Add(Colors[i]);
                }
            }
            return getGroupList;
        }

        public int getGroupCount()
        {
            return Groups.Count;
        }

        public string getGroupName(int i)
        {
            return Groups[i].ToString();
        }

        public int getGroupInt(string Group)
        {
            return Groups.IndexOf(Group);
        }

        public int AddGroup(string Group)
        {
            try
            {
                if (Groups.IndexOf(Group) > -1) return 0;
                Groups.Add(Group);
                return 1;
            }
            catch
            {
                
            }
            return 0;
        }

        public int ReplaceGroupName(int Group,string newGroupName)
        {
            try
            {
                if (Groups.IndexOf(newGroupName) > -1) return 0;
                for (int i = 0; i < Colors.Count; i++)
                {
                    ListEra color = (ListEra)Colors[i];
                    if (color.GroupName == getGroupName(Group))
                    {
                        ReplaceColorName(getGroupName(Group), newGroupName,color.ColorName, "", "", "");
                    }
                }
                Groups.Insert(Group+1, newGroupName);
                Groups.RemoveAt(Group);
                return 1;
            }
            catch
            {

            }
            return 0;
        }

        public int DelGroup(int Group)
        {
            try
            {
                string GroupName = getGroupName(Group);
                for (int i = 0; i < Colors.Count; i++)
                {
                    ListEra color = (ListEra)Colors[i];
                    if (color.GroupName == GroupName)
                    {
                        Colors.RemoveAt(i);
                    }
                }
                Groups.RemoveAt(Group);
                return 1;
            }
            catch
            {
                
            }
            return 0;
        }

        public int AddColor(string GroupName, string ColorName, string Html, string Rgb)
        {
            try
            {
                for (int i = 0; i < Colors.Count; i++)
                {
                    ListEra scolor = (ListEra)Colors[i];
                    if (scolor.ColorName == ColorName && scolor.GroupName == GroupName)
                    {
                        return 0;
                    }
                }
                ListEra color = new ListEra();
                color.GroupName = GroupName;
                color.ColorName = ColorName;
                color.Html = Html;
                color.Rgb = Rgb;

                Colors.Add(color);
                return 1;
            }
            catch
            {
                
            }
            return 0;
        }

        public int getDefaultSettings()
        {
            try
            {
                Groups.Clear();
                Colors.Clear();
                Groups.Add("DefaultColors");
                Color[] colors = getDefaultColors();
                for (int i = 0; i < colors.Length; i++)
                {
                    AddColor("DefaultColors", colors[i].Name, ColorTranslator.ToHtml(colors[i]), colors[i].R + "," + colors[i].G + "," + colors[i].B);
                }
            }
            catch { }
            return 0;
        }

        public Color[] getDefaultColors()
        {
            Color[] colors = new Color[141];
            colors[0] = System.Drawing.Color.AliceBlue;
            colors[1] = System.Drawing.Color.AntiqueWhite;
            colors[2] = System.Drawing.Color.Aqua;
            colors[3] = System.Drawing.Color.Aquamarine;
            colors[4] = System.Drawing.Color.Azure;
            colors[5] = System.Drawing.Color.Beige;
            colors[6] = System.Drawing.Color.Bisque;
            colors[7] = System.Drawing.Color.Black;
            colors[8] = System.Drawing.Color.BlanchedAlmond;
            colors[9] = System.Drawing.Color.Blue;
            colors[10] = System.Drawing.Color.BlueViolet;
            colors[11] = System.Drawing.Color.Brown;
            colors[12] = System.Drawing.Color.BurlyWood;
            colors[13] = System.Drawing.Color.CadetBlue;
            colors[14] = System.Drawing.Color.Chartreuse;
            colors[15] = System.Drawing.Color.Chocolate;
            colors[16] = System.Drawing.Color.Coral;
            colors[17] = System.Drawing.Color.CornflowerBlue;
            colors[18] = System.Drawing.Color.Cornsilk;
            colors[19] = System.Drawing.Color.Crimson;
            colors[20] = System.Drawing.Color.Cyan;
            colors[21] = System.Drawing.Color.DarkBlue;
            colors[22] = System.Drawing.Color.DarkCyan;
            colors[23] = System.Drawing.Color.DarkGoldenrod;
            colors[24] = System.Drawing.Color.DarkGray;
            colors[25] = System.Drawing.Color.DarkGreen;
            colors[26] = System.Drawing.Color.DarkKhaki;
            colors[27] = System.Drawing.Color.DarkMagenta;
            colors[28] = System.Drawing.Color.DarkOliveGreen;
            colors[29] = System.Drawing.Color.DarkOrange;
            colors[30] = System.Drawing.Color.DarkOrchid;
            colors[31] = System.Drawing.Color.DarkRed;
            colors[32] = System.Drawing.Color.DarkSalmon;
            colors[33] = System.Drawing.Color.DarkSeaGreen;
            colors[34] = System.Drawing.Color.DarkSlateBlue;
            colors[35] = System.Drawing.Color.DarkSlateGray;
            colors[36] = System.Drawing.Color.DarkTurquoise;
            colors[37] = System.Drawing.Color.DarkViolet;
            colors[38] = System.Drawing.Color.DeepPink;
            colors[39] = System.Drawing.Color.DeepSkyBlue;
            colors[40] = System.Drawing.Color.DimGray;
            colors[41] = System.Drawing.Color.DodgerBlue;
            colors[42] = System.Drawing.Color.Firebrick;
            colors[43] = System.Drawing.Color.FloralWhite;
            colors[44] = System.Drawing.Color.ForestGreen;
            colors[45] = System.Drawing.Color.Fuchsia;
            colors[46] = System.Drawing.Color.Firebrick;
            colors[47] = System.Drawing.Color.Gainsboro;
            colors[48] = System.Drawing.Color.GhostWhite;
            colors[49] = System.Drawing.Color.Gold;
            colors[50] = System.Drawing.Color.Goldenrod;
            colors[51] = System.Drawing.Color.Gray;
            colors[53] = System.Drawing.Color.Green;
            colors[54] = System.Drawing.Color.GreenYellow;
            colors[55] = System.Drawing.Color.Honeydew;
            colors[56] = System.Drawing.Color.HotPink;
            colors[57] = System.Drawing.Color.IndianRed;
            colors[58] = System.Drawing.Color.Indigo;
            colors[59] = System.Drawing.Color.Ivory;
            colors[60] = System.Drawing.Color.Khaki;
            colors[61] = System.Drawing.Color.Lavender;
            colors[62] = System.Drawing.Color.LavenderBlush;
            colors[63] = System.Drawing.Color.LawnGreen;
            colors[64] = System.Drawing.Color.LemonChiffon;
            colors[65] = System.Drawing.Color.LightBlue;
            colors[66] = System.Drawing.Color.LightCoral;
            colors[67] = System.Drawing.Color.LightCyan;
            colors[68] = System.Drawing.Color.LightGoldenrodYellow;
            colors[69] = System.Drawing.Color.LightGray;
            colors[70] = System.Drawing.Color.LightGreen;
            colors[71] = System.Drawing.Color.LightPink;
            colors[72] = System.Drawing.Color.LightSalmon;
            colors[73] = System.Drawing.Color.LightSeaGreen;
            colors[74] = System.Drawing.Color.LightSkyBlue;
            colors[75] = System.Drawing.Color.LightSlateGray;
            colors[76] = System.Drawing.Color.LightSteelBlue;
            colors[77] = System.Drawing.Color.LightYellow;
            colors[78] = System.Drawing.Color.Lime;
            colors[79] = System.Drawing.Color.LimeGreen;
            colors[80] = System.Drawing.Color.Linen;
            colors[81] = System.Drawing.Color.Magenta;
            colors[82] = System.Drawing.Color.Maroon;
            colors[83] = System.Drawing.Color.MediumAquamarine;
            colors[84] = System.Drawing.Color.MediumBlue;
            colors[85] = System.Drawing.Color.MediumOrchid;
            colors[86] = System.Drawing.Color.MediumPurple;
            colors[87] = System.Drawing.Color.MediumSeaGreen;
            colors[88] = System.Drawing.Color.MediumSlateBlue;
            colors[89] = System.Drawing.Color.MediumSpringGreen;
            colors[90] = System.Drawing.Color.MediumTurquoise;
            colors[91] = System.Drawing.Color.MediumVioletRed;
            colors[92] = System.Drawing.Color.MidnightBlue;
            colors[93] = System.Drawing.Color.MintCream;
            colors[94] = System.Drawing.Color.MistyRose;
            colors[95] = System.Drawing.Color.Moccasin;
            colors[94] = System.Drawing.Color.NavajoWhite;
            colors[95] = System.Drawing.Color.Navy;
            colors[96] = System.Drawing.Color.OldLace;
            colors[97] = System.Drawing.Color.Olive;
            colors[98] = System.Drawing.Color.OliveDrab;
            colors[99] = System.Drawing.Color.Orange;
            colors[100] = System.Drawing.Color.OrangeRed;
            colors[101] = System.Drawing.Color.Orchid;
            colors[102] = System.Drawing.Color.PaleGoldenrod;
            colors[103] = System.Drawing.Color.PaleGreen;
            colors[104] = System.Drawing.Color.PaleTurquoise;
            colors[105] = System.Drawing.Color.PaleVioletRed;
            colors[106] = System.Drawing.Color.PapayaWhip;
            colors[107] = System.Drawing.Color.PeachPuff;
            colors[108] = System.Drawing.Color.Peru;
            colors[109] = System.Drawing.Color.Pink;
            colors[110] = System.Drawing.Color.Plum;
            colors[111] = System.Drawing.Color.PowderBlue;
            colors[112] = System.Drawing.Color.Purple;
            colors[113] = System.Drawing.Color.Red;
            colors[114] = System.Drawing.Color.RosyBrown;
            colors[115] = System.Drawing.Color.RoyalBlue;
            colors[116] = System.Drawing.Color.SaddleBrown;
            colors[117] = System.Drawing.Color.Salmon;
            colors[118] = System.Drawing.Color.SandyBrown;
            colors[119] = System.Drawing.Color.SeaGreen;
            colors[120] = System.Drawing.Color.SeaShell;
            colors[121] = System.Drawing.Color.Sienna;
            colors[122] = System.Drawing.Color.Silver;
            colors[123] = System.Drawing.Color.SkyBlue;
            colors[124] = System.Drawing.Color.SlateBlue;
            colors[125] = System.Drawing.Color.SlateGray;
            colors[126] = System.Drawing.Color.Snow;
            colors[127] = System.Drawing.Color.SpringGreen;
            colors[128] = System.Drawing.Color.SteelBlue;
            colors[129] = System.Drawing.Color.Tan;
            colors[130] = System.Drawing.Color.Teal;
            colors[131] = System.Drawing.Color.Thistle;
            colors[132] = System.Drawing.Color.Tomato;
            colors[133] = System.Drawing.Color.Transparent;
            colors[134] = System.Drawing.Color.Turquoise;
            colors[135] = System.Drawing.Color.Violet;
            colors[136] = System.Drawing.Color.Wheat;
            colors[137] = System.Drawing.Color.White;
            colors[138] = System.Drawing.Color.WhiteSmoke;
            colors[139] = System.Drawing.Color.Yellow;
            colors[140] = System.Drawing.Color.YellowGreen;

            return colors;
        }
        /// <summary>
        /// Buradan Renkin ismini değiştirebiliriz
        /// </summary>
        /// <param name="GroupName">değişiklik olacak renkin bağlı olduğu grup bu değer boş geçilemez</param>
        /// <param name="newGroupName">grup yeni değeri eğer değer verilirse Groupismi değiştirilir boş geçilirse default değeri kullanılır</param>
        /// <param name="oldColorName">renkin eski ismi boş geçilemez</param>
        /// <param name="newColorName">renkin yeni ismi boş geçilebilir geçilirse default değeri kullanılır</param>
        /// <param name="newHtml">renkin yeni HTML değeri boş geçilebilir geçilirse default değeri kullanılır</param>
        /// <param name="newRGB">renkin yeni RGB değeri boş geçilebilir geçilirse default değeri kullanılır</param>
        /// <returns></returns>
        public int ReplaceColorName(string GroupName,string newGroupName ,string oldColorName,string newColorName, string newHtml,string newRGB)
        {
            try
            {
                for (int i = 0; i < Colors.Count; i++)
                {
                    ListEra scolor = (ListEra)Colors[i];
                    if (scolor.ColorName == newColorName && scolor.GroupName == GroupName)
                    {
                        return 0;
                    }
                }
                for (int i = 0; i < Colors.Count; i++)
                {
                    ListEra color = (ListEra)Colors[i];
                    if (color.GroupName == GroupName & color.ColorName == oldColorName)
                    {
                        if (newGroupName.Length > 0) color.GroupName = newGroupName;
                        if(newColorName.Length>0) color.ColorName = newColorName;
                        if(newHtml.Length>0) color.Html = newHtml;
                        if(newRGB.Length>0) color.Rgb = newRGB;
                        Colors.Insert(i+1, color);
                        Colors.RemoveAt(i);
                        break;
                    }
                }
                return 1;
            }
            catch {}
            return 0;
        }

        public int DelColor(string GroupName, string ColorName)
        {
            try
            {
                for (int i = 0; i < Colors.Count; i++)
                {
                    ListEra color = (ListEra)Colors[i];
                    if (color.GroupName == GroupName & color.ColorName == ColorName)
                    {
                        Colors.RemoveAt(i);
                        break;
                    }
                }
                return 1;
            }
            catch { }

            return 0;
        }

        string saveAllStr;
        public int SaveAll()
        {
            try
            {
                for (int i = 0; i < Groups.Count; i++)
                {
                    saveAllStr += GroupStringStart + Groups[i].ToString() + GroupStringEnd + Environment.NewLine;
                    for (int a = 0; a < Colors.Count; a++)
                    {
                        ListEra color = (ListEra)Colors[a];
                        if (color.GroupName == Groups[i].ToString())
                        {
                            saveAllStr += color.ColorName + "=" + color.Html + ";" + color.Rgb + Environment.NewLine;
                        }
                    }
                }
                File.WriteAllText(listFile, saveAllStr, Encoding.Default);
                return 1;
            }
            catch { }
            return 0;
        }

        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);
        [DllImport("gdi32")]
        private static extern int BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        [DllImport("user32")]
        private static extern int GetWindowPlacement(IntPtr hwnd, ref WINDOWPLACEMENT lpwndpl);
        [DllImport("user32")]
        public static extern IntPtr WindowFromPoint(int xPoint, int yPoint);

        private RECT getInWindowClassRect(int ClassId)
        {
            WINDOWPLACEMENT plac = new WINDOWPLACEMENT();
            GetWindowPlacement((IntPtr)ClassId, ref plac);
            if (plac.showCmd == 1)
            {
                return plac.rcNormalPosition;
            }
            if (plac.showCmd == 2)
            {
                RECT rect = new RECT();
                rect.Left = 0;
                rect.Top = 0;
                rect.Bottom = 0;
                rect.Right = 0;
                return rect;
            }
            if (plac.showCmd == 3)
            {
                RECT rect = new RECT();
                rect.Left = plac.ptMaxPosition.x;
                rect.Top = plac.ptMaxPosition.y;
                rect.Bottom = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom;
                rect.Right = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right;
                return rect;
            }
            return plac.rcNormalPosition;
        }

        public Bitmap getWindowImageFromPoint(int x, int y)
        {
            IntPtr ClassId = WindowFromPoint(x, y);
            return getControlDC(ClassId);
        }

        private Bitmap getControlDC(IntPtr hObject)
        {
            Bitmap bmp;
            IntPtr dc1 = IntPtr.Zero;
            IntPtr dc2;
            Graphics g;
            RECT rect = getInWindowClassRect(hObject.ToInt32());
            int width = (rect.Right - rect.Left);
            int height = (rect.Bottom - rect.Top);
            bmp = new Bitmap(width, height);
            g = Graphics.FromImage(bmp);

            dc1 = g.GetHdc();
            dc2 = GetWindowDC(hObject);

            BitBlt(dc1, 0, 0, width, height, dc2, 0, 0, (int)TernaryRasterOperations.SRCCOPY);

            g.ReleaseHdc(dc1);
            return bmp;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public struct ListEra
    {
        public string GroupName;
        public string ColorName;
        public string Html;
        public string Rgb;
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    public enum TernaryRasterOperations : int
    {
        SRCCOPY = 0x00CC0020, /* dest = source*/
        SRCPAINT = 0x00EE0086, /* dest = source OR dest*/
        SRCAND = 0x008800C6, /* dest = source AND dest*/
        SRCINVERT = 0x00660046, /* dest = source XOR dest*/
        SRCERASE = 0x00440328, /* dest = source AND (NOT dest )*/
        NOTSRCCOPY = 0x00330008, /* dest = (NOT source)*/
        NOTSRCERASE = 0x001100A6, /* dest = (NOT src) AND (NOT dest) */
        MERGECOPY = 0x00C000CA, /* dest = (source AND pattern)*/
        MERGEPAINT = 0x00BB0226, /* dest = (NOT source) OR dest*/
        PATCOPY = 0x00F00021, /* dest = pattern*/
        PATPAINT = 0x00FB0A09, /* dest = DPSnoo*/
        PATINVERT = 0x005A0049, /* dest = pattern XOR dest*/
        DSTINVERT = 0x00550009, /* dest = (NOT dest)*/
        BLACKNESS = 0x00000042, /* dest = BLACK*/
        WHITENESS = 0x00FF0062, /* dest = WHITE*/


    };
    [StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOWPLACEMENT
    {
        public int Length;
        public int flags;
        public int showCmd;
        public POINT ptMinPosition;
        public POINT ptMaxPosition;
        public RECT rcNormalPosition;
    }
}

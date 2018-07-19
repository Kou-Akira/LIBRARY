﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LIBRARY
{
	class PublicVar
	{
		public const int IMAGE_MAX_SIZE = 1024 * 1024;
		public static int GuestFlag = 0;
		public static string DeletePath = "";
		public static string Delpic = "";
		public static int ReturnValue = -233;
		public static int TEMP = -1;
		public static ClassBook[] currentBookList;
		public static ClassBook nowBook;
		public static ClassABook nowABook;
		public static ClassABook[] eachBookState;
		public static int bookTotalAmount;
		public static Image LoadHeadImage(string name)
		{
			switch (name[0])
			{
				case 'A':
				case 'a':
					return Properties.Resources.A;
				case 'B':
				case 'b':
					return Properties.Resources.B;
				case 'C':
				case 'c':
					return Properties.Resources.C;
				case 'D':
				case 'd':
					return Properties.Resources.D;
				case 'E':
				case 'e':
					return Properties.Resources.E;
				case 'F':
				case 'f':
					return Properties.Resources.F;
				case 'G':
				case 'g':
					return Properties.Resources.G;
				case 'H':
				case 'h':
					return Properties.Resources.H;
				case 'I':
				case 'i':
					return Properties.Resources.I;
				case 'J':
				case 'j':
					return Properties.Resources.J;
				case 'K':
				case 'k':
					return Properties.Resources.K;
				case 'L':
				case 'l':
					return Properties.Resources.L;
				case 'M':
				case 'm':
					return Properties.Resources.M;
				case 'N':
				case 'n':
					return Properties.Resources.N;
				case 'O':
				case 'o':
					return Properties.Resources.O;
				case 'P':
				case 'p':
					return Properties.Resources.P;
				case 'Q':
				case 'q':
					return Properties.Resources.Q;
				case 'R':
				case 'r':
					return Properties.Resources.R;
				case 'S':
				case 's':
					return Properties.Resources.S;
				case 'T':
				case 't':
					return Properties.Resources.T;
				case 'U':
				case 'u':
					return Properties.Resources.U;
				case 'V':
				case 'v':
					return Properties.Resources.V;
				case 'W':
				case 'w':
					return Properties.Resources.W;
				case 'X':
				case 'x':
					return Properties.Resources.X;
				case 'Y':
				case 'y':
					return Properties.Resources.Y;
				case 'Z':
				case 'z':
					return Properties.Resources.Z;
				default:
					return Properties.Resources.DefaultHead;
			}
		}
		public static byte[] ImageToBytes(Image image)
		{
			ImageFormat format = image.RawFormat;
			using (MemoryStream ms = new MemoryStream())
			{
				if (format.Equals(ImageFormat.Jpeg))
				{
					image.Save(ms, ImageFormat.Jpeg);
				}
				else if (format.Equals(ImageFormat.Png))
				{
					image.Save(ms, ImageFormat.Png);
				}
				else if (format.Equals(ImageFormat.Bmp))
				{
					image.Save(ms, ImageFormat.Bmp);
				}
				else if (format.Equals(ImageFormat.Gif))
				{
					image.Save(ms, ImageFormat.Gif);
				}
				else if (format.Equals(ImageFormat.Icon))
				{
					image.Save(ms, ImageFormat.Icon);
				}
				byte[] buffer = new byte[ms.Length];
				//Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
				ms.Seek(0, SeekOrigin.Begin);
				ms.Read(buffer, 0, buffer.Length);
				return buffer;
			}
		}

		/// <summary>
		/// Convert Byte[] to Image
		/// </summary>
		/// <param name="buffer"></param>
		/// <returns></returns>
		public static Image BytesToImage(byte[] buffer)
		{
			MemoryStream ms = new MemoryStream(buffer);
			Image image = System.Drawing.Image.FromStream(ms);
			return image;
		}
		public static ClassUserBasicInfo logUser;
		public static ClassUser classUser;
		public static ClassComment nowComment;
		public static ClassComment[] currentCommentList;
		public static int commentTotalAmount;
		public static byte[] pic;
		public static ArrayList picList = new ArrayList(20);
		public static void CacheCheck()
		{
			if (!Directory.Exists(@"cache\"))
			{
				Directory.CreateDirectory(@"cache\");
				return;
			}
			DirectoryInfo cacheDirectory = new DirectoryInfo(@"cache\");
			FileInfo[] files = cacheDirectory.GetFiles();

			long cacheSize = 0;

			foreach (FileInfo file in files)
			{
				cacheSize += file.Length;
			}
			if (cacheSize > (1024 * 1024 * 10))
			{
				FileComparer fileComparer = new FileComparer();
				Array.Sort(files, fileComparer);
				for (int i = 0; i < files.Length / 2; i++)
				{
					files[i].Delete();
				}
			}

		}

		public static ClassAdmin nowAdmin;
		public static ClassUserBasicInfo[] adminSearchUser;
		public static int userTotalAmount = 0;
		public static ClassBookHis[] bookhis;
		public static ClassBookHis[] scheduleList;

		public static int bookAmount, userAmount;
		public static double borrowRate;

		public class FileComparer : IComparer
		{
			int IComparer.Compare(Object o1, Object o2)
			{
				FileInfo fi1 = o1 as FileInfo;
				FileInfo fi2 = o2 as FileInfo;
				return -1 * fi1.CreationTime.CompareTo(fi2.CreationTime);
			}
		}

		public static Image PickHeadImage(string s)
		{
			if (s == "") return null;
			if (s.Substring(0, 1) == "蒯")
				return Properties.Resources.K;
            else if (s.Substring(0, 1) == "柚")
                return Properties.Resources.Y;
            if ((s[0] >= 'a' && s[0] <= 'z') || (s[0] >= 'A' && s[0] <= 'Z'))
			{
				switch (s[0])
				{
					case 'A':
					case 'a':
						return Properties.Resources.A;
					case 'B':
					case 'b':
						return Properties.Resources.B;
					case 'C':
					case 'c':
						return Properties.Resources.C;
					case 'D':
					case 'd':
						return Properties.Resources.D;
					case 'E':
					case 'e':
						return Properties.Resources.E;
					case 'F':
					case 'f':
						return Properties.Resources.F;
					case 'G':
					case 'g':
						return Properties.Resources.G;
					case 'H':
					case 'h':
						return Properties.Resources.H;
					case 'I':
					case 'i':
						return Properties.Resources.I;
					case 'J':
					case 'j':
						return Properties.Resources.J;
					case 'K':
					case 'k':
						return Properties.Resources.K;
					case 'L':
					case 'l':
						return Properties.Resources.L;
					case 'M':
					case 'm':
						return Properties.Resources.M;
					case 'N':
					case 'n':
						return Properties.Resources.N;
					case 'O':
					case 'o':
						return Properties.Resources.O;
					case 'P':
					case 'p':
						return Properties.Resources.P;
					case 'Q':
					case 'q':
						return Properties.Resources.Q;
					case 'R':
					case 'r':
						return Properties.Resources.R;
					case 'S':
					case 's':
						return Properties.Resources.S;
					case 'T':
					case 't':
						return Properties.Resources.T;
					case 'U':
					case 'u':
						return Properties.Resources.U;
					case 'V':
					case 'v':
						return Properties.Resources.V;
					case 'W':
					case 'w':
						return Properties.Resources.W;
					case 'X':
					case 'x':
						return Properties.Resources.X;
					case 'Y':
					case 'y':
						return Properties.Resources.Y;
					case 'Z':
					case 'z':
						return Properties.Resources.Z;
					default:
						return Properties.Resources.DefaultHead;
				}

			}
			else
			{
				byte[] b = System.Text.UnicodeEncoding.Default.GetBytes(s);
				string tmp = System.Text.UnicodeEncoding.Default.GetString(b, 0, 2);
				tmp = HZToCode(tmp);
				if (tmp == "")
					return Properties.Resources.DefaultHead;
				else switch (tmp[0])
					{
						case 'A':
						case 'a':
							return Properties.Resources.A;
						case 'B':
						case 'b':
							return Properties.Resources.B;
						case 'C':
						case 'c':
							return Properties.Resources.C;
						case 'D':
						case 'd':
							return Properties.Resources.D;
						case 'E':
						case 'e':
							return Properties.Resources.E;
						case 'F':
						case 'f':
							return Properties.Resources.F;
						case 'G':
						case 'g':
							return Properties.Resources.G;
						case 'H':
						case 'h':
							return Properties.Resources.H;
						case 'I':
						case 'i':
							return Properties.Resources.I;
						case 'J':
						case 'j':
							return Properties.Resources.J;
						case 'K':
						case 'k':
							return Properties.Resources.K;
						case 'L':
						case 'l':
							return Properties.Resources.L;
						case 'M':
						case 'm':
							return Properties.Resources.M;
						case 'N':
						case 'n':
							return Properties.Resources.N;
						case 'O':
						case 'o':
							return Properties.Resources.O;
						case 'P':
						case 'p':
							return Properties.Resources.P;
						case 'Q':
						case 'q':
							return Properties.Resources.Q;
						case 'R':
						case 'r':
							return Properties.Resources.R;
						case 'S':
						case 's':
							return Properties.Resources.S;
						case 'T':
						case 't':
							return Properties.Resources.T;
						case 'U':
						case 'u':
							return Properties.Resources.U;
						case 'V':
						case 'v':
							return Properties.Resources.V;
						case 'W':
						case 'w':
							return Properties.Resources.W;
						case 'X':
						case 'x':
							return Properties.Resources.X;
						case 'Y':
						case 'y':
							return Properties.Resources.Y;
						case 'Z':
						case 'z':
							return Properties.Resources.Z;
						default:
							return Properties.Resources.DefaultHead;
					}

			}
		}
		//typeStr是指拼音还是五笔码
		public static string HZToCode(string chineseStr)
		{
			try
			{
				string resultStr = "";
				byte[] arrCN = Encoding.Default.GetBytes(chineseStr);
				if (arrCN.Length > 1)
				{
					int area = (short)arrCN[0];
					int pos = (short)arrCN[1];
					int code = (area << 8) + pos;
					int[] areacode = { 45217, 45253, 45761, 46318, 46826, 47010, 47297, 47614,
					   48119, 48119, 49062, 49324, 49896, 50371, 50614, 50622, 50906, 51387,
					   51446, 52218, 52698, 52698, 52698, 52980, 53689, 54481 };
					for (int i = 0; i < 26; i++)
					{
						int max = 55290;
						if (i != 25) max = areacode[i + 1];
						if (areacode[i] <= code && code < max)
						{
							resultStr = Encoding.Default.GetString(new byte[] { (byte)(65 + i) });
							break;
						}
					}
				}

				return resultStr;
			}
			catch (Exception ex)
			{
				throw new Exception("错误:", ex);
			}
		}
	}
}
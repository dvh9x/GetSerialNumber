using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GetSerialNumber
{
	public sealed class GClass11
	{
		// Token: 0x06000150 RID: 336 RVA: 0x0000275D File Offset: 0x0000095D
		public static string smethod_0()
		{
			return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000276E File Offset: 0x0000096E
		public static void smethod_1(Exception exception_0)
		{
			Console.WriteLine(exception_0.StackTrace);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		public static string[] smethod_2(string string_0, string string_1)
		{
			return string_0.Split(new string[]
			{
			string_1
			}, StringSplitOptions.None);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000F6DC File Offset: 0x0000D8DC
		public static string smethod_3(string string_0)
		{
			TextReader textReader = null;
			try
			{
				textReader = new StreamReader(string_0);
				return textReader.ReadToEnd();
			}
			catch (Exception)
			{
			}
			finally
			{
				try
				{
					textReader.Close();
				}
				catch (Exception)
				{
				}
			}
			return null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000F738 File Offset: 0x0000D938
		public static void smethod_4(string string_0, string string_1, bool bool_0)
		{
			TextWriter textWriter = null;
			try
			{
				textWriter = new StreamWriter(string_0, bool_0);
				textWriter.WriteLine(string_1);
			}
			catch (Exception)
			{
			}
			finally
			{
				try
				{
					textWriter.Close();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000F794 File Offset: 0x0000D994
		public static string smethod_5(string string_0)
		{
			WebClient webClient = new WebClient();
			StreamReader streamReader = new StreamReader(webClient.OpenRead(string_0));
			return streamReader.ReadToEnd();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000F7BC File Offset: 0x0000D9BC
		public static string smethod_6(string string_0)
		{
			try
			{
				string text = "2132984shbeq94kjrb8795321asd3023";
				string str = GClass11.smethod_10(string_0);
				byte[] bytes = Encoding.UTF8.GetBytes(text + str);
				for (int i = 0; i < bytes.Length; i++)
				{
					bytes[i] = (byte)((int)bytes[i] + text.Length);
				}
				return Convert.ToBase64String(bytes).Replace('\n', '#');
			}
			catch (Exception exception_)
			{
				GClass11.smethod_1(exception_);
			}
			return string.Empty;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000F83C File Offset: 0x0000DA3C
		public static string smethod_7(string string_0)
		{
			try
			{
				string text = "2132984shbeq94kjrb8795321asd3023";
				byte[] array = Convert.FromBase64String(string_0.Replace('\n', '#'));
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (byte)((int)array[i] - text.Length);
				}
				string text2 = Encoding.UTF8.GetString(array);
				text2 = text2.Replace(text, string.Empty);
				return GClass11.smethod_11(text2).Replace('#', '\n');
			}
			catch (Exception exception_)
			{
				GClass11.smethod_1(exception_);
			}
			return string.Empty;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000F8CC File Offset: 0x0000DACC
		public static string smethod_8(string string_0)
		{
			try
			{
				string text = "45635eb26fccee6esc6a6d5f6e784";
				byte[] array = Convert.FromBase64String(string_0.Replace('\n', '#'));
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (byte)((int)array[i] - text.Length);
				}
				string text2 = Encoding.UTF8.GetString(array);
				text2 = text2.Replace(text, string.Empty);
				return GClass11.smethod_11(text2).Replace('#', '\n');
			}
			catch (Exception exception_)
			{
				GClass11.smethod_1(exception_);
			}
			return string.Empty;
		}

		// mã hóa chuỗi
		public static string smethod_9(string string_0)
		{
			try
			{
				string text = "4563b0fde5eb26fccee6e6a6d5f6e784";
				string str = GClass11.smethod_10(string_0);
				byte[] bytes = Encoding.UTF8.GetBytes(text + str);
				for (int i = 0; i < bytes.Length; i++)
				{
					bytes[i] = (byte)((int)bytes[i] + text.Length);
				}
				return Convert.ToBase64String(bytes).Replace('\n', '#');
			}
			catch (Exception exception_)
			{
				GClass11.smethod_1(exception_);
			}
			return null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		private static string smethod_10(string string_0)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(string_0);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		public static string smethod_11(string string_0)
		{
			byte[] bytes = Convert.FromBase64String(string_0);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000FA18 File Offset: 0x0000DC18
		public static long smethod_12(DateTime dateTime_1)
		{
			return (long)(dateTime_1.ToUniversalTime() - GClass11.dateTime_0).TotalMilliseconds;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000FA40 File Offset: 0x0000DC40
		public static DateTime smethod_13(long long_0)
		{
			long ticks = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
			return new DateTime(ticks + long_0 * 10000L, DateTimeKind.Utc).ToLocalTime();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000FA84 File Offset: 0x0000DC84
		public static byte[] smethod_14(string string_0)
		{
			FileStream fileStream = null;
			BinaryReader binaryReader = null;
			try
			{
				fileStream = new FileStream(string_0, FileMode.Open);
				binaryReader = new BinaryReader(fileStream);
				byte[] array = new byte[fileStream.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = binaryReader.ReadByte();
				}
				return array;
			}
			catch (Exception)
			{
			}
			finally
			{
				try
				{
					binaryReader.Close();
				}
				catch (Exception)
				{
				}
				try
				{
					fileStream.Close();
				}
				catch (Exception)
				{
				}
			}
			return null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000FB24 File Offset: 0x0000DD24
		public static void smethod_15(string string_0, byte[] byte_0)
		{
			FileStream fileStream = null;
			try
			{
				fileStream = File.Create(string_0);
				fileStream.Write(byte_0, 0, byte_0.Length);
			}
			catch (Exception)
			{
			}
			finally
			{
				try
				{
					fileStream.Close();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000277B File Offset: 0x0000097B
		public static void smethod_16(string string_0, int int_0)
		{
			GClass11.smethod_15(string_0, Encoding.ASCII.GetBytes(string.Concat(int_0)));
		}
		// Token: 0x04000107 RID: 263
		private static DateTime dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	}
}

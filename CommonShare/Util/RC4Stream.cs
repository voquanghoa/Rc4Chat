using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonShare.Util
{
	public class RC4Stream
	{
		public string DecodeKey
		{
			set
			{
				rc4Converter.DecodeKey = value;
			}
			get
			{
				return rc4Converter.DecodeKey;
			}
		}

		private BinaryReader binReader;
		private BinaryWriter binWriter;

		private byte[] buffer = new byte[10 * 1024];
		private RC4Converter rc4Converter;
		private Encoding encoding = Encoding.ASCII;

		public RC4Stream(Stream stream,string decodeKey)
		{
			this.binReader = new BinaryReader(stream);
			this.binWriter = new BinaryWriter(stream);

			this.rc4Converter = new RC4Converter(decodeKey);
		}

		public string Send(string message)
		{
			return Send(encoding.GetBytes(message));
		}

		public string Send(byte[] byteData)
		{
			var encryptedData = rc4Converter.Decrypt(byteData);
			binWriter.Write(encryptedData.Length);
			binWriter.Write(encryptedData);
			binWriter.Flush();

			return ConvertByteArrayToString(encryptedData);
		}	

		public Tuple<byte[], byte[]> ReadBytes()
		{
			int length = binReader.ReadInt32();
			var originData = binReader.ReadBytes(length);
			var decriptedData = rc4Converter.Decrypt(originData);

			return new Tuple<byte[], byte[]>(originData, decriptedData);
		}

		public Tuple<string, string> ReadString()
		{
			var data = ReadBytes();
			var origin = ConvertByteArrayToString(data.Item1);
			var encripted = encoding.GetString(data.Item2);

			return new Tuple<string, string>(origin, encripted);
		}

		private string ConvertByteArrayToString(byte[] data)
		{
			return string.Join(" ", data.Select(x => x.ToString("X2")).ToArray());
		}
	}
}

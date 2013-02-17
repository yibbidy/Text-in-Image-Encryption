// Contributors:  Justin Hutchison (yibbidy@gmail.com)

using System;
using System.Drawing;

namespace Cryption
{
	/// <summary>
	/// This class will encrypt a byte array into a Bitmap or decrypt the byte array from an encoded Bitmap
	/// </summary>
	public class JCrypt {
		static public Bitmap Encode(Bitmap decoded, byte[] data) {
			Bitmap encoded = (Bitmap)decoded.Clone();

			Color c = decoded.GetPixel(decoded.Width-1, decoded.Height-1);
			int seed = decoded.GetPixel(decoded.Width-1, decoded.Height-1).ToArgb();
			Random random = new Random(seed);
			
			bool[,] dirty = new bool[(int)decoded.Height/3, (int)decoded.Width/3];
			for( int y=0; y<dirty.GetLength(0); ++y ) {
				for( int x=0; x<dirty.GetLength(1); ++x ) dirty[y, x] = false;
			}
			// encode length of data
			EncodeData(decoded, ref encoded, ref random, ref dirty, (byte)data.Length);
			
			// encode data
			foreach( byte b in data ) EncodeData(decoded, ref encoded, ref random, ref dirty, b);
			
			return encoded;
		}

		static public byte[] Decode(Bitmap encoded) {
			int seed = encoded.GetPixel(encoded.Width-1, encoded.Height-1).ToArgb();
			Random random = new Random(seed);
			
			bool[,] dirty = new bool[(int)encoded.Height/3, (int)encoded.Width/3];
			for( int y=0; y<dirty.GetLength(0); ++y ) {
				for( int x=0; x<dirty.GetLength(1); ++x ) dirty[y, x] = false;
			}

			int length = DecodeData(encoded, ref random, ref dirty);
			byte[] decoded = new byte[length];

			for( int i=0; i<length; ++i ) decoded[i] = DecodeData(encoded, ref random, ref dirty);

			return decoded;
		}


		
		
		
		static private void EncodeData(Bitmap decoded, ref Bitmap encoded, ref Random random, ref bool[,] dirty, byte data) {
			int x = 0;
			int y = 0;
			do {
				x = (int)(random.NextDouble()*(decoded.Width-1)/3);
				y = (int)(random.NextDouble()*(decoded.Height-1)/3);
			} while( dirty[y, x] );
			dirty[y, x] = true;

			x = x*3 + 1;
			y = y*3 + 1;

			Color average = SpecialAverage(decoded, x, y);
			int sign = 0;
			if( average.R > 128 ) sign = 1;
			else sign = -1;

			int d1 = data/3;
			int d2 = d1 + data%3;

			Color encodedPixel = Color.FromArgb(
				average.R + sign*d1,
				average.G + sign*d1,
				average.B + sign*d2 );

			encoded.SetPixel(x, y, encodedPixel);
		}

		static private byte DecodeData(Bitmap encoded, ref Random random, ref bool[,] dirty) {
			int x = 0;
			int y = 0;
			do {
				x = (int)(random.NextDouble()*(encoded.Width-1)/3);
				y = (int)(random.NextDouble()*(encoded.Height-1)/3);
			} while( dirty[y, x] );
			dirty[y, x] = true;

			x = x*3 + 1;
			y = y*3 + 1;

			Color encodedPixel = encoded.GetPixel(x, y);
			Color average = SpecialAverage(encoded, x, y);

			byte decoded = 0;

			int sign = 0;
			if( average.R>128 ) sign = 1;
			else sign = -1;

			decoded += (byte)(sign*encodedPixel.R - sign*average.R);
			decoded += (byte)(sign*encodedPixel.G - sign*average.G);
			decoded += (byte)(sign*encodedPixel.B - sign*average.B);

			return decoded;
		}

		static private Color SpecialAverage(Bitmap bitmap, int x, int y) {
			Color p1 = bitmap.GetPixel(x-1, y-1);
			Color p2 = bitmap.GetPixel(x, y-1);
			Color p3 = bitmap.GetPixel(x+1, y-1);
			Color p4 = bitmap.GetPixel(x-1, y);
			Color p5 = bitmap.GetPixel(x+1, y);
			Color p6 = bitmap.GetPixel(x-1, y+1);
			Color p7 = bitmap.GetPixel(x, y+1);
			Color p8 = bitmap.GetPixel(x+1, y+1);

			int r = Math.Min(Math.Max((128 + p1.R + p2.R + p3.R + p4.R + p5.R + p6.R + p7.R + p8.R) / 9, 87), 168);
			int g = Math.Min(Math.Max((128 + p1.G + p2.G + p3.G + p4.G + p5.G + p6.G + p7.G + p8.G) / 9, 87), 168);
			int b = Math.Min(Math.Max((128 + p1.B + p2.B + p3.B + p4.B + p5.B + p6.B + p7.B + p8.B) / 9, 87), 168);

			return Color.FromArgb(r, g, b);
		}

	}
}

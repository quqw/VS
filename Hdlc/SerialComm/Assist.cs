﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SerialComm
{
    public class Assist
    {

        public static ushort HdlcFcs16(byte[] cp)
        {
            return HdlcFcs16(cp, cp.Length);
        }
        public static ushort HdlcFcs16(byte[] cp,int length)
        {
            ushort[] FCS_Tab = {
                0x0000, 0x1189, 0x2312, 0x329b, 0x4624, 0x57ad, 0x6536, 0x74bf,
                0x8c48, 0x9dc1, 0xaf5a, 0xbed3, 0xca6c, 0xdbe5, 0xe97e, 0xf8f7,
                0x1081, 0x0108, 0x3393, 0x221a, 0x56a5, 0x472c, 0x75b7, 0x643e,
                0x9cc9, 0x8d40, 0xbfdb, 0xae52, 0xdaed, 0xcb64, 0xf9ff, 0xe876,
                0x2102, 0x308b, 0x0210, 0x1399, 0x6726, 0x76af, 0x4434, 0x55bd,
                0xad4a, 0xbcc3, 0x8e58, 0x9fd1, 0xeb6e, 0xfae7, 0xc87c, 0xd9f5,
                0x3183, 0x200a, 0x1291, 0x0318, 0x77a7, 0x662e, 0x54b5, 0x453c,
                0xbdcb, 0xac42, 0x9ed9, 0x8f50, 0xfbef, 0xea66, 0xd8fd, 0xc974,
                0x4204, 0x538d, 0x6116, 0x709f, 0x0420, 0x15a9, 0x2732, 0x36bb,
                0xce4c, 0xdfc5, 0xed5e, 0xfcd7, 0x8868, 0x99e1, 0xab7a, 0xbaf3,
                0x5285, 0x430c, 0x7197, 0x601e, 0x14a1, 0x0528, 0x37b3, 0x263a,
                0xdecd, 0xcf44, 0xfddf, 0xec56, 0x98e9, 0x8960, 0xbbfb, 0xaa72,
                0x6306, 0x728f, 0x4014, 0x519d, 0x2522, 0x34ab, 0x0630, 0x17b9,
                0xef4e, 0xfec7, 0xcc5c, 0xddd5, 0xa96a, 0xb8e3, 0x8a78, 0x9bf1,
                0x7387, 0x620e, 0x5095, 0x411c, 0x35a3, 0x242a, 0x16b1, 0x0738,
                0xffcf, 0xee46, 0xdcdd, 0xcd54, 0xb9eb, 0xa862, 0x9af9, 0x8b70,
                0x8408, 0x9581, 0xa71a, 0xb693, 0xc22c, 0xd3a5, 0xe13e, 0xf0b7,
                0x0840, 0x19c9, 0x2b52, 0x3adb, 0x4e64, 0x5fed, 0x6d76, 0x7cff,
                0x9489, 0x8500, 0xb79b, 0xa612, 0xd2ad, 0xc324, 0xf1bf, 0xe036,
                0x18c1, 0x0948, 0x3bd3, 0x2a5a, 0x5ee5, 0x4f6c, 0x7df7, 0x6c7e,
                0xa50a, 0xb483, 0x8618, 0x9791, 0xe32e, 0xf2a7, 0xc03c, 0xd1b5,
                0x2942, 0x38cb, 0x0a50, 0x1bd9, 0x6f66, 0x7eef, 0x4c74, 0x5dfd,
                0xb58b, 0xa402, 0x9699, 0x8710, 0xf3af, 0xe226, 0xd0bd, 0xc134,
                0x39c3, 0x284a, 0x1ad1, 0x0b58, 0x7fe7, 0x6e6e, 0x5cf5, 0x4d7c,
                0xc60c, 0xd785, 0xe51e, 0xf497, 0x8028, 0x91a1, 0xa33a, 0xb2b3,
                0x4a44, 0x5bcd, 0x6956, 0x78df, 0x0c60, 0x1de9, 0x2f72, 0x3efb,
                0xd68d, 0xc704, 0xf59f, 0xe416, 0x90a9, 0x8120, 0xb3bb, 0xa232,
                0x5ac5, 0x4b4c, 0x79d7, 0x685e, 0x1ce1, 0x0d68, 0x3ff3, 0x2e7a,
                0xe70e, 0xf687, 0xc41c, 0xd595, 0xa12a, 0xb0a3, 0x8238, 0x93b1,
                0x6b46, 0x7acf, 0x4854, 0x59dd, 0x2d62, 0x3ceb, 0x0e70, 0x1ff9,
                0xf78f, 0xe606, 0xd49d, 0xc514, 0xb1ab, 0xa022, 0x92b9, 0x8330,
                0x7bc7, 0x6a4e, 0x58d5, 0x495c, 0x3de3, 0x2c6a, 0x1ef1, 0x0f78
                };
            int fcs = 0xffff;//初值
            ushort fcstmp;
            ushort tmp;
            length = length > cp.Length ? cp.Length : length;
            for (int i=0;i< length; i++)
            {
                tmp = cp[i];
                tmp = (ushort)((fcs ^ tmp) & 0xff);
                fcstmp = FCS_Tab[tmp];
                fcs = (fcs >> 8) ^ fcstmp;
            }
            return (ushort)(fcs ^ 0xffff);
        }


        public static byte Crc8Ccitt(byte[] dat)
        {
            byte[] CRC8TABLE ={0x00,0x1D,0x3A,0x27,0x74,0x69,0x4E,0x53,0xE8,0xF5,0xD2,0xCF,0x9C,0x81,0xA6,0xBB,
                    0xCD,0xD0,0xF7,0xEA,0xB9,0xA4,0x83,0x9E,0x25,0x38,0x1F,0x02,0x51,0x4C,0x6B,0x76,
                    0x87,0x9A,0xBD,0xA0,0xF3,0xEE,0xC9,0xD4,0x6F,0x72,0x55,0x48,0x1B,0x06,0x21,0x3C,
                    0x4A,0x57,0x70,0x6D,0x3E,0x23,0x04,0x19,0xA2,0xBF,0x98,0x85,0xD6,0xCB,0xEC,0xF1,
                    0x13,0x0E,0x29,0x34,0x67,0x7A,0x5D,0x40,0xFB,0xE6,0xC1,0xDC,0x8F,0x92,0xB5,0xA8,
                    0xDE,0xC3,0xE4,0xF9,0xAA,0xB7,0x90,0x8D,0x36,0x2B,0x0C,0x11,0x42,0x5F,0x78,0x65,
                    0x94,0x89,0xAE,0xB3,0xE0,0xFD,0xDA,0xC7,0x7C,0x61,0x46,0x5B,0x08,0x15,0x32,0x2F,
                    0x59,0x44,0x63,0x7E,0x2D,0x30,0x17,0x0A,0xB1,0xAC,0x8B,0x96,0xC5,0xD8,0xFF,0xE2,
                    0x26,0x3B,0x1C,0x01,0x52,0x4F,0x68,0x75,0xCE,0xD3,0xF4,0xE9,0xBA,0xA7,0x80,0x9D,
                    0xEB,0xF6,0xD1,0xCC,0x9F,0x82,0xA5,0xB8,0x03,0x1E,0x39,0x24,0x77,0x6A,0x4D,0x50,
                    0xA1,0xBC,0x9B,0x86,0xD5,0xC8,0xEF,0xF2,0x49,0x54,0x73,0x6E,0x3D,0x20,0x07,0x1A,
                    0x6C,0x71,0x56,0x4B,0x18,0x05,0x22,0x3F,0x84,0x99,0xBE,0xA3,0xF0,0xED,0xCA,0xD7,
                    0x35,0x28,0x0F,0x12,0x41,0x5C,0x7B,0x66,0xDD,0xC0,0xE7,0xFA,0xA9,0xB4,0x93,0x8E,
                    0xF8,0xE5,0xC2,0xDF,0x8C,0x91,0xB6,0xAB,0x10,0x0D,0x2A,0x37,0x64,0x79,0x5E,0x43,
                    0xB2,0xAF,0x88,0x95,0xC6,0xDB,0xFC,0xE1,0x5A,0x47,0x60,0x7D,0x2E,0x33,0x14,0x09,
                    0x7F,0x62,0x45,0x58,0x0B,0x16,0x31,0x2C,0x97,0x8A,0xAD,0xB0,0xE3,0xFE,0xD9,0xC4
            };
            int i;
            byte j = 0xFF;
            for (i = 0; i < dat.Length; i++)
                j = CRC8TABLE[(byte)(j ^ dat[i])];
            return j;
        }
        public static string ToHexString(byte[] bytes,string gap) // 0xae00cf => "AE 00 CF "
        {
            string hexString = string.Empty;
            int i;
            if (bytes != null && bytes.Length>0)
            {
                StringBuilder strB = new StringBuilder();
                for (i = 0; i < bytes.Length-1; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                    if (gap.Length > 0)
                        strB.Append(gap);
                }
                strB.Append(bytes[i].ToString("X2"));
                hexString = strB.ToString();

            }
            return hexString;
        }
        public static string ToHexString(byte[] bytes)
        {
            return ToHexString(bytes, "");
        }

        private static bool IsHexDigit(char c)
        {
            char[] hex_ch = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = 0; i < hex_ch.Length; i++)
            {
                if (hex_ch[i] == c)
                    return true;
            }
            return false;
        }
        public static byte[] HexToBytes(string hexString)
        {
            int discarded = 0;
            string newString = "";
            char c;
            // remove all none A-F, 0-9, characters
            for (int i = 0; i < hexString.Length; i++)
            {
                c = hexString[i];
                if (IsHexDigit(c))
                    newString += c;
                else
                    discarded++;
            }
            // if odd number of characters, discard last character
            if (newString.Length % 2 != 0)
            {
                discarded++;
                newString = newString.Substring(0, newString.Length - 1);
            }

            int byteLength = newString.Length / 2;
            byte[] bytes = new byte[byteLength];
            string hex;
            int j = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                hex = new String(new Char[] { newString[j], newString[j + 1] });
                bytes[i] = HexToByte(hex);
                j = j + 2;
            }
            return bytes;
        }

        private static byte HexToByte(string hex)
        {
            byte tt = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return tt;
        }

        //位反序
        public static void BitsReverse(ref BitArray bits)
        {
            BitArray src_bits = new BitArray(bits);
            int i = 0 ;
            foreach (bool bit in src_bits)
            {
                i++;
                bits[bits.Length - i] = bit;
            }
        }

        //每个per_bits反序
        public static void BitsReverse(ref BitArray bits,int per_bits)
        {
            BitArray src_bits = new BitArray(bits);
            int i = 0,group=1;
            if (per_bits == 0)
                return;
            foreach (bool bit in src_bits)
            {
                if (i >= per_bits)
                {
                    i = 0;
                    group++;
                }
                i++;
                bits[group* per_bits - i] = bit;
            }
        }

        //字节反序
        public static void BytesReverse(ref byte[] bytes)
        {
            Byte[] src_bytes = new Byte[bytes.Length];
            Array.Copy(bytes, src_bytes, bytes.Length);
            int i = 0;
            foreach (byte b in src_bytes)
            {
                i++;
                bytes[bytes.Length - i] = b;
            }
        }
        public static byte[] BitsLsbToBytes(BitArray bits)
        {
            int i = 0,j=0;
            byte by = 0;
            Byte[] data= new Byte[(bits.Length+7)/8];
            foreach(bool bit in bits)
            {
                if (bit)
                    by |= (byte)(1<<i);
                i++;
                if (i >= 8)
                {
                    data[j++] = by;
                    by = 0;
                    i = 0;
                }
            }
            if(i!=0)
                data[j++] = by;
            return data;
        }
        public static byte[] BitsMsbToBytes(BitArray bits)
        {
            int i = 0, j = 0;
            byte by = 0;
            Byte[] data = new Byte[(bits.Length + 7) / 8];
            foreach (bool bit in bits)
            {
                    if (bit)
                        by |= (byte)(1 << (7-i));
                i++;
                if (i == 8)
                {
                    data[j++] = by;
                    by = 0;
                    i = 0;
                }
            }
            if (i != 0)
                data[j++] = by;
            return data;
        }
        //前面的为低位，后面的为高位
        public static BitArray BitsToArray(string bitsStr)
        {
            int len = 0;
            foreach (char c in bitsStr.Trim())
            {
                if (c == '1' || c == '0')
                    len++;
            }
            BitArray bits = new BitArray((len * 8 + 7) / 8, false);//保证8的倍数
            len = 0;
            foreach (char c in bitsStr.Trim())
            {
                if (c == '1')
                    bits[len++] = true;
                else if (c == '0')
                    bits[len++] = false;
            }
            return bits;
        }
        /// <summary>
        /// 每字节低位在前
        /// </summary>
        /// <param name="bitsStr"></param>
        /// <returns></returns>
        public static byte[] BitsLsbToBytes(string bitsStr)
        {
            BitArray bits = BitsToArray(bitsStr);
            return BitsLsbToBytes(bits);
        }
        /// <summary>
        /// 每字节高位在前
        /// </summary>
        /// <param name="bitsStr"></param>
        /// <returns></returns>
        public static byte[] BitsMsbToBytes(string bitsStr)
        {
            BitArray bits = BitsToArray(bitsStr);
            return BitsMsbToBytes(bits);
        }


        public static string BytesToBitsStringLsb(byte[] data)
        {
            return BytesToBitsLsbString(data, "");
        }
        public static string BytesToBitsLsbString(byte[] data,string gap)
        {
            int i=0;
            BitArray bits = new BitArray(data);
            StringBuilder str=new StringBuilder();
            foreach (bool bit in bits)
            {
                if ((i == 8) && (gap.Length > 0))
                {
                    str.Append(gap);
                    i = 0;
                }
                if (bit)
                    str.Append('1');
                else
                    str.Append('0');
                i++;
            }
            return str.ToString();
        }
        public static string BytesToBitsMsbString(byte[] data, string gap)
        {
            int i = 0;
            BitArray bits = new BitArray(data);//LSB first
            BitsReverse(ref bits, 8);
            StringBuilder str = new StringBuilder();
            foreach (bool bit in bits)
            {
                if ((i == 8) && (gap.Length > 0))
                {
                    str.Append(gap);
                    i = 0;
                }
                if (bit)
                    str.Append('1');
                else
                    str.Append('0');
                i++;
            }
            return str.ToString();
        }

        public static byte[] HdlcEncode(byte[] data)
        {
            byte[] src_data = new byte[data.Length + 2];
            byte[] new_data = new byte[data.Length+4];
            int length = 1;
            UInt16 crc_val = HdlcFcs16(data);
            Array.Copy(data, src_data, data.Length);
            new_data[0] = 0x7e;
            src_data[data.Length] = (byte)(crc_val & 0xff);
            src_data[data.Length+1] = (byte)((crc_val >> 8) & 0xff);
            foreach (byte b in src_data)
            {
                if (b == 0x7e)
                {
                    Array.Resize(ref new_data, new_data.Length + 1);
                    new_data[length++] = 0x7d;
                    new_data[length++] = 0x5e;
                 }
                else if(b==0x7d)
                {
                    Array.Resize(ref new_data, new_data.Length + 1);
                    new_data[length++] = 0x7d;
                    new_data[length++] = 0x5d;
                }
                else
                    new_data[length++] = b;

            }
            new_data[length++] = 0x7e;
            return new_data;
        }
        public static byte[] HdlcDecode(byte[] data)
        {
            bool trans_parency = false; ;
            if (data.Length < 6)
                return null;
            if (data[0] != 0x7e || data[data.Length - 1] != 0x7e)
                return null;

            byte[] src_data = new byte[data.Length - 2];
            Array.Copy(data, 1, src_data, 0, data.Length - 2);
            byte[] new_data = new byte[data.Length -2];
            int length =0;
            foreach (byte b in src_data)
            {
                if (b == 0x7d)
                    trans_parency = true;
                else if(b==0x5d && trans_parency==true)
                {
                    new_data[length++] = 0x7d;
                    trans_parency = false;
                }else if(b == 0x5e && trans_parency == true)
                {
                    new_data[length++] = 0x7e;
                    trans_parency = false;
                }else
                {
                    new_data[length++] = b;
                }
            }
            UInt16 crc_val = HdlcFcs16(new_data, length - 2);
            if (crc_val != new_data[length - 1] * 256 + new_data[length - 2])
                return null;
            return  new_data.Take(length).ToArray();
        }

        public static BitArray HdlcInsertZeroEncode(byte[] data)
        {
            int length=0,contiued_count=0,i;
            if (data.Length == 0)
                return null;
            byte[] new_data= new byte[data.Length + 2];
            Array.Copy(data, new_data, data.Length);
            UInt16 crc_val = HdlcFcs16(data);
            new_data[data.Length] = (byte)(crc_val & 0xff);
            new_data[data.Length+1] = (byte)((crc_val >> 8) & 0xff);
            BitArray bits = new BitArray(new_data);
            BitArray temp = new BitArray(bits.Length+ bits.Length/5+1);//假设每5个就要插一个0
            foreach (bool bit in bits)
            {
                temp[length++]=bit;
                if (bit)
                {
                    contiued_count++;
                    if (contiued_count >= 5)
                    {
                        temp[length++] = false;
                        contiued_count = 0;
                    }
                }
                else
                {
                    contiued_count = 0;
                }
            }
            BitArray result = new BitArray(length + 16);//头+尾
            result[0] = false;
            result[7] = false;
            for (i = 1; i < 7; i++)
                result[i] = true;

            for (i = 0; i < length; i++)
                result[i + 8] = temp[i];

            length += 8;
            result[length ] = false;
            result[length + 7] = false;
            for (i = 1; i < 7; i++)
                result[length + i] = true;
            return result;
        }

        public static BitArray HdlcBitsRemoveZero(BitArray bits)
        {
            int i,length = 0, contiued_count = 0;
            bool last_is_true = false;
            BitArray temp = new BitArray(bits.Length );
            foreach (bool bit in bits)
            {
                if (bit)
                {
                    temp[length++] = bit;
                    if (last_is_true)
                        contiued_count++;
                    if (contiued_count > 5)
                        return null;
                    last_is_true = true;
                }
                else
                {
                    if (contiued_count >= 5)
                    {
                        contiued_count = 0;
                    }else
                    temp[length++] = bit;
                    last_is_true = false;
                    contiued_count = 0;
                }
            }
            BitArray result = new BitArray(length+14);
            result[0] = false;
            result[7] = false;
            for (i = 1; i < 7; i++)
                result[i] = true;

            for (i = 0; i < length; i++)
                result[i+8] = temp[i];
            result[length + 8] = false;
            result[length+15] = false;
            for (i = 1; i < 7; i++)
                result[length + 8+i] = true;
            return result;
        }

    }
}

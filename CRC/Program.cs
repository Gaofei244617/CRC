using System;

namespace CRCTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] dat;
            CRC crc = new CRC();
            while (true)
            {
                Console.Write("请输入数组长度：");
                int n = Convert.ToInt32(Console.ReadLine());
                dat = new byte[n];

                Console.Write("请输入CRC校验数据：");
                string[] strs = Console.ReadLine().Split(' ');

                //转换数据至byte[] dat
                for (int i = 0; i < n; i++)
                {
                    dat[i] = Convert.ToByte(strs[i], 16);
                }

                crc.crcCheck(dat, n);
                Console.WriteLine("CRC校验结果为:");
                Console.WriteLine("LowByte: 0x{0:X}", crc.LowByte);
                Console.WriteLine("HighByte: 0x{0:X}", crc.HighByte);
                Console.Write("---------------------");

                ////输出数据
                //Console.Write("输入的数据是:");
                //for (int i = 0; i < n; i++)
                //{
                //    Console.Write(" ");
                //    Console.Write("0x{0:X}", dat[i]);
                //}

                Console.ReadKey();
                Console.WriteLine("\n");
            }
        }
    }
}

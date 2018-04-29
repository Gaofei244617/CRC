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
                int n;
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("重新输入(请输入大于0的数字)...\n");
                    continue;
                }

                dat = new byte[n];

                Console.WriteLine("请输入CRC校验数据(十六进制，以空格分隔)：");
                string[] strs = Console.ReadLine().Split(' ');
                if (strs.Length != n)
                {
                    Console.WriteLine("输入数据与数组长度不符，请重新输入...\n");
                    continue;
                }

                //转换数据至byte[] dat
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        dat[i] = Convert.ToByte(strs[i], 16);
                    }
                } catch(Exception)
                {
                    Console.WriteLine("输入的校验数据必须是十六进制数字...\n");
                    continue;
                }

                crc.crcCheck(dat, n);
                Console.WriteLine("CRC校验结果为:");
                Console.WriteLine("LowByte: 0x{0:X}", crc.LowByte);
                Console.WriteLine("HighByte: 0x{0:X}", crc.HighByte);
                Console.Write("-----------------------------------------");

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

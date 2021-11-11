using Jupiter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameBotProject
{
    public partial class Form1 : Form
    {
        static Socket soket1 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket2 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket3 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket4 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket5 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket6 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket7 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket8 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket9 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket10 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket11 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket12 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket13 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket14 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket15 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket16 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket17 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static Socket soket18 = new Socket
           (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        MemoryModule memoryModule1,memoryModule2, memoryModule3, memoryModule4, memoryModule5, memoryModule6, memoryModule7, memoryModule8, memoryModule9, memoryModule10, memoryModule11, memoryModule12, memoryModule13, memoryModule14, memoryModule15, memoryModule16, memoryModule17, memoryModule18;
        IntPtr cordAddr1, mapAddr1, hpAddr1, resAddr1,r1;
        IntPtr cordAddr2, mapAddr2, hpAddr2, resAddr2,r2;
        IntPtr cordAddr3, mapAddr3, hpAddr3, resAddr3, r3;
        IntPtr cordAddr4, mapAddr4, hpAddr4, resAddr4, r4;
        IntPtr cordAddr5, mapAddr5, hpAddr5, resAddr5,r5;
        IntPtr cordAddr6, mapAddr6, hpAddr6, resAddr6,r6;
        IntPtr cordAddr7, mapAddr7, hpAddr7, resAddr7,r7;
        IntPtr cordAddr8, mapAddr8, hpAddr8, resAddr8,r8;
        IntPtr cordAddr9, mapAddr9, hpAddr9, resAddr9,r9;
        IntPtr cordAddr10, mapAddr10, hpAddr10, resAddr10,r10;
        IntPtr cordAddr11, mapAddr11, hpAddr11, resAddr11,r11;
        IntPtr cordAddr12, mapAddr12, hpAddr12, resAddr12,r12;
        IntPtr cordAddr13, mapAddr13, hpAddr13, resAddr13, r13;
        IntPtr cordAddr14, mapAddr14, hpAddr14, resAddr14, r14;
        IntPtr cordAddr15, mapAddr15, hpAddr15, resAddr15, r15;
        IntPtr cordAddr16, mapAddr16, hpAddr16, resAddr16, r16;
        IntPtr cordAddr17, mapAddr17, hpAddr17, resAddr17, r17;
        IntPtr cordAddr18, mapAddr18, hpAddr18, resAddr18, r18;

        int time1 = 600;
        int time2 = 600;
        int time3 = 600;
        int time4 = 600;
        int time5 = 600;
        int time6 = 600;
        string[] ip;


        int resDurum = 0;
        string[] mm;


        public Form1()
        {
            InitializeComponent();
        }



        ///////////CONNECT
        private void button1_Click(object sender, EventArgs e)
        {
            memoryModule1 = new MemoryModule(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Connected");
        }


        private void button10_Click(object sender, EventArgs e)
        {
            memoryModule2 = new MemoryModule(Convert.ToInt32(textBox2.Text));
            MessageBox.Show("Connected");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            memoryModule3 = new MemoryModule(Convert.ToInt32(textBox3.Text));
            MessageBox.Show("Connected");
        }


        private void button20_Click(object sender, EventArgs e)
        {
            memoryModule4 = new MemoryModule(Convert.ToInt32(textBox4.Text));
            MessageBox.Show("Connected");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            memoryModule5 = new MemoryModule(Convert.ToInt32(textBox5.Text));
            MessageBox.Show("Connected");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            memoryModule6 = new MemoryModule(Convert.ToInt32(textBox6.Text));
            MessageBox.Show("Connected");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            memoryModule7 = new MemoryModule(Convert.ToInt32(textBox17.Text));
            MessageBox.Show("Connected");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            memoryModule8 = new MemoryModule(Convert.ToInt32(textBox18.Text));
            MessageBox.Show("Connected");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            memoryModule9 = new MemoryModule(Convert.ToInt32(textBox19.Text));
            MessageBox.Show("Connected");
        }


        private void button66_Click(object sender, EventArgs e)
        {
            memoryModule10 = new MemoryModule(Convert.ToInt32(textBox20.Text));
            MessageBox.Show("Connected");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            memoryModule11 = new MemoryModule(Convert.ToInt32(textBox21.Text));
            MessageBox.Show("Connected");
        }

        private void button78_Click(object sender, EventArgs e)
        {
            memoryModule12= new MemoryModule(Convert.ToInt32(textBox22.Text));
            MessageBox.Show("Connected");
        }

        private void button130_Click(object sender, EventArgs e)
        {
            memoryModule13 = new MemoryModule(Convert.ToInt32(textBox27.Text));
            MessageBox.Show("Connected");
        }

        private void button134_Click(object sender, EventArgs e)
        {
            memoryModule14 = new MemoryModule(Convert.ToInt32(textBox28.Text));
            MessageBox.Show("Connected");
        }

        private void button138_Click(object sender, EventArgs e)
        {
            memoryModule15 = new MemoryModule(Convert.ToInt32(textBox26.Text));
            MessageBox.Show("Connected");
        }

        private void button112_Click(object sender, EventArgs e)
        {
            memoryModule16 = new MemoryModule(Convert.ToInt32(textBox24.Text));
            MessageBox.Show("Connected");
        }

        private void button116_Click(object sender, EventArgs e)
        {
            memoryModule17 = new MemoryModule(Convert.ToInt32(textBox25.Text));
            MessageBox.Show("Connected");
        }

        private void button120_Click(object sender, EventArgs e)
        {
            memoryModule18 = new MemoryModule(Convert.ToInt32(textBox23.Text));
            MessageBox.Show("Connected");
        }

        //////////////////


        //////READ

        private void button2_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\1.txt");
            cordAddr1 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr1 = cordAddr1- 0xE0 + 0x110;
            resAddr1 = cordAddr1 - 0xE0 + 0xD8;
            mapAddr1 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r1 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString()+ "\n" + pattern[2].ToString());
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\2.txt");
            cordAddr2 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr2 = cordAddr2 - 0xE0 + 0x110;
            resAddr2 = cordAddr2 - 0xE0 + 0xD8;
            mapAddr2 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r2 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\3.txt");
            cordAddr3 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr3 = cordAddr3 - 0xE0 + 0x110;
            resAddr3 = cordAddr3 - 0xE0 + 0xD8;
            mapAddr3 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r3 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        

        private void button19_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\4.txt");
            cordAddr4 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr4 = cordAddr4 - 0xE0 + 0x110;
            resAddr4 = cordAddr4 - 0xE0 + 0xD8;
            mapAddr4 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r4 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\5.txt");
            cordAddr5 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr5 = cordAddr5 - 0xE0 + 0x110;
            resAddr5 = cordAddr5 - 0xE0 + 0xD8;
            mapAddr5 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r5 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\6.txt");
            cordAddr6 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr6 = cordAddr6 - 0xE0 + 0x110;
            resAddr6 = cordAddr6 - 0xE0 + 0xD8;
            mapAddr6 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r6 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }


        private void button47_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\7.txt");
            cordAddr7 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr7 = cordAddr7 - 0xE0 + 0x110;
            resAddr7 = cordAddr7 - 0xE0 + 0xD8;
            mapAddr7 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r7 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button53_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\8.txt");
            cordAddr8 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr8 = cordAddr8 - 0xE0 + 0x110;
            resAddr8 = cordAddr8 - 0xE0 + 0xD8;
            mapAddr8 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r8 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button59_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\9.txt");
            cordAddr9 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr9 = cordAddr9 - 0xE0 + 0x110;
            resAddr9 = cordAddr9 - 0xE0 + 0xD8;
            mapAddr9 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r9 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button65_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\10.txt");
            cordAddr10 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr10 = cordAddr10 - 0xE0 + 0x110;
            resAddr10 = cordAddr10 - 0xE0 + 0xD8;
            mapAddr10 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r10 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button71_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\11.txt");
            cordAddr11 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr11 = cordAddr11 - 0xE0 + 0x110;
            resAddr11 = cordAddr11 - 0xE0 + 0xD8;
            mapAddr11 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r11 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button77_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\12.txt");
            cordAddr12 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr12 = cordAddr12 - 0xE0 + 0x110;
            resAddr12 = cordAddr12 - 0xE0 + 0xD8;
            mapAddr12 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r12 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button131_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\13.txt");
            cordAddr13 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr13 = cordAddr13 - 0xE0 + 0x110;
            resAddr13 = cordAddr13 - 0xE0 + 0xD8;
            mapAddr13 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r13 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button135_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\14.txt");
            cordAddr14 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr14 = cordAddr14 - 0xE0 + 0x110;
            resAddr14 = cordAddr14 - 0xE0 + 0xD8;
            mapAddr14 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r14 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button139_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\15.txt");
            cordAddr15 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr15 = cordAddr15 - 0xE0 + 0x110;
            resAddr15 = cordAddr15 - 0xE0 + 0xD8;
            mapAddr15 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r15 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button113_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\16.txt");
            cordAddr16 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr16 = cordAddr16 - 0xE0 + 0x110;
            resAddr16 = cordAddr16 - 0xE0 + 0xD8;
            mapAddr16 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r16 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button117_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\17.txt");
            cordAddr17 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr17 = cordAddr17 - 0xE0 + 0x110;
            resAddr17 = cordAddr17 - 0xE0 + 0xD8;
            mapAddr17 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r17 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        private void button121_Click(object sender, EventArgs e)
        {
            string[] pattern = System.IO.File.ReadAllLines(@"..\\Debug\18.txt");
            cordAddr18 = (IntPtr)Convert.ToInt64(pattern[0], 16) + 0xE0;
            hpAddr18 = cordAddr18 - 0xE0 + 0x110;
            resAddr18 = cordAddr18 - 0xE0 + 0xD8;
            mapAddr18 = (IntPtr)Convert.ToInt64(pattern[1], 16) - 0x24C;
            r18 = (IntPtr)Convert.ToInt64(pattern[2], 16);
            MessageBox.Show(pattern[0].ToString() + "\n" + pattern[1].ToString() + "\n" + pattern[2].ToString());
        }

        ////////


        /////Tel

        private void button36_Click(object sender, EventArgs e)
        {
            memoryModule1.WriteVirtualMemory<float>(cordAddr1, (float)Convert.ToDouble(textBox13.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button37_Click(object sender, EventArgs e)
        {
            memoryModule2.WriteVirtualMemory<float>(cordAddr2, (float)Convert.ToDouble(textBox13.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button38_Click(object sender, EventArgs e)
        {
            memoryModule3.WriteVirtualMemory<float>(cordAddr3, (float)Convert.ToDouble(textBox13.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button39_Click(object sender, EventArgs e)
        {
            memoryModule4.WriteVirtualMemory<float>(cordAddr4, (float)Convert.ToDouble(textBox13.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button40_Click(object sender, EventArgs e)
        {
            memoryModule5.WriteVirtualMemory<float>(cordAddr5, (float)Convert.ToDouble(textBox13.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x4, (float)Convert.ToDouble(textBox11.Text));

        }

        private void button41_Click(object sender, EventArgs e)
        {
            memoryModule6.WriteVirtualMemory<float>(cordAddr6, (float)Convert.ToDouble(textBox13.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button43_Click(object sender, EventArgs e)
        {
            memoryModule7.WriteVirtualMemory<float>(cordAddr7, (float)Convert.ToDouble(textBox13.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button49_Click(object sender, EventArgs e)
        {
            memoryModule8.WriteVirtualMemory<float>(cordAddr8, (float)Convert.ToDouble(textBox13.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button55_Click(object sender, EventArgs e)
        {
            memoryModule9.WriteVirtualMemory<float>(cordAddr9, (float)Convert.ToDouble(textBox13.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button61_Click(object sender, EventArgs e)
        {
            memoryModule10.WriteVirtualMemory<float>(cordAddr10, (float)Convert.ToDouble(textBox13.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }



        private void button67_Click(object sender, EventArgs e)
        {
            memoryModule11.WriteVirtualMemory<float>(cordAddr11, (float)Convert.ToDouble(textBox13.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }


        private void button73_Click(object sender, EventArgs e)
        {
            memoryModule12.WriteVirtualMemory<float>(cordAddr12, (float)Convert.ToDouble(textBox13.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button145_Click(object sender, EventArgs e)
        {
            memoryModule13.WriteVirtualMemory<float>(cordAddr13, (float)Convert.ToDouble(textBox13.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button146_Click(object sender, EventArgs e)
        {
            memoryModule14.WriteVirtualMemory<float>(cordAddr14, (float)Convert.ToDouble(textBox13.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button147_Click(object sender, EventArgs e)
        {
            memoryModule15.WriteVirtualMemory<float>(cordAddr15, (float)Convert.ToDouble(textBox13.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button127_Click(object sender, EventArgs e)
        {
            memoryModule16.WriteVirtualMemory<float>(cordAddr16, (float)Convert.ToDouble(textBox13.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button128_Click(object sender, EventArgs e)
        {
            memoryModule17.WriteVirtualMemory<float>(cordAddr17, (float)Convert.ToDouble(textBox13.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button129_Click(object sender, EventArgs e)
        {
            memoryModule18.WriteVirtualMemory<float>(cordAddr18, (float)Convert.ToDouble(textBox13.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        ///
        private void button3_Click(object sender, EventArgs e)
        {
            memoryModule1.WriteVirtualMemory<int>(mapAddr1, Convert.ToInt32(textBox7.Text));

            memoryModule1.WriteVirtualMemory<float>(cordAddr1, (float)Convert.ToDouble(textBox8.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            memoryModule2.WriteVirtualMemory<int>(mapAddr2, Convert.ToInt32(textBox7.Text));

            memoryModule2.WriteVirtualMemory<float>(cordAddr2, (float)Convert.ToDouble(textBox8.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            memoryModule3.WriteVirtualMemory<int>(mapAddr3, Convert.ToInt32(textBox7.Text));

            memoryModule3.WriteVirtualMemory<float>(cordAddr3, (float)Convert.ToDouble(textBox8.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            memoryModule4.WriteVirtualMemory<int>(mapAddr4, Convert.ToInt32(textBox7.Text));

            memoryModule4.WriteVirtualMemory<float>(cordAddr4, (float)Convert.ToDouble(textBox8.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }
  
        private void button23_Click(object sender, EventArgs e)
        {
            memoryModule5.WriteVirtualMemory<int>(mapAddr5, Convert.ToInt32(textBox7.Text));

            memoryModule5.WriteVirtualMemory<float>(cordAddr5, (float)Convert.ToDouble(textBox8.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            memoryModule6.WriteVirtualMemory<int>(mapAddr6, Convert.ToInt32(textBox7.Text));

            memoryModule6.WriteVirtualMemory<float>(cordAddr6, (float)Convert.ToDouble(textBox8.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button46_Click(object sender, EventArgs e)
        {
            memoryModule7.WriteVirtualMemory<int>(mapAddr7, Convert.ToInt32(textBox7.Text));

            memoryModule7.WriteVirtualMemory<float>(cordAddr7, (float)Convert.ToDouble(textBox8.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button52_Click(object sender, EventArgs e)
        {
            memoryModule8.WriteVirtualMemory<int>(mapAddr8, Convert.ToInt32(textBox7.Text));

            memoryModule8.WriteVirtualMemory<float>(cordAddr8, (float)Convert.ToDouble(textBox8.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button58_Click(object sender, EventArgs e)
        {
            memoryModule9.WriteVirtualMemory<int>(mapAddr9, Convert.ToInt32(textBox7.Text));

            memoryModule9.WriteVirtualMemory<float>(cordAddr9, (float)Convert.ToDouble(textBox8.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button64_Click(object sender, EventArgs e)
        {
            memoryModule10.WriteVirtualMemory<int>(mapAddr10, Convert.ToInt32(textBox7.Text));

            memoryModule10.WriteVirtualMemory<float>(cordAddr10, (float)Convert.ToDouble(textBox8.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button70_Click(object sender, EventArgs e)
        {
            memoryModule11.WriteVirtualMemory<int>(mapAddr11, Convert.ToInt32(textBox7.Text));

            memoryModule11.WriteVirtualMemory<float>(cordAddr11, (float)Convert.ToDouble(textBox8.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button76_Click(object sender, EventArgs e)
        {
            memoryModule12.WriteVirtualMemory<int>(mapAddr12, Convert.ToInt32(textBox7.Text));

            memoryModule12.WriteVirtualMemory<float>(cordAddr12, (float)Convert.ToDouble(textBox8.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }
        private void button132_Click(object sender, EventArgs e)
        {
            memoryModule13.WriteVirtualMemory<int>(mapAddr13, Convert.ToInt32(textBox7.Text));

            memoryModule13.WriteVirtualMemory<float>(cordAddr13, (float)Convert.ToDouble(textBox8.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button136_Click(object sender, EventArgs e)
        {
            memoryModule14.WriteVirtualMemory<int>(mapAddr14, Convert.ToInt32(textBox7.Text));

            memoryModule14.WriteVirtualMemory<float>(cordAddr14, (float)Convert.ToDouble(textBox8.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button140_Click(object sender, EventArgs e)
        {
            memoryModule15.WriteVirtualMemory<int>(mapAddr15, Convert.ToInt32(textBox7.Text));

            memoryModule15.WriteVirtualMemory<float>(cordAddr15, (float)Convert.ToDouble(textBox8.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button114_Click(object sender, EventArgs e)
        {
            memoryModule16.WriteVirtualMemory<int>(mapAddr16, Convert.ToInt32(textBox7.Text));

            memoryModule16.WriteVirtualMemory<float>(cordAddr16, (float)Convert.ToDouble(textBox8.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button118_Click(object sender, EventArgs e)
        {
            memoryModule17.WriteVirtualMemory<int>(mapAddr17, Convert.ToInt32(textBox7.Text));

            memoryModule17.WriteVirtualMemory<float>(cordAddr17, (float)Convert.ToDouble(textBox8.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }

        private void button122_Click(object sender, EventArgs e)
        {
            memoryModule18.WriteVirtualMemory<int>(mapAddr18, Convert.ToInt32(textBox7.Text));

            memoryModule18.WriteVirtualMemory<float>(cordAddr18, (float)Convert.ToDouble(textBox8.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x8, (float)Convert.ToDouble(textBox9.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x4, (float)Convert.ToDouble(textBox10.Text));
        }
        //////

        private void button79_Click(object sender, EventArgs e)
        {
            time1 = 600;
            timer1.Stop();
            timer1.Start();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            time2 = 600;
            timer2.Stop();
            timer2.Start();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            time3 = 600;
            timer3.Stop();
            timer3.Start();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            time4 = 600;
            timer4.Stop();
            timer4.Start();
        }

        private void button111_Click(object sender, EventArgs e)
        {
            time5 = 600;
            timer5.Stop();
            timer5.Start();
        }

        private void button110_Click(object sender, EventArgs e)
        {
            time6 = 600;
            timer6.Stop();
            timer6.Start();
        }

        ///H
        private void button4_Click(object sender, EventArgs e)
        {
            memoryModule1.WriteVirtualMemory<int>(resAddr1, 1);
        }

       
        private void button7_Click(object sender, EventArgs e)
        {
            memoryModule2.WriteVirtualMemory<int>(resAddr2, 1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            memoryModule3.WriteVirtualMemory<int>(resAddr3, 1);
        }



        private void button17_Click(object sender, EventArgs e)
        {
            memoryModule4.WriteVirtualMemory<int>(resAddr4, 1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            memoryModule5.WriteVirtualMemory<int>(resAddr5, 1);
        }


        private void button27_Click(object sender, EventArgs e)
        {
            memoryModule6.WriteVirtualMemory<int>(resAddr6, 1);
        }



        private void button45_Click(object sender, EventArgs e)
        {
            memoryModule7.WriteVirtualMemory<int>(resAddr7, 1);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            memoryModule8.WriteVirtualMemory<int>(resAddr8, 1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                 
                
                memoryModule1.WriteVirtualMemory<int>(r1 + 0x8, Convert.ToInt32(mm[0]));
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                memoryModule2.WriteVirtualMemory<int>(r2 + 0x8, Convert.ToInt32(mm[1]));
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                memoryModule3.WriteVirtualMemory<int>(r3 + 0x8, Convert.ToInt32(mm[2]));
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                memoryModule4.WriteVirtualMemory<int>(r4 + 0x8, Convert.ToInt32(mm[3]));
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                memoryModule5.WriteVirtualMemory<int>(r5 + 0x8, Convert.ToInt32(mm[4]));
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                memoryModule6.WriteVirtualMemory<int>(r6 + 0x8, Convert.ToInt32(mm[5]));
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                memoryModule7.WriteVirtualMemory<int>(r7 + 0x8, Convert.ToInt32(mm[6]));
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                memoryModule8.WriteVirtualMemory<int>(r8 + 0x8, Convert.ToInt32(mm[7]));
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                memoryModule9.WriteVirtualMemory<int>(r9 + 0x8, Convert.ToInt32(mm[8]));
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                memoryModule10.WriteVirtualMemory<int>(r10 + 0x8, Convert.ToInt32(mm[9]));
            }
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                memoryModule11.WriteVirtualMemory<int>(r11 + 0x8, Convert.ToInt32(mm[10]));
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                memoryModule12.WriteVirtualMemory<int>(r12 + 0x8, Convert.ToInt32(mm[11]));
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                memoryModule13.WriteVirtualMemory<int>(r13 + 0x8, Convert.ToInt32(mm[12]));
            }
        }


        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                memoryModule14.WriteVirtualMemory<int>(r14 + 0x8, Convert.ToInt32(mm[13]));
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                memoryModule15.WriteVirtualMemory<int>(r15 + 0x8, Convert.ToInt32(mm[14]));
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                memoryModule16.WriteVirtualMemory<int>(r16 + 0x8, Convert.ToInt32(mm[15]));
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                memoryModule17.WriteVirtualMemory<int>(r17 + 0x8, Convert.ToInt32(mm[16]));
            }

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                memoryModule18.WriteVirtualMemory<int>(r18 + 0x8, Convert.ToInt32(mm[17]));
            }
        }



        private void button167_Click(object sender, EventArgs e)
        {
            mm = System.IO.File.ReadAllLines(@"..\\Debug\X1.txt");
        }

        private void button168_Click(object sender, EventArgs e)
        {
            
        }



        /// 
        /// /////


        private void button57_Click(object sender, EventArgs e)
        {
            memoryModule9.WriteVirtualMemory<int>(resAddr9, 1);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            memoryModule10.WriteVirtualMemory<int>(resAddr10, 1);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            memoryModule11.WriteVirtualMemory<int>(resAddr11, 1);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            memoryModule12.WriteVirtualMemory<int>(resAddr12, 1);
        }
        private void button133_Click(object sender, EventArgs e)
        {
            memoryModule13.WriteVirtualMemory<int>(resAddr13, 1);
        }

        private void button137_Click(object sender, EventArgs e)
        {
            memoryModule14.WriteVirtualMemory<int>(resAddr14, 1);
        }

        private void button141_Click(object sender, EventArgs e)
        {
            memoryModule15.WriteVirtualMemory<int>(resAddr15, 1);
        }

        private void button115_Click(object sender, EventArgs e)
        {
            memoryModule16.WriteVirtualMemory<int>(resAddr16, 1);
        }

        private void button119_Click(object sender, EventArgs e)
        {
            memoryModule17.WriteVirtualMemory<int>(resAddr17, 1);
        }

        private void button123_Click(object sender, EventArgs e)
        {
            memoryModule18.WriteVirtualMemory<int>(resAddr18, 1);
        }
        ///
        private void button109_Click(object sender, EventArgs e)
        {
            memoryModule1.WriteVirtualMemory<int>(r1 + 0xC, 0);
            memoryModule2.WriteVirtualMemory<int>(r2 + 0xC, 0);
            memoryModule3.WriteVirtualMemory<int>(r3 + 0xC, 0);
            memoryModule4.WriteVirtualMemory<int>(r4 + 0xC, 0);
            memoryModule5.WriteVirtualMemory<int>(r5 + 0xC, 0);
            memoryModule6.WriteVirtualMemory<int>(r6 + 0xC, 0);
            memoryModule7.WriteVirtualMemory<int>(r7 + 0xC, 0);
            memoryModule8.WriteVirtualMemory<int>(r8 + 0xC, 0);
            memoryModule9.WriteVirtualMemory<int>(r9 + 0xC, 0);
            memoryModule10.WriteVirtualMemory<int>(r10 + 0xC, 0);
            memoryModule11.WriteVirtualMemory<int>(r11 + 0xC, 0);
            memoryModule12.WriteVirtualMemory<int>(r12 + 0xC, 0);
            memoryModule13.WriteVirtualMemory<int>(r13 + 0xC, 0);
            memoryModule14.WriteVirtualMemory<int>(r14 + 0xC, 0);
            memoryModule15.WriteVirtualMemory<int>(r15 + 0xC, 0);
            memoryModule16.WriteVirtualMemory<int>(r16 + 0xC, 0);
            memoryModule17.WriteVirtualMemory<int>(r17 + 0xC, 0);
            memoryModule18.WriteVirtualMemory<int>(r18 + 0xC, 0);
        }


        ///A1
        private void button11_Click(object sender, EventArgs e)
        {
            textBox7.Text= memoryModule1.ReadVirtualMemory<int>(mapAddr1).ToString();
            textBox8.Text = memoryModule1.ReadVirtualMemory<float>(cordAddr1).ToString();
            textBox9.Text = memoryModule1.ReadVirtualMemory<float>(cordAddr1 + 0x8).ToString();
            textBox10.Text = memoryModule1.ReadVirtualMemory<float>(cordAddr1 + 0x4).ToString();
        }
        ////
        
        ///A2
        private void button16_Click(object sender, EventArgs e)
        {
            textBox13.Text = memoryModule1.ReadVirtualMemory<float>(cordAddr1).ToString();
            textBox12.Text = memoryModule1.ReadVirtualMemory<float>(cordAddr1 + 0x8).ToString();
            textBox11.Text = memoryModule1.ReadVirtualMemory<float>(cordAddr1 + 0x4).ToString();
        }
        ////A3
        private void button35_Click(object sender, EventArgs e)
        {
            textBox14.Text = memoryModule1.ReadVirtualMemory<float>(cordAddr1).ToString();
            textBox15.Text = memoryModule1.ReadVirtualMemory<float>(cordAddr1 + 0x8).ToString();
            textBox16.Text = memoryModule1.ReadVirtualMemory<float>(cordAddr1 + 0x4).ToString();
        }
        ///T2+S
        private void button5_Click(object sender, EventArgs e)
        {
            //memoryModule1.WriteVirtualMemory<float>(cordAddr1, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule1.WriteVirtualMemory<float>(cordAddr1+ 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule2.WriteVirtualMemory<float>(cordAddr2, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule3.WriteVirtualMemory<float>(cordAddr3, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule4.WriteVirtualMemory<float>(cordAddr4, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule5.WriteVirtualMemory<float>(cordAddr5, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule6.WriteVirtualMemory<float>(cordAddr6, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x4, (float)Convert.ToDouble(textBox11.Text));
            string[] kk = System.IO.File.ReadAllLines(@"..\\Debug\w2.txt");
            textBox14.Text = kk[0];
            textBox15.Text = kk[1];
            textBox16.Text = kk[2];
            textBox13.Text = kk[3];
            textBox12.Text = kk[4];
            textBox11.Text = kk[5];
            textBox7.Text = kk[6];
            textBox8.Text = kk[7];
            textBox9.Text = kk[8];
            textBox10.Text = kk[9];
        }

        private void button164_Click(object sender, EventArgs e)
        {
            string[] kk = System.IO.File.ReadAllLines(@"..\\Debug\w3.txt");
            textBox14.Text = kk[0];
            textBox15.Text = kk[1];
            textBox16.Text = kk[2];
            textBox13.Text = kk[3];
            textBox12.Text = kk[4];
            textBox11.Text = kk[5];
            textBox7.Text = kk[6];
            textBox8.Text = kk[7];
            textBox9.Text = kk[8];
            textBox10.Text = kk[9];
        }

        private  async void button6_Click(object sender, EventArgs e)
        {
            resDurum = 1;
            await Task.WhenAll(res(), hpT());
        }

        private void button42_Click(object sender, EventArgs e)
        {
            resDurum = 0;
        }
        //

        //RTX

        private void button21_Click(object sender, EventArgs e)
        {
            memoryModule1.WriteVirtualMemory<float>(cordAddr1, (float)Convert.ToDouble(textBox14.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button26_Click(object sender, EventArgs e)
        {
            memoryModule2.WriteVirtualMemory<float>(cordAddr2, (float)Convert.ToDouble(textBox14.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button31_Click(object sender, EventArgs e)
        {
            memoryModule3.WriteVirtualMemory<float>(cordAddr3, (float)Convert.ToDouble(textBox14.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button32_Click(object sender, EventArgs e)
        {
            memoryModule4.WriteVirtualMemory<float>(cordAddr4, (float)Convert.ToDouble(textBox14.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button33_Click(object sender, EventArgs e)
        {
            memoryModule5.WriteVirtualMemory<float>(cordAddr5, (float)Convert.ToDouble(textBox14.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button34_Click(object sender, EventArgs e)
        {
            memoryModule6.WriteVirtualMemory<float>(cordAddr6, (float)Convert.ToDouble(textBox14.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button44_Click(object sender, EventArgs e)
        {
            memoryModule7.WriteVirtualMemory<float>(cordAddr7, (float)Convert.ToDouble(textBox14.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button50_Click(object sender, EventArgs e)
        {
            memoryModule8.WriteVirtualMemory<float>(cordAddr8, (float)Convert.ToDouble(textBox14.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button56_Click(object sender, EventArgs e)
        {
            memoryModule9.WriteVirtualMemory<float>(cordAddr9, (float)Convert.ToDouble(textBox14.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button62_Click(object sender, EventArgs e)
        {
            memoryModule10.WriteVirtualMemory<float>(cordAddr10, (float)Convert.ToDouble(textBox14.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button68_Click(object sender, EventArgs e)
        {
            memoryModule11.WriteVirtualMemory<float>(cordAddr11, (float)Convert.ToDouble(textBox14.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button74_Click(object sender, EventArgs e)
        {
            memoryModule12.WriteVirtualMemory<float>(cordAddr12, (float)Convert.ToDouble(textBox14.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x4, (float)Convert.ToDouble(textBox16.Text));

        }

        private void button142_Click(object sender, EventArgs e)
        {
            memoryModule13.WriteVirtualMemory<float>(cordAddr13, (float)Convert.ToDouble(textBox14.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button143_Click(object sender, EventArgs e)
        {
            memoryModule14.WriteVirtualMemory<float>(cordAddr14, (float)Convert.ToDouble(textBox14.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button144_Click(object sender, EventArgs e)
        {
            memoryModule15.WriteVirtualMemory<float>(cordAddr15, (float)Convert.ToDouble(textBox14.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button124_Click(object sender, EventArgs e)
        {
            memoryModule16.WriteVirtualMemory<float>(cordAddr16, (float)Convert.ToDouble(textBox14.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button125_Click(object sender, EventArgs e)
        {
            memoryModule17.WriteVirtualMemory<float>(cordAddr17, (float)Convert.ToDouble(textBox14.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button126_Click(object sender, EventArgs e)
        {
            memoryModule18.WriteVirtualMemory<float>(cordAddr18, (float)Convert.ToDouble(textBox14.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }



        private void button160_Click(object sender, EventArgs e)
        {
            //TOPLU1
            memoryModule1.WriteVirtualMemory<float>(cordAddr1, (float)Convert.ToDouble(textBox14.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule2.WriteVirtualMemory<float>(cordAddr2, (float)Convert.ToDouble(textBox14.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule3.WriteVirtualMemory<float>(cordAddr3, (float)Convert.ToDouble(textBox14.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule4.WriteVirtualMemory<float>(cordAddr4, (float)Convert.ToDouble(textBox14.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule5.WriteVirtualMemory<float>(cordAddr5, (float)Convert.ToDouble(textBox14.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule6.WriteVirtualMemory<float>(cordAddr6, (float)Convert.ToDouble(textBox14.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            //memoryModule7.WriteVirtualMemory<float>(cordAddr7, (float)Convert.ToDouble(textBox14.Text));
            //memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            //memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            //memoryModule8.WriteVirtualMemory<float>(cordAddr8, (float)Convert.ToDouble(textBox14.Text));
            //memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            //memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            //memoryModule9.WriteVirtualMemory<float>(cordAddr9, (float)Convert.ToDouble(textBox14.Text));
            //memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            //memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button162_Click(object sender, EventArgs e)
        {
            //memoryModule10.WriteVirtualMemory<float>(cordAddr10, (float)Convert.ToDouble(textBox14.Text));
            //memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            //memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            //memoryModule11.WriteVirtualMemory<float>(cordAddr11, (float)Convert.ToDouble(textBox14.Text));
            //memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            //memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            //memoryModule12.WriteVirtualMemory<float>(cordAddr12, (float)Convert.ToDouble(textBox14.Text));
            //memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            //memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule13.WriteVirtualMemory<float>(cordAddr13, (float)Convert.ToDouble(textBox14.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule14.WriteVirtualMemory<float>(cordAddr14, (float)Convert.ToDouble(textBox14.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule15.WriteVirtualMemory<float>(cordAddr15, (float)Convert.ToDouble(textBox14.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule16.WriteVirtualMemory<float>(cordAddr16, (float)Convert.ToDouble(textBox14.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule17.WriteVirtualMemory<float>(cordAddr17, (float)Convert.ToDouble(textBox14.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule18.WriteVirtualMemory<float>(cordAddr18, (float)Convert.ToDouble(textBox14.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button161_Click(object sender, EventArgs e)
        {
            memoryModule1.WriteVirtualMemory<float>(cordAddr1, (float)Convert.ToDouble(textBox13.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule1.WriteVirtualMemory<float>(cordAddr1 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule2.WriteVirtualMemory<float>(cordAddr2, (float)Convert.ToDouble(textBox13.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule2.WriteVirtualMemory<float>(cordAddr2 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule3.WriteVirtualMemory<float>(cordAddr3, (float)Convert.ToDouble(textBox13.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule3.WriteVirtualMemory<float>(cordAddr3 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule4.WriteVirtualMemory<float>(cordAddr4, (float)Convert.ToDouble(textBox13.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule4.WriteVirtualMemory<float>(cordAddr4 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule5.WriteVirtualMemory<float>(cordAddr5, (float)Convert.ToDouble(textBox13.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule5.WriteVirtualMemory<float>(cordAddr5 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule6.WriteVirtualMemory<float>(cordAddr6, (float)Convert.ToDouble(textBox13.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule6.WriteVirtualMemory<float>(cordAddr6 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule7.WriteVirtualMemory<float>(cordAddr7, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule8.WriteVirtualMemory<float>(cordAddr8, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule9.WriteVirtualMemory<float>(cordAddr9, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }

        private void button163_Click(object sender, EventArgs e)
        {

            //memoryModule10.WriteVirtualMemory<float>(cordAddr10, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule11.WriteVirtualMemory<float>(cordAddr11, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            //memoryModule12.WriteVirtualMemory<float>(cordAddr12, (float)Convert.ToDouble(textBox13.Text));
            //memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            //memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule13.WriteVirtualMemory<float>(cordAddr13, (float)Convert.ToDouble(textBox13.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule13.WriteVirtualMemory<float>(cordAddr13 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule14.WriteVirtualMemory<float>(cordAddr14, (float)Convert.ToDouble(textBox13.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule14.WriteVirtualMemory<float>(cordAddr14 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule15.WriteVirtualMemory<float>(cordAddr15, (float)Convert.ToDouble(textBox13.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule15.WriteVirtualMemory<float>(cordAddr15 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule16.WriteVirtualMemory<float>(cordAddr16, (float)Convert.ToDouble(textBox13.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule16.WriteVirtualMemory<float>(cordAddr16 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule17.WriteVirtualMemory<float>(cordAddr17, (float)Convert.ToDouble(textBox13.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule17.WriteVirtualMemory<float>(cordAddr17 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule18.WriteVirtualMemory<float>(cordAddr18, (float)Convert.ToDouble(textBox13.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule18.WriteVirtualMemory<float>(cordAddr18 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }


        private void button165_Click(object sender, EventArgs e)
        {
            memoryModule7.WriteVirtualMemory<float>(cordAddr7, (float)Convert.ToDouble(textBox14.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule8.WriteVirtualMemory<float>(cordAddr8, (float)Convert.ToDouble(textBox14.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule9.WriteVirtualMemory<float>(cordAddr9, (float)Convert.ToDouble(textBox14.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule10.WriteVirtualMemory<float>(cordAddr10, (float)Convert.ToDouble(textBox14.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule11.WriteVirtualMemory<float>(cordAddr11, (float)Convert.ToDouble(textBox14.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x4, (float)Convert.ToDouble(textBox16.Text));

            memoryModule12.WriteVirtualMemory<float>(cordAddr12, (float)Convert.ToDouble(textBox14.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x8, (float)Convert.ToDouble(textBox15.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x4, (float)Convert.ToDouble(textBox16.Text));
        }

        private void button166_Click(object sender, EventArgs e)
        {
            memoryModule7.WriteVirtualMemory<float>(cordAddr7, (float)Convert.ToDouble(textBox13.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule7.WriteVirtualMemory<float>(cordAddr7 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule8.WriteVirtualMemory<float>(cordAddr8, (float)Convert.ToDouble(textBox13.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule8.WriteVirtualMemory<float>(cordAddr8 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule9.WriteVirtualMemory<float>(cordAddr9, (float)Convert.ToDouble(textBox13.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule9.WriteVirtualMemory<float>(cordAddr9 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule10.WriteVirtualMemory<float>(cordAddr10, (float)Convert.ToDouble(textBox13.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule10.WriteVirtualMemory<float>(cordAddr10 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule11.WriteVirtualMemory<float>(cordAddr11, (float)Convert.ToDouble(textBox13.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule11.WriteVirtualMemory<float>(cordAddr11 + 0x4, (float)Convert.ToDouble(textBox11.Text));

            memoryModule12.WriteVirtualMemory<float>(cordAddr12, (float)Convert.ToDouble(textBox13.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x8, (float)Convert.ToDouble(textBox12.Text));
            memoryModule12.WriteVirtualMemory<float>(cordAddr12 + 0x4, (float)Convert.ToDouble(textBox11.Text));
        }
        //TOPLU


        ///////SOKET
        private void button83_Click(object sender, EventArgs e)
        {
            try
            {
                
                soket1.Connect(new IPEndPoint(IPAddress.Parse(ip[0]), 12345));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            try
            {
                soket2.Connect(new IPEndPoint(IPAddress.Parse(ip[1]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            try
            {
                soket3.Connect(new IPEndPoint(IPAddress.Parse(ip[2]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            try
            {
                soket4.Connect(new IPEndPoint(IPAddress.Parse(ip[3]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            try
            {
                soket5.Connect(new IPEndPoint(IPAddress.Parse(ip[4]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            try
            {
                soket6.Connect(new IPEndPoint(IPAddress.Parse(ip[5]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            try
            {
                soket7.Connect(new IPEndPoint(IPAddress.Parse(ip[6]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            try
            {
                soket8.Connect(new IPEndPoint(IPAddress.Parse(ip[7]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            try
            {
                soket9.Connect(new IPEndPoint(IPAddress.Parse(ip[8]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            try
            {
                soket10.Connect(new IPEndPoint(IPAddress.Parse(ip[9]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            try
            {
                soket11.Connect(new IPEndPoint(IPAddress.Parse(ip[10]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            try
            {
                soket12.Connect(new IPEndPoint(IPAddress.Parse(ip[11]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button159_Click(object sender, EventArgs e)
        {
            try
            {
                soket13.Connect(new IPEndPoint(IPAddress.Parse(ip[12]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button158_Click(object sender, EventArgs e)
        {
            try
            {
                soket14.Connect(new IPEndPoint(IPAddress.Parse(ip[13]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button157_Click(object sender, EventArgs e)
        {
            try
            {
                soket15.Connect(new IPEndPoint(IPAddress.Parse(ip[14]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button156_Click(object sender, EventArgs e)
        {
            try
            {
                soket16.Connect(new IPEndPoint(IPAddress.Parse(ip[15]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button155_Click(object sender, EventArgs e)
        {
            try
            {
                soket17.Connect(new IPEndPoint(IPAddress.Parse(ip[16]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button154_Click(object sender, EventArgs e)
        {
            try
            {
                soket18.Connect(new IPEndPoint(IPAddress.Parse(ip[17]), 12345));

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        //

        private void button96_Click(object sender, EventArgs e)
        {

            soket1.Close();
            soket1= new Socket
                    (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button98_Click(object sender, EventArgs e)
        {
            soket2.Close();
            soket2 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button99_Click(object sender, EventArgs e)
        {
            soket3.Close();
            soket3 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            soket4.Close();
            soket4 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button101_Click(object sender, EventArgs e)
        {
            soket5.Close();
            soket5 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button102_Click(object sender, EventArgs e)
        {
            soket6.Close();
            soket6 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button103_Click(object sender, EventArgs e)
        {
            soket7.Close();
            soket7 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button104_Click(object sender, EventArgs e)
        {
            soket8.Close();
            soket8 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button105_Click(object sender, EventArgs e)
        {
            soket9.Close();
            soket9 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button106_Click(object sender, EventArgs e)
        {
            soket10.Close();
            soket10 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button107_Click(object sender, EventArgs e)
        {
            soket11.Close();
            soket11 = new Socket
                     (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button108_Click(object sender, EventArgs e)
        {
            soket12.Close();
            soket12 = new Socket
                      (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button153_Click(object sender, EventArgs e)
        {
            soket13.Close();
            soket13 = new Socket
                      (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button152_Click(object sender, EventArgs e)
        {
            soket14.Close();
            soket14 = new Socket
                      (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button151_Click(object sender, EventArgs e)
        {
            soket15.Close();
            soket15 = new Socket
                      (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button150_Click(object sender, EventArgs e)
        {
            soket16.Close();
            soket16 = new Socket
                      (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button149_Click(object sender, EventArgs e)
        {
            soket17.Close();
            soket17 = new Socket
                      (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void button148_Click(object sender, EventArgs e)
        {
            soket18.Close();
            soket18 = new Socket
                      (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
///
        private void button84_Click(object sender, EventArgs e)
        {
            ip = System.IO.File.ReadAllLines(@"..\\Debug\ip.txt");
            MessageBox.Show(ip[0]+"\n"+ ip[1]+"\n" + ip[2]+"\n" + ip[3]+"\n" + ip[4] + "\n" + ip[5] + "\n" + ip[6] + "\n" + ip[7] + "\n"+ip[8] + "\n" + ip[9] + "\n" + ip[10] + "\n" + ip[11]+"\n" + ip[12] + "\n" + ip[13] + "\n" + ip[14] + "\n" + ip[15] + "\n" + ip[16] + "\n" + ip[17]);
        }
        private async void button97_Click(object sender, EventArgs e)
        {
            memoryModule1.WriteVirtualMemory<int>(r1 + 0xC, 1);
            memoryModule1.WriteVirtualMemory<int>(r1 + 0x224, 38);

            memoryModule2.WriteVirtualMemory<int>(r2 + 0xC, 1);
            memoryModule2.WriteVirtualMemory<int>(r2 + 0x224, 38);

            memoryModule3.WriteVirtualMemory<int>(r3 + 0xC, 1);
            memoryModule3.WriteVirtualMemory<int>(r3 + 0x224, 38);

            memoryModule4.WriteVirtualMemory<int>(r4 + 0xC, 1);
            memoryModule4.WriteVirtualMemory<int>(r4 + 0x224, 38);

            memoryModule5.WriteVirtualMemory<int>(r5 + 0xC, 1);
            memoryModule5.WriteVirtualMemory<int>(r5 + 0x224, 38);

            memoryModule6.WriteVirtualMemory<int>(r6 + 0xC, 1);
            memoryModule6.WriteVirtualMemory<int>(r6 + 0x224, 38);

            memoryModule7.WriteVirtualMemory<int>(r7 + 0xC, 1);
            memoryModule7.WriteVirtualMemory<int>(r7 + 0x224, 38);

            memoryModule8.WriteVirtualMemory<int>(r8 + 0xC, 1);
            memoryModule8.WriteVirtualMemory<int>(r8 + 0x224, 38);

            memoryModule9.WriteVirtualMemory<int>(r9 + 0xC, 1);
            memoryModule9.WriteVirtualMemory<int>(r9 + 0x224, 38);

            memoryModule10.WriteVirtualMemory<int>(r10 + 0xC, 1);
            memoryModule10.WriteVirtualMemory<int>(r10 + 0x224, 38);

            memoryModule11.WriteVirtualMemory<int>(r11 + 0xC, 1);
            memoryModule11.WriteVirtualMemory<int>(r11 + 0x224, 38);

            memoryModule12.WriteVirtualMemory<int>(r12 + 0xC, 1);
            memoryModule12.WriteVirtualMemory<int>(r12 + 0x224, 38);

            memoryModule13.WriteVirtualMemory<int>(r13 + 0xC, 1);
            memoryModule13.WriteVirtualMemory<int>(r13 + 0x224, 38);

            memoryModule14.WriteVirtualMemory<int>(r14 + 0xC, 1);
            memoryModule14.WriteVirtualMemory<int>(r14 + 0x224, 38);

            memoryModule15.WriteVirtualMemory<int>(r15 + 0xC, 1);
            memoryModule15.WriteVirtualMemory<int>(r15 + 0x224, 38);

            memoryModule16.WriteVirtualMemory<int>(r16 + 0xC, 1);
            memoryModule16.WriteVirtualMemory<int>(r16 + 0x224, 38);

            memoryModule17.WriteVirtualMemory<int>(r17 + 0xC, 1);
            memoryModule17.WriteVirtualMemory<int>(r17 + 0x224, 38);

            memoryModule18.WriteVirtualMemory<int>(r18 + 0xC, 1);
            memoryModule18.WriteVirtualMemory<int>(r18 + 0x224, 38);


            await Task.Delay(400);
            sgonder("1",soket1);
            sgonder("1", soket2);
            sgonder("1", soket3);
            sgonder("1", soket4);
            sgonder("1", soket5);
            sgonder("1", soket6);
            sgonder("1", soket7);
            sgonder("1", soket8);
            sgonder("1", soket9);
            sgonder("1", soket10);
            sgonder("1", soket11);
            sgonder("1", soket12);
            sgonder("1", soket13);
            sgonder("1", soket14);
            sgonder("1", soket15);
            sgonder("1", soket16);
            sgonder("1", soket17);
            sgonder("1", soket18);

        }

/////////////////////////////////////////////////////

        Task res()
        {
            return Task.Run(async () =>
            {
                while (resDurum == 1)
                {
                    await Task.Delay(200);
                    var hp1 = memoryModule1.ReadVirtualMemory<int>(hpAddr1);
                    if (hp1 == 0)
                    {
                        memoryModule1.WriteVirtualMemory<int>(resAddr1, 1);
                    }

                    var hp2 = memoryModule2.ReadVirtualMemory<int>(hpAddr2);
                    if (hp2 == 0)
                    {
                        memoryModule2.WriteVirtualMemory<int>(resAddr2, 1);
                    }

                    var hp3 = memoryModule3.ReadVirtualMemory<int>(hpAddr3);
                    if (hp3 == 0)
                    {
                        memoryModule3.WriteVirtualMemory<int>(resAddr3, 1);
                    }

                    var hp4 = memoryModule4.ReadVirtualMemory<int>(hpAddr4);
                    if (hp4 == 0)
                    {
                        memoryModule4.WriteVirtualMemory<int>(resAddr4, 1);
                    }

                    var hp5 = memoryModule5.ReadVirtualMemory<int>(hpAddr5);
                    if (hp5 == 0)
                    {
                        memoryModule5.WriteVirtualMemory<int>(resAddr5, 1);
                    }

                    var hp6 = memoryModule6.ReadVirtualMemory<int>(hpAddr6);
                    if (hp6 == 0)
                    {
                        memoryModule6.WriteVirtualMemory<int>(resAddr6, 1);
                    }

                    var hp7 = memoryModule7.ReadVirtualMemory<int>(hpAddr7);
                    if (hp7 == 0)
                    {
                        memoryModule7.WriteVirtualMemory<int>(resAddr7, 1);
                    }

                    var hp8 = memoryModule8.ReadVirtualMemory<int>(hpAddr8);
                    if (hp8 == 0)
                    {
                        memoryModule8.WriteVirtualMemory<int>(resAddr8, 1);
                    }

                    var hp9 = memoryModule9.ReadVirtualMemory<int>(hpAddr9);
                    if (hp9 == 0)
                    {
                        memoryModule9.WriteVirtualMemory<int>(resAddr9, 1);
                    }

                    var hp10 = memoryModule10.ReadVirtualMemory<int>(hpAddr10);
                    if (hp10 == 0)
                    {
                        memoryModule10.WriteVirtualMemory<int>(resAddr10, 1);
                    }

                    var hp11 = memoryModule11.ReadVirtualMemory<int>(hpAddr11);
                    if (hp11 == 0)
                    {
                        memoryModule11.WriteVirtualMemory<int>(resAddr11, 1);
                    }

                    var hp12 = memoryModule12.ReadVirtualMemory<int>(hpAddr12);
                    if (hp12 == 0)
                    {
                        memoryModule12.WriteVirtualMemory<int>(resAddr12, 1);
                    }

                    var hp13 = memoryModule13.ReadVirtualMemory<int>(hpAddr13);
                    if (hp13 == 0)
                    {
                        memoryModule13.WriteVirtualMemory<int>(resAddr13, 1);
                    }

                    var hp14 = memoryModule14.ReadVirtualMemory<int>(hpAddr14);
                    if (hp14 == 0)
                    {
                        memoryModule14.WriteVirtualMemory<int>(resAddr14, 1);
                    }

                    var hp15 = memoryModule15.ReadVirtualMemory<int>(hpAddr15);
                    if (hp15 == 0)
                    {
                        memoryModule15.WriteVirtualMemory<int>(resAddr15, 1);
                    }

                    var hp16 = memoryModule16.ReadVirtualMemory<int>(hpAddr16);
                    if (hp16 == 0)
                    {
                        memoryModule16.WriteVirtualMemory<int>(resAddr16, 1);
                    }

                    var hp17 = memoryModule17.ReadVirtualMemory<int>(hpAddr17);
                    if (hp17 == 0)
                    {
                        memoryModule17.WriteVirtualMemory<int>(resAddr17, 1);
                    }

                    var hp18 = memoryModule18.ReadVirtualMemory<int>(hpAddr18);
                    if (hp18 == 0)
                    {
                        memoryModule18.WriteVirtualMemory<int>(resAddr18, 1);
                    }

                }
            });
        }

        Task hpT()
        {
            return Task.Run(async () =>
            {
                while (resDurum == 1)
                {
                    await Task.Delay(200);
                    var hp1 = memoryModule1.ReadVirtualMemory<int>(hpAddr1);
                    var hp2 = memoryModule2.ReadVirtualMemory<int>(hpAddr2);
                    var hp3 = memoryModule3.ReadVirtualMemory<int>(hpAddr3);
                    var hp4 = memoryModule4.ReadVirtualMemory<int>(hpAddr4);
                    var hp5 = memoryModule5.ReadVirtualMemory<int>(hpAddr5);
                    var hp6 = memoryModule6.ReadVirtualMemory<int>(hpAddr6);
                    var hp7 = memoryModule7.ReadVirtualMemory<int>(hpAddr7);
                    var hp8 = memoryModule8.ReadVirtualMemory<int>(hpAddr8);
                    var hp9 = memoryModule9.ReadVirtualMemory<int>(hpAddr9);
                    var hp10 = memoryModule10.ReadVirtualMemory<int>(hpAddr10);
                    var hp11 = memoryModule11.ReadVirtualMemory<int>(hpAddr11);
                    var hp12 = memoryModule12.ReadVirtualMemory<int>(hpAddr12);
                    var hp13 = memoryModule13.ReadVirtualMemory<int>(hpAddr13);
                    var hp14 = memoryModule14.ReadVirtualMemory<int>(hpAddr14);
                    var hp15 = memoryModule15.ReadVirtualMemory<int>(hpAddr15);
                    var hp16 = memoryModule16.ReadVirtualMemory<int>(hpAddr16);
                    var hp17 = memoryModule17.ReadVirtualMemory<int>(hpAddr17);
                    var hp18 = memoryModule18.ReadVirtualMemory<int>(hpAddr18);
                    label1.Invoke((MethodInvoker)(() => label1.Text = (hp1).ToString()));
                    label2.Invoke((MethodInvoker)(() => label2.Text = (hp2).ToString()));
                    label3.Invoke((MethodInvoker)(() => label3.Text = (hp3).ToString()));
                    label4.Invoke((MethodInvoker)(() => label4.Text = (hp4).ToString()));
                    label5.Invoke((MethodInvoker)(() => label5.Text = (hp5).ToString()));
                    label6.Invoke((MethodInvoker)(() => label6.Text = (hp6).ToString()));
                    label7.Invoke((MethodInvoker)(() => label7.Text = (hp7).ToString()));
                    label8.Invoke((MethodInvoker)(() => label8.Text = (hp8).ToString()));
                    label9.Invoke((MethodInvoker)(() => label9.Text = (hp9).ToString()));
                    label10.Invoke((MethodInvoker)(() => label10.Text = (hp10).ToString()));
                    label11.Invoke((MethodInvoker)(() => label11.Text = (hp11).ToString()));
                    label12.Invoke((MethodInvoker)(() => label12.Text = (hp12).ToString()));
                    label22.Invoke((MethodInvoker)(() => label22.Text = (hp13).ToString()));
                    label23.Invoke((MethodInvoker)(() => label23.Text = (hp14).ToString()));
                    label24.Invoke((MethodInvoker)(() => label24.Text = (hp15).ToString()));
                    label19.Invoke((MethodInvoker)(() => label19.Text = (hp16).ToString()));
                    label20.Invoke((MethodInvoker)(() => label20.Text = (hp17).ToString()));
                    label21.Invoke((MethodInvoker)(() => label21.Text = (hp18).ToString()));
                }
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1 = time1 - 1;
            label13.Text = time1.ToString();
            if (time1 == 0) { timer1.Stop(); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time2 = time2 - 1;
            label14.Text = time2.ToString();
            if (time2 == 0) { timer2.Stop(); }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time3 = time3 - 1;
            label15.Text = time3.ToString();
            if (time3 == 0) { timer3.Stop(); }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            time4 = time4 - 1;
            label16.Text = time4.ToString();
            if (time4 == 0) { timer4.Stop();}
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            time5 = time5 - 1;
            label18.Text = time5.ToString();
            if (time5 == 0) { timer5.Stop(); }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            time6 = time6 - 1;
            label17.Text = time6.ToString();
            if (time6 == 0) { timer6.Stop(); }
        }
        public void sgonder(string deger,Socket s)
        {
            if (s.Connected)
            {
                string gonder = deger;
                s.Send(Encoding.UTF8.GetBytes(gonder));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace fgfgefgefg
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class DLL1
        {
            private const string DLL = "Lib.dll";
            [DllImport(DLL, CallingConvention = CallingConvention.Cdecl)]
            public static extern double TheFunc(double x);
            [DllImport(DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr FuncName();
        }
        class DLL2
        {
            private const string DLL = "Lib2-2-1.dll";
            [DllImport(DLL, CallingConvention = CallingConvention.Cdecl)]
            public static extern double TheFunc(double x);
            [DllImport(DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr FuncName();
        }
        class DLL3
        {
            private const string DLL = "Lib2-2-2.dll";
            [DllImport(DLL, CallingConvention = CallingConvention.Cdecl)]
            public static extern double TheFunc(double x);
            [DllImport(DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr FuncName();
        }
        class DLL4
        {
            private const string DLL = "Lib2-2-3-1.dll";
            [DllImport(DLL, CallingConvention = CallingConvention.Cdecl)]
            public static extern double TheFunc(double x);
            [DllImport(DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr FuncName();
        }
        class DLL5
        {
            private const string DLL = "Lib2-2-3-2.dll";
            [DllImport(DLL, CallingConvention = CallingConvention.Cdecl)]
            public static extern double TheFunc(double x);
            [DllImport(DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr FuncName();
        }
        class DLL6
        {
            private const string DLL = "Lib2-2-3.dll";
            [DllImport(DLL, CallingConvention = CallingConvention.Cdecl)]
            public static extern double TheFunc(double x);
            [DllImport(DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr FuncName();
        }
        class DLL7
        {
            private const string DLL = "DLL1.dll";
            [DllImport(DLL, CallingConvention = CallingConvention.Cdecl)]
            public static extern double TheFunc(double x);
            [DllImport(DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr FuncName();
        }
        class DLL8
        {
            private const string DLL = "DLL2.dll";
            [DllImport(DLL, CallingConvention = CallingConvention.Cdecl)]
            public static extern double TheFunc(double x);
            [DllImport(DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr FuncName();
        }
        class DLL9
        {
            private const string DLL = "DLL3.dll";
            [DllImport(DLL, CallingConvention = CallingConvention.Cdecl)]
            public static extern double TheFunc(double x);
            [DllImport(DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
            public static extern IntPtr FuncName();
        }
        class dll
        {
            public static List<Func<IntPtr>> ListFuncName = new List<Func<IntPtr>>
            {
                DLL1.FuncName,
                DLL2.FuncName,
                DLL3.FuncName,
                DLL4.FuncName,
                DLL5.FuncName,
                DLL6.FuncName,
                DLL7.FuncName,
                DLL8.FuncName,
                DLL9.FuncName

            };
            public static List<Func<double, double>> ListTheFunc = new List<Func<double, double>>
            {
                DLL1.TheFunc,
                DLL2.TheFunc,
                DLL3.TheFunc,
                DLL4.TheFunc,
                DLL5.TheFunc,
                DLL6.TheFunc,
                DLL7.TheFunc,
                DLL8.TheFunc,
                DLL9.TheFunc

            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
             void Sch(int x)
            {
                var series = this.chart1.Series[0];
                var fname = dll.ListFuncName.ElementAt(x -1);
                var tfunc = dll.ListTheFunc.ElementAt(x -1);
                double X = 1;
                int N = 1;
                while (N <= 100)
                {
                    
                series.Points.AddXY(X, tfunc(X)); 
                    
                X += 0.1;
                N++;
                }
            }

            Sch(comboBox1.SelectedIndex);
 
        }
    }
}

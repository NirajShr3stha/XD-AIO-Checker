using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZuttPal;

namespace Galaxy.Mainm
{
    class Start
    {

        public static void LoadCombos()
        {
            Console.WriteLine();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string fileName;
            do
            {
                openFileDialog.Title = "Load Combos";
                openFileDialog.DefaultExt = "txt";
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.RestoreDirectory = true;
                int num = (int)openFileDialog.ShowDialog();
                fileName = openFileDialog.FileName;
            }
            while (!File.Exists(fileName));
            try
            {
                Checking.combos = (IEnumerable<string>)File.ReadAllLines(fileName);
            }
            catch
            {
            }
            Thread.Sleep(500);
            Checking.comboTotal = Checking.combos.Count<string>();
        }
        public static void LoadProxies()
        {
            Console.WriteLine();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string fileName;
            do
            {
                openFileDialog.Title = "Load Proxies";
                openFileDialog.DefaultExt = "txt";
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.RestoreDirectory = true;
                int num = (int)openFileDialog.ShowDialog();
                fileName = openFileDialog.FileName;
            }
            while (!File.Exists(fileName));
            try
            {
                Checking.proxies = (IEnumerable<string>)File.ReadAllLines(fileName);
            }
            catch
            {
            }
            Checking.proxiesCount = Checking.proxies.Count<string>();
            Thread.Sleep(500);
        }
}
}

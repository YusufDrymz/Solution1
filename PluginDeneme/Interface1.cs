using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginDeneme
{
    public interface IHesap
    {
        int Hesapla(int a, int b);
        string Isim { get; }
    }
}

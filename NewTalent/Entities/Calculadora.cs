using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalent.Entities
{
    public class Calculadora
    {
        private List<string> _historico;
        private DateTime _dateTime;
        public Calculadora(DateTime date)
        {
            _dateTime = date;
            _historico = new List<string>();
        }
        public int Somar(int val1, int val2)
        {
            _historico.Insert(0, $"Val: {val1+val2}\nData: {_dateTime}");
            return val1 + val2;
        }
        public int Subtrair(int val1, int val2)
        {
            _historico.Insert(0, $"Val: {val1-val2}\nData: {_dateTime}");
            return val1 - val2;
        }
        public int Multiplicar(int val1, int val2)
        {
            _historico.Insert(0, $"Val: {val1*val2}\nData: {_dateTime}");
            return val1 * val2;
        }
        public int Dividir(int val1, int val2)
        {
            _historico.Insert(0, $"Val: {val1/val2}\nData: {_dateTime}");
            return val1 / val2;
        }
        public List<string> Historico(){
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }
    }
}
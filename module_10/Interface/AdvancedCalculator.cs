using module_10.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10.Interface
{
    public class AdvancedCalculator : SimpleCalculator, IStorable
    {
        public void SaveState(string fileName)
        {
            Console.WriteLine($"Сохранение состояния в файл: {fileName}");
        }

        public void LoadState(string fileName)
        {
            Console.WriteLine($"Загрузка состояния из файла: {fileName}");
        }

    }
}

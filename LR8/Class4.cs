using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR8
{
    public partial class Form1 : Form
    {
        public interface IObserver
        {
            // Получает обновление от издателя
            void Update(ISubject subject);
        }

        public interface ISubject
        {
            // Присоединяет наблюдателя к издателю.
            void Attach(IObserver observer);

            // Отсоединяет наблюдателя от издателя.
          //  void Detach(IObserver observer);

            // Уведомляет всех наблюдателей о событии.
            void Notify();
        }
    }
}

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

    public class Array
    {
        protected TreeViewer observers;//создаю объект класса TreeViewer
        public Figure[] objects; // указатель на указатель объекта 
        private int maxsize = 0;//размер массива максимальный
        private int size = 0; // размер массива
        public Array(int maxsize)
        {// конструктор                 
            objects = new Figure[maxsize];// создаю массив из объектов
            for (int i = 0; i < maxsize; ++i)
                objects[i] = null;

        }



        public void set_value(ref Figure value)//добавление объекта в хранилище
        {
            objects[size] = value;//добавляем объект в свободную ячейку
                                  // objects[size].NotifyCreate();
            size++;
            Notify();
            return;
        }


        public Figure get_value(int i)
        {
            return objects[i];//возвращаем объект по индексу
        }
        public int get_count()
        {
            return size;//возвращаем нынешний размер массива
        }
        public void delete_value(int index)
        {
            if (index < 0 || index >= size)
            {//если выходим за нынешний размер массива

                return;
            }
            for (int i = index + 1, j = index; i <= size; i++, j++)
            {

                objects[j] = objects[i];//смещаем элементы, "затирая" элемент по индексу
            }
            //  objects[index].NotifyDelete();
            size--;
            Notify();
        }

        public bool Empty(int CountElem)
        {
            if (objects[CountElem] == null)
                return true;
            else return false;
        }
         public void SelectF (int i, bool a)
        {
            objects[i].IsSelect(a);
            Notify();
        }
        public void SaveFigures(string filename)//сохранение данных о фигурах в текстовый файл
        {
            StreamWriter writer = new StreamWriter(filename, true, System.Text.Encoding.Default); //создаем «потоковый писатель» и связываем его с файловым потоком
            writer.WriteLine(size); //записываем в файл с добавлением новой строки

            for (int i = 0; i < size; ++i)
                objects[i].Save(writer);
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется
        }
        public void ReadFigures(string filename)//чтение из текстового файла
        {
            List<string> list = File.ReadAllLines("C:/Users/User/Desktop/учеба/2 КУРС/ООП/LR8/LR8/bin/Debug/Figures.txt").ToList();
            int count = Int32.Parse(list[0]);
            list.RemoveAt(0);
            for (int i = 0; i < count; ++i)
            {
                objects[i] = SwitchFigure(ref list);
                size++;
                // SwitchFigure(ref reader);
            }
        }
        public Figure SwitchFigure(ref List<string> reader)
        {

            string line = reader[0];
            reader.RemoveAt(0);
            Figure f = null;
            switch (line)
            {
                case "C":
                    f = new Circle();
                    f.Load(reader);
                    break;
                case "L":
                    f = new Line();
                    f.Load(reader);
                    break;
                case "S":
                    f = new Square();
                    f.Load(reader);
                    break;
                case "T":
                    f = new Triangle();
                    f.Load(reader);
                    break;
                case "G":
                    f = new CGroup(10);
                    f.Load(reader);

                    break;

            }
            reader.RemoveAt(0);
            return f;
        }


        public void OnSubjectChanged(TreeViewer tree)
            {
                int index = 0;
                foreach (TreeNode i in tree.TreeView.Nodes[0].Nodes)
                {
                    ProcessNode(i, index);
                    index++;
                }

            }

            public bool ProcessNode(TreeNode i, int index)
            {
                if (i.IsSelected)//если ветка дерева выделена
                {
                    objects[index].IsSelect(true);// выделается соответствующий объект
                    return true;
                }
                if (i.Nodes.Count > 0)
                {
                    foreach (TreeNode tn in i.Nodes)
                        if (ProcessNode(tn, 0))
                            return true;
                }
                objects[index].IsSelect(false);
                return false;
            }

            public void AddObservers(TreeViewer t)
            {
                observers = t;
            }

            protected void Notify()
            {
                if (observers != null)
                    observers.OnSubjectChanged(this);
            }

            public void UpdateStickyShapes(Figure s, Graphics g)
            {
                Array t = new Array(100);
            // Set_current_first();
            // for (bool cond = !Is_empty(); cond; cond = Step_forward())
            for (int i = 0; i < 100; i++)
                if (s != objects[i] && s.CloseTo(objects[i]))
                    t.set_value(ref objects[i]);                    
                s.ChangeObservers(t);
            }
        

    };


    
}

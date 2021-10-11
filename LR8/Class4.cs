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

        public class TreeViewer
        {
            private TreeView treeView;

            private Array observers;

            public TreeViewer(TreeView tree)
            {
                treeView = tree;
            }

            public void OnSubjectChanged(Array L)
            {
                treeView.BeginUpdate();
                treeView.Nodes[0].Nodes.Clear();
                int j = 0;
            
                for (int i = 0;i<observers.get_count();i++)
                {
                    TreeNode node = new TreeNode();
                    treeView.Nodes[0].Nodes.Add(node);
                    if (L.get_value(i) != null)
                        treeView.SelectedNode = node;
                    ProcessNode(treeView.Nodes[0].Nodes[j++],
                        L.get_value(i));

                }
                treeView.EndUpdate();
            }

            protected void ProcessNode(TreeNode tn, Figure a)//изменить 
            {
                if (a != null)
            {
                tn.Text = a.ToString().Substring(4);
            }
            int j = 0;   
                CGroup gr = a as CGroup;
                if (gr != null) 
                    for(int i=0;i<gr.Count;i++)
                    {
                        tn.Nodes.Add(new TreeNode());
                        ProcessNode(tn.Nodes[j++], gr.FFigure(i));
                    }

            }

            public void AddObs(Array a)
            {
                observers = a;
            }

            private void Notify()
            {
                if (observers != null)
                    observers.OnSubjectChanged(this);
            }

            public void SelectedChanged()
            {
                Notify();
            }

            public TreeView TreeView { get => treeView; }

         /*   internal Array Array
            {
                get => default(Array);
               
            }*/
        }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLlista = new ObservableCollection<int>();
        public MainWindow()
        {
            InitializeComponent();
            miLlista.Add(248);
            miLlista.Add(30);
            miLlista.Add(39);
            miLlista.Add(16);
            miLlista.Add(125);
            miLlista.Add(69);
            miLlista.Add(62);
            miLlista.Add(420);

            ListaNumeros.ItemsSource = miLlista;
            
        }

        private void BotonOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /*var temp = miLlista[0];

            miLlista[0] = miLlista[3]; //Eelemento 0 es igual al elemento 3
            miLlista[3] = temp; */

            int gap, temp, i, j;
            gap = miLlista.Count / 2;

            while(gap > 0)
            {
                for(i=0; i<miLlista.Count; i++)
                {
                    if(miLlista[i] > miLlista[gap + i])
                    {
                        temp = miLlista[i];
                        miLlista[i] = miLlista[gap + i];
                        miLlista[gap + i] = temp;
                    }
                }
                gap--;
            }
        }
    }
}

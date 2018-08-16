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

namespace PracticaLineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (float i=0; i<=360; i++)
            {
                sol.Points.Add(new Point(Math.Cos(i) * 50 + 100, Math.Sin(i) * 50 + 100));
            }

          
            cuadrado.Points.Add(new Point(200.0, 380.0));
            cuadrado.Points.Add(new Point(200.0, 300.0)); //linea izq
            cuadrado.Points.Add(new Point(300.0, 300.0)); //linea arriba
            cuadrado.Points.Add(new Point(300.0, 380.0)); //linea der
            cuadrado.Points.Add(new Point(200.0, 380.0)); //linea abajo


            rectangulo.Points.Add(new Point(280.0, 380.0));
            rectangulo.Points.Add(new Point(280.0, 350.0)); //linea der
            rectangulo.Points.Add(new Point(260.0, 350.0));//linea arriba
            rectangulo.Points.Add(new Point(260.0, 380.0)); //linea izq


            ventana.Points.Add(new Point(230.0, 350.0));
            ventana.Points.Add(new Point(230.0, 330.0)); //linea der
            ventana.Points.Add(new Point(210.0, 330.0));//linea arriba
            ventana.Points.Add(new Point(210.0, 350.0)); //linea izq
            ventana.Points.Add(new Point(230.0, 350.0)); //linea abajo


            triangulo.Points.Add(new Point(200.0, 300.0));
            triangulo.Points.Add(new Point(250.0,268.0));
            triangulo.Points.Add(new Point(298.0, 300.0));

            tronco.Points.Add(new Point(380.0, 260.0));
            tronco.Points.Add(new Point(380.0, 380.0));
            tronco.Points.Add(new Point(380.0, 380.0));
            tronco.Points.Add(new Point(430.0, 380.0));
            tronco.Points.Add(new Point(430.0, 260.0));

            hojas.Points.Add(new Point(430.0, 260.0));
            hojas.Points.Add(new Point(450.0, 220.0));
            hojas.Points.Add(new Point(450.0, 180.0));
            hojas.Points.Add(new Point(430.0, 120.0));
            hojas.Points.Add(new Point(375.0, 120.0));
            hojas.Points.Add(new Point(355.0, 180.0));
            hojas.Points.Add(new Point(355.0, 220.0));
            hojas.Points.Add(new Point(380.0, 260.0));


            cesped.Points.Add(new Point(50.0, 380.0));
            cesped.Points.Add(new Point(70.0, 360.0));
            cesped.Points.Add(new Point(90.0, 380.0));
            cesped.Points.Add(new Point(110.0, 360.0));
            cesped.Points.Add(new Point(130.0, 380.0));
            cesped.Points.Add(new Point(150.0, 360.0));
            cesped.Points.Add(new Point(170.0, 380.0));
        }
    }
}

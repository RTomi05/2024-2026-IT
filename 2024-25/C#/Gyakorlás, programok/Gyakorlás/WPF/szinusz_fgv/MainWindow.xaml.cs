﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace szinusz_fgv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /// https://www.youtube.com/watch?v=Q55T6LeTvsA
    /// 
    /// Amiket meg kell csinálnunk:
    /// -koordináta-rendszer    DONE
    /// -körív  
    /// -magasság (szinuszérték / piros függőleges vonal)   DONE
    /// -nagy, vékony keretes kör
    /// fekete pont (aktuális x hely)   DONE
    /// -belső szög körív
    /// -fekete sugár
    /// -kék vízszintes, vastag vonal
    /// -infodoboz


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sinus_Loaded(object sender, RoutedEventArgs e)
        {
            /// Amiket meg kell csinálnunk:
            /// -koordináta-rendszer
            /// -körív
            /// -magasság (szinuszérték / piros függőleges vonal
            /// -nagy, vékony keretes kör
            /// fekete pont (aktuális x hely)
            /// -belső szög körív
            /// -fekete sugár
            /// -kék vízszintes, vastag vonal
            /// -infodoboz
            /// 
            origoX = r;
            origoY = (int)(sinus.ActualHeight / 2);

            pontok.Add(
                            new Point(origoX,
                                origoY
                                )
                            );

            //rajzol();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += rajzol;
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Start();
        }

        int szog = 0;
        bool eloreMegy = true;

        void rajzol(object sender, EventArgs e)
        {
            sinus.Children.Clear();
            koordinataRendszer();
            pirosvonal(szog);
            feketeKor(szog);
            sugar(szog);
            kekKor(szog);
            szinuszGorbe(szog);
            korIvKicsi(szog);
            korIvNagy(szog);

            if (eloreMegy)
            {
                
                szog += 3;
            }
            else
            {
                szog -= 3;
            }

            if (szog >= 360)
            {
                eloreMegy = false;
            }

            if(szog <= 0)
            {
                eloreMegy = true;
            }
        }

        int origoX = 00;
        int origoY = 0;
        int r = 100;

        void koordinataRendszer()
        {
            Line xTengely = new Line();
            xTengely.Stroke = Brushes.Black;
            xTengely.X1 = 0;
            xTengely.Y1 = origoY;
            xTengely.X2 = sinus.ActualWidth;
            xTengely.Y2 = origoY;

            sinus.Children.Add(xTengely);

            Line yTengely = new Line();
            yTengely.Stroke = Brushes.Black;
            yTengely.X1 = origoX;
            yTengely.Y1 = 0;
            yTengely.X2 = origoX;
            yTengely.Y2 = sinus.ActualHeight;

            sinus.Children.Add(yTengely);

            for (int i = 45; i < 500; i+=45)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = i + origoX;
                vonalka.Y1 = origoY - 5;
                vonalka.X2 = i + origoX;
                vonalka.Y2 = origoY + 5;

                sinus.Children.Add(vonalka);
            }

            for (double i = -1; i <= 1; i += 0.5)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = origoX - 5;
                vonalka.Y1 = origoY + r * i;
                vonalka.X2 = origoX + 5;
                vonalka.Y2 = origoY + r * i;

                sinus.Children.Add(vonalka);
            }

            //VAGY

            for (int i = -2; i < 3; i++)
            {
                Line vonalka = new Line();
                vonalka.Stroke = Brushes.Black;
                vonalka.X1 = origoX - 5;
                vonalka.Y1 = origoY + i * r/2;
                vonalka.X2 = origoX + 5;
                vonalka.Y2 = origoY + i * r/2;

                sinus.Children.Add(vonalka);
            }

        }
        void feketeKor(int x)
        {
            Ellipse k = new Ellipse();
            k.Width = r / 10;
            k.Height = r / 10;
            k.Margin = new Thickness(origoX - k.Width / 2 + x, origoY - k.Height / 2, 0, 0);

            k.Stroke = Brushes.Black;
            k.Fill = Brushes.Black;

            sinus.Children.Add(k);

        }

        void pirosvonal(int x)
        {
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;

            Line v = new Line();
            v.Stroke = Brushes.Red;
            v.StrokeThickness = 3;

            v.X1 = origoX + x;
            v.Y1 = origoY;
            v.X2 = origoX + x;
            v.Y2 = origoY - magassag;

            sinus.Children.Add(v);

        }

        void sugar(int x)
        {
            double dX = Math.Cos(x / 180.0 * Math.PI) * r;
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;

            Line v = new Line();
            v.Stroke = Brushes.Black;
            v.StrokeThickness = 3;

            v.X1 = origoX + x;
            v.Y1 = origoY - magassag;
            v.X2 = origoX + x - dX;
            v.Y2 = origoY;

            sinus.Children.Add(v);

        }

        void kekKor(int x)
        {
            double dX = Math.Cos(x / 180.0 * Math.PI) * r;
            Ellipse kor = new Ellipse();
            kor.Stroke = Brushes.Blue;
            kor.StrokeThickness = 1;
            kor.Width = 2 * r;
            kor.Height = 2 * r;

            kor.Margin = new Thickness(origoX + x - dX - r,
                                        origoY - r,
                                        0, 0);

            sinus.Children.Add(kor);
        }


        PointCollection pontok = new PointCollection();
        void szinuszGorbe(int x)
        {
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;

            if(eloreMegy)
            {
                pontok.Add(new Point(x + origoX,
                                origoY - magassag)
                                );
            }
            
            Polyline vonal = new Polyline();
            vonal.Stroke = Brushes.Red;
            vonal.StrokeThickness = 3;
            //vonal.FillRule = FillRule.EvenOdd;
            vonal.Points = pontok;
            sinus.Children.Add(vonal);

            if (eloreMegy == false)
            {
                pontok.Remove(pontok.Last());
            }
        }

        void korIvKicsi(int x)
        {
            double dX = Math.Cos(x / 180.0 * Math.PI) * r;
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;

            Path path = new Path();
            path.Stroke = Brushes.Blue;
            path.StrokeThickness = 3;
            

            PathGeometry pathGeometry = new PathGeometry();

            /*
            v.X1 = origoX + x;
            v.Y1 = origoY - magassag;
            v.X2 = origoX + x - dX;
            v.Y2 = origoY;
            */

            double x1 = origoX + x - dX;
            double y1 = origoY;
            double x2 = origoX + x;
            double y2 = origoY - magassag;

            double x3 = x1 - (x1 - x2) / 10;
            double y3 = y1 - (y1 - y2) / 10;

            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = new Point(origoX + x - dX + r*0.1, origoY);

            ArcSegment arcSegment = new ArcSegment();
            arcSegment.Point = new Point(x3,y3);
            arcSegment.Size = new Size(r * 0.1, r * 0.1);
            arcSegment.SweepDirection = SweepDirection.Counterclockwise;

            arcSegment.IsLargeArc = x%360 > 180;

            pathFigure.Segments.Add(arcSegment);
            pathGeometry.Figures.Add(pathFigure);
            path.Data = pathGeometry;

            sinus.Children.Add(path);

        }

        void korIvNagy(int x)
        {
            double dX = Math.Cos(x / 180.0 * Math.PI) * r;
            double magassag = Math.Sin(x / 180.0 * Math.PI) * r;
            Path path = new Path();
            path.Stroke = Brushes.Blue;
            path.StrokeThickness = 3;


            PathGeometry pathGeometry = new PathGeometry();


            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = new Point(origoX + x - dX + r, origoY);

            ArcSegment arcSegment = new ArcSegment();
            arcSegment.Point = new Point(x + origoX, origoY - magassag);
            arcSegment.Size = new Size(r, r);
            arcSegment.SweepDirection = SweepDirection.Counterclockwise;

            arcSegment.IsLargeArc = x%360 > 180;

            pathFigure.Segments.Add(arcSegment);
            pathGeometry.Figures.Add(pathFigure);
            path.Data = pathGeometry;

            sinus.Children.Add(path);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;



namespace rlc
{
    public class redno
    {
        public static double propracun(double r, double l, double c, double F, double um, double pfu, double im)
        {
            double R = r;
            double L = l;
            double C = c;
            double f = F;
            double Um = um;
            double Pfu = pfu;         
            double W = 2 * 3.14 * f;
            double X=(1 / C * W*0.000001)-L*0.001 * W ;
            double Z = Math.Sqrt(R * R + X*X);
            im = Um / Z;
            return im ;
            
        }
        public static double propracun1 (double r, double l, double c, double F, double um, double pfu, double pfi)
        {
            double R = r;
            double L = l;
            double C = c;
            double f = F;
            double Um = um;
            double Pfu = pfu;

            double W = 2 * 3.14 * f;
            double xl = W * L*0.001;
            double xc=1/(W*C*0.000001);
            double fi =( (xl - xc) / R);
            double fr = Math.Atan(fi)*180/Math.PI;
            pfi = Um - fr;         
            return pfi;

        }
        public static double propracun2(double r, double l, double c, double F, double im, double ul)
        {
            double R = r;
            double L = l;
            double C = c;
            double f = F;
            double Im = im;

            double W = 2 * 3.14 * f;
            double xl = W * L * 0.001;
            ul = xl * (Im / Math.Sqrt(2));
            return ul;
        }
            public static double propracun3(double r, double l, double c, double F, double im, double uc )
        {
            double R = r;
            double L = l;
            double C = c;
            double f = F;
            double Im = im;            
            double W = 2 * 3.14 * f;
            
            double xc = 1 / (W * C * 0.000001);
            uc=xc*(Im/Math.Sqrt(2));            
            return uc;         
                                 
        }
            public static double propracun4(double F)
            {                 
                double f = F;               
                double W = 2 * 3.14 * f;         
                return W;
            }
            public static double propracun5(double r, double im, double ur)
            {
                double R = r;           
                double Im = im;               
                ur = R * (Im / Math.Sqrt(2));
                return ur;

            }
            public static void crtaj(int x0,int y0, Graphics g)
            {              
                Pen olovka = new Pen(Color.Red);
                g.DrawLine(olovka, 0, y0, 434, y0);
                g.DrawLine(olovka, x0, 0, x0,254);
            }
            public static void crtaju (int x0, int y0, Graphics g, double um,double pfu)
            {
                double U = um / Math.Sqrt(2);
                double x = U * Math.Cos(pfu * Math.PI / 180);
                double y = U * Math.Sin(pfu * Math.PI / 180);
                Pen olovka = new Pen(Color.Blue);                
                g.DrawLine(olovka, x0, y0,(x0+ Convert.ToInt32(x)),y0- Convert.ToInt32(y));
                
            }
            public static void crtaji(int x0, int y0, Graphics g, double um, double pfu)
            {
                double U = um / Math.Sqrt(2);
                double x = U * Math.Cos(pfu * Math.PI / 180);
                double y = U * Math.Sin(pfu * Math.PI / 180);
                Pen olovka = new Pen(Color.Green);
                g.DrawLine(olovka, x0, y0, (x0 + Convert.ToInt32(x)), y0 - Convert.ToInt32(y));

            }
            




            
    }
}

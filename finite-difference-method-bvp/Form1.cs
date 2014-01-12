using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finite_difference_method_bvp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calculate();
        }

        // Функция коэффициентов при 1-й производной u'(t)
        private double p(double t)
        {
            return Math.Sin(t) / Math.Cos(t);
        }

        // Функция коэффициентов при u(t)
        private double g(double t)
        {
            return Math.Sqrt(Math.Cos(t));
        }

        // Функция правой части уравнения
        private double f(double t)
        {
            return 0;
        }

        // Точное решение yt(t)
        private double yt(double t)
        {
            double c1 = (10 - Math.Cos(Math.Sin(1))) / Math.Sin(Math.Sin(1));
            return Math.Cos(Math.Sin(t)) + c1 * Math.Sin(Math.Sin(t));
        }

        private void calculate()
        {
            result.DataSource = null;
            epsMaxTextBox.Clear();
            int n = (int)nSpinBox.Value + 1; // Число точек + 1
            double a = (double)aSpinBox.Value; // Границы интервала
            double b = (double)bSpinBox.Value;
            if (a >= b)
            {
                return;
            }
            // Краевые условия
            int k1 = (int)k1SpinBox.Value;
            int k2 = (int)k2SpinBox.Value;
            int a1 = (int)a1SpinBox.Value;
            int l1 = (int)l1SpinBox.Value;
            int l2 = (int)l2SpinBox.Value;
            int b1 = (int)b1SpinBox.Value;
            double h, eps, epsmax = 0;
            double[] al = new double[n], bet = new double[n], t = new double[n],
                u = new double[n], aa = new double[n], bb = new double[n],
                cc = new double[n], ff = new double[n];
            int i;
            DataTable resultData = new DataTable();
            DataRow row;
            result.DataSource = resultData;
            // Вычисление шага сетки
            h = (b - a) / n;
            // Формирование векторов коэффициентов для 3-диагональной СЛАУ
            for (i = 0; i < n; ++i)
            {
                t[i] = a + h * i;
                aa[i] = 1 - p(t[i]) * h / 2;
                bb[i] = 1 + p(t[i]) * h / 2;
                cc[i] = 2 - g(t[i]) * h * h;
                ff[i] = h * h * f(t[i]);
            }
            // Краевое условие при t == a
            al[1] = k2 / (k2 - k1 * h);
            bet[1] = -(a1 * h) / (k2 - k1 * h);
            // Прямой ход метода прогонки
            for (i = 1; i < n - 1; ++i)
            {
                al[i + 1] = bb[i] / (cc[i] - al[i] * aa[i]);
                bet[i + 1] = (aa[i] * bet[i] - ff[i]) / (cc[i] - al[i] * aa[i]);
            }
            // Решение на правой границе отрезка
            u[n - 1] = (l2 * bet[n - 1] + b1 * h) / (l2 + h * l1 - l2 * al[n - 1]);
            // Обратный ход метода прогонки
            for (i = n - 2; i >= 0; --i)
            {
                u[i] = al[i + 1] * u[i + 1] + bet[i + 1];
            }
            // Вывод таблицы и определение макс.погрешности
            resultData.Columns.Add(new DataColumn("i"));
            resultData.Columns.Add(new DataColumn("t[i]"));
            resultData.Columns.Add(new DataColumn("y[i]"));
            resultData.Columns.Add(new DataColumn("yt[i]"));
            resultData.Columns.Add(new DataColumn("Погрешность"));
            for (i = 0; i < n; ++i)
            {
                eps = Math.Abs(u[i] - yt(t[i]));
                if (i == 0 || eps > epsmax)
                {
                    epsmax = eps;
                }
                row = resultData.NewRow();
                row["i"] = i;
                row["t[i]"] = t[i];
                row["y[i]"] = u[i];
                row["yt[i]"] = yt(t[i]);
                row["Погрешность"] = eps;
                resultData.Rows.Add(row);
            }
            epsMaxTextBox.Text = epsmax.ToString();
        }

        private void nSpinBox_ValueChanged(object sender, EventArgs e)
        {
            calculate();
        }
    }
}

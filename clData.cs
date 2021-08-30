using System;
using System.Collections.Generic;
using System.Text;

namespace caData
{
    class Data
    {
        //Atributos
        private int dia;
        private int mes;
        private int ano;

        //Construtores
        public Data()
        {
            dia = 0;
            mes = 0;
            ano = 0;
        }

        public Data(int _D, int _M, int _A)
        {
            dia = _D;
            mes = _M;
            ano = _A;
        }

        //getters
        public int getDia()
        {
            return dia;
        }

        public int getMes()
        {
            return mes;
        }

        public string getMesExtenso()
        {
            string[] meses = new string[] {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            return meses[mes-1];
        }

        public int getAno()
        {
            return ano;
        }

        //Setters
        public void setDia(int _d)
        {
            dia = _d;
        }
        public void setMes(int _m)
        {
            mes = _m;
        }
        public void setAno(int _a)
        {
            ano = _a;
        }

        public int Compara (Data t)
        {
            if (this.ano == t.ano & this.mes == t.mes & this.dia == t.dia)
            {
                return 0;
            }

            if (this.ano >= t.ano & this.mes >= t.mes & this.dia >= t.dia)
            {
                return 1;
            }

            else return -1;
        } 

        public Boolean isBissexto()
        {
            if ((this.ano % 4) == 0)
            {
                if ((this.ano % 400) == 0)
                {
                    return true;
                }
                if ((this.ano % 100) != 0)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public Data clone()
        {
            Data t = new Data(this.dia, this.mes, this.ano);
            return t;
        }
    }
}

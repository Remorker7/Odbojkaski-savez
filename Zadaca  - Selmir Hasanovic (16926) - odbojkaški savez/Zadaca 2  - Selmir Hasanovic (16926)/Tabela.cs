using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    public partial class Tabela : Form
    {
        const int brojKlubova = 4;
        const int brojKola = 6;
        List<int> _bos, _bis, _bodovi;
        List<Klub> _klubovi;
        public Tabela(List<Klub> _Klubovi, List<int> _Bos, List<int> _Bis, List<int> _Bodovi)
        {
            InitializeComponent();
            _bos = _Bos;
            _bis = _Bis;
            _bodovi = _Bodovi;
            _klubovi = _Klubovi;
            for (int i = 0; i < brojKlubova; i++)
            {
                for (int j = i + 1; j < brojKlubova; j++)
                {
                    if (_bodovi[i] < _bodovi[j])
                    {
                        int temp;
                        temp = _bodovi[i];
                        _bodovi[i] = _bodovi[j];
                        _bodovi[j] = temp;
                        temp = _bis[i];
                        _bis[i] = _bis[j];
                        _bis[j] = temp;
                        temp = _bos[i];
                        _bos[i] = _bos[j];
                        _bos[j] = temp;
                        Klub temp1;
                        temp1 = _klubovi[i];
                        _klubovi[i] = _klubovi[j];
                        _klubovi[j] = temp1;
                    }
                    else if (_bodovi[i] == _bodovi[j])
                    {
                        if ((_bos[i] - _bis[i]) < (_bos[j] - _bis[j]))
                        {
                            int temp;
                            temp = _bodovi[i];
                            _bodovi[i] = _bodovi[j];
                            _bodovi[j] = temp;
                            temp = _bis[i];
                            _bis[i] = _bis[j];
                            _bis[j] = temp;
                            temp = _bos[i];
                            _bos[i] = _bos[j];
                            _bos[j] = temp;
                            Klub temp1;
                            temp1 = _klubovi[i];
                            _klubovi[i] = _klubovi[j];
                            _klubovi[j] = temp1;
                        }
                    }
                }
            }

            LK1.Text = _klubovi[0].Prefiks + " " + _klubovi[0].Naziv;
            LK2.Text = _klubovi[1].Prefiks + " " + _klubovi[1].Naziv;
            LK3.Text = _klubovi[2].Prefiks + " " + _klubovi[2].Naziv;
            LK4.Text = _klubovi[3].Prefiks + " " + _klubovi[3].Naziv;
            LBP1.Text = (_bodovi[0] / 3).ToString();
            LBI1.Text = (brojKola - _bodovi[0] / 3).ToString();
            LBP2.Text = (_bodovi[1] / 3).ToString();
            LBI2.Text = (brojKola - _bodovi[1] / 3).ToString();
            LBP3.Text = (_bodovi[2] / 3).ToString();
            LBI3.Text = (brojKola - _bodovi[2] / 3).ToString();
            LBP4.Text = (_bodovi[3] / 3).ToString();
            LBI4.Text = (brojKola - _bodovi[3] / 3).ToString();
            LBOS1.Text = _bos[0].ToString();
            LBIS1.Text = _bis[0].ToString();
            LB1.Text = _bodovi[0].ToString();
            LBOS2.Text = _bos[1].ToString();
            LBIS2.Text = _bis[1].ToString();
            LB2.Text = _bodovi[1].ToString();
            LBOS3.Text = _bos[2].ToString();
            LBIS3.Text = _bis[2].ToString();
            LB3.Text = _bodovi[2].ToString();
            LBOS4.Text = _bos[3].ToString();
            LBIS4.Text = _bis[3].ToString();
            LB4.Text = _bodovi[3].ToString();
        }
    }
}

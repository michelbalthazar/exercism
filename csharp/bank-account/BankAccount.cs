using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class BankAccount
{
    public BankAccount()
    {

    }
    private double _valor = 0;
    private bool _open { get; set; }

    private Object bloqueio = new Object();

    public void Open ()
    {
        _open = true;
    }
    public void Close ()
    {
        _open = false;
    }
    public double Balance ()
    {
        if (_open == false)
        {
            throw new InvalidOperationException("Abrir a conta para executar essa ação!");

        }
        return _valor;
    }

    public void UpdateBalance (double valor)
    {
        lock (bloqueio)
        {
            _valor += valor;
        }
    }
}
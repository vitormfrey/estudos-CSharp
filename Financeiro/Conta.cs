using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    class Conta
    {
        public string titular = "";
        public int numeroConta = 1;
        public Double saldo = 0;
    
    
        public Boolean Sacar(Double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Despositar( Double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(Double valor, Conta c)
        {
            if (Sacar(valor))
                c.Despositar(valor);
            
        }
    }
}
